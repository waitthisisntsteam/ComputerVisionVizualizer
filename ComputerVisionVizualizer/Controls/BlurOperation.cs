using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionVizualizer.Controls
{
    public partial class BlurOperation : CVIOBase
    {
        public BlurOperation()
        {
            InitializeComponent();

            SizeBar.SliderChanged += Blur;
            SizeBar.SetName("Size:");
            SizeBar.SetValue(1);
            SizeBar.SetMin(2);
            SizeBar.SetMax(10);
            SizeBar.SetTickIncrement(2);


            List<Item> blurOptions = [
            new Item() { Text = "Gaussian", Value = 0 },
            new Item() { Text = "Median", Value = 1 }
            ];

            BlurSelector.DataSource = blurOptions;
            BlurSelector.DisplayMember = "Text";
            BlurSelector.ValueMember = "Value";
        }

        private void Blur(object sender, EventArgs e)
        {
            if (InputImage.GetImage() != null)
            {
                Mat output = new();

                if (BlurSelector.Text == "Gaussian") CvInvoke.GaussianBlur(InputImage.GetImage(), output, new Size(SizeBar.GetValue(), SizeBar.GetValue()), 0);
                else if (BlurSelector.Text == "Median") CvInvoke.MedianBlur(InputImage.GetImage(), output, SizeBar.GetValue());

                OutputImage.SetImage(output);
            }
        }
    }
}
