using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionVizualizer.Controls
{
    [CvControlDisplayNameAttribute("Threshold Operation")]
    public partial class ThresholdOperation : CVIOBase
    {
        public ThresholdOperation()
        {
            InitializeComponent();

            ThresholdBar.SetMax(100);

            List<Item> thresholds = [
            new Item() { Text = "Binary", Value = 0 },
            new Item() { Text = "BinaryInv", Value = 1 },
            new Item() { Text = "Trunc", Value = 2 },
            new Item() { Text = "ToZero", Value = 3 },
            new Item() { Text = "ToZeroInv", Value = 4 }//,
            //new Item() { Text = "Mask", Value = 7 },
            //new Item() { Text = "Otsu", Value = 8 },
            //new Item() { Text = "Triangle", Value = 16 }
            ];

            OptionSelector.DataSource = thresholds;
            OptionSelector.DisplayMember = "Text";
            OptionSelector.ValueMember = "Value";

            //OptionSelector.SelectedIndexChanged += LockThreshold;

            OptionSelector.SelectedIndexChanged += Adjust;
            InputImage.ImageSubmitted += Adjust;
            ThresholdBar.SliderChanged += Adjust;
            MaxValueBar.SliderChanged += Adjust;
        }

        private void Adjust(object sender, EventArgs e)
        {
            if (InputImage.GetImage() != null)
            {
                using Mat output = new Mat();

                if (OptionSelector.Text == "Binary") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.Binary);
                else if (OptionSelector.Text == "BinaryInv") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.BinaryInv);
                else if (OptionSelector.Text == "Trunc") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.Trunc);
                else if (OptionSelector.Text == "ToZero") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.ToZero);
                else if (OptionSelector.Text == "ToZeroInv") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.ToZeroInv);
                //else if (OptionSelector.Text == "Mask") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.Mask);
                //else if (OptionSelector.Text == "Otsu") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.Otsu);
                //else if (OptionSelector.Text == "Triangle") CvInvoke.Threshold(InputImage.GetImage(), output, ThresholdBar.GetValue(), MaxValueBar.GetValue(), ThresholdType.Triangle);

                OutputImage.SetImage(output);
            }
        }

        //private void LockThreshold(object sender, EventArgs e)
        //{
        //    if (OptionSelector.Text == "Otsu" || OptionSelector.Text == "Triangle")
        //    {
        //        ThresholdBar.SetValue(0);
        //        ThresholdBar.Enabled = false;
        //    }
        //    else ThresholdBar.Enabled = true;
        //}
    }
}
