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
    public partial class ConvertColor : CVIOBase
    {
        public ConvertColor()
        {
            InitializeComponent();
        }

        private void ConvertColor_Load(object sender, EventArgs e)
        {
            List<Item> convertFrom = [
            new Item() { Text = "RGB", Value = 0 },
            new Item() { Text = "BGR", Value = 1 },
            new Item() { Text = "HSV", Value = 2 },
            new Item() { Text = "Grayscale", Value = 3 }
            ];

            ConvertFromSelector.DataSource = convertFrom;
            ConvertFromSelector.DisplayMember = "Text";
            ConvertFromSelector.ValueMember = "Value";

            List<Item> convertTo = [
            new Item() { Text = "RGB", Value = 0 },
            new Item() { Text = "BGR", Value = 1 },
            new Item() { Text = "HSV", Value = 2 },
            new Item() { Text = "Grayscale", Value = 3 }
            ];

            ConvertToSelector.DataSource = convertTo;
            ConvertToSelector.DisplayMember = "Text";
            ConvertToSelector.ValueMember = "Value";

            InputImage.ImageSubmitted += Convert;
        }

        private void Convert(object sender, EventArgs e)
        {
            if (InputImage.GetImage() != null)
            {
                using Mat output = new();

                if (ConvertToSelector.Text == "HSV")
                {
                    if (ConvertFromSelector.Text == "RGB") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Rgb2Hsv);
                    else if (ConvertFromSelector.Text == "BGR") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                }
                else if (ConvertToSelector.Text == "Grayscale")
                {
                    if (ConvertFromSelector.Text == "RGB") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);
                    else if (ConvertFromSelector.Text == "BGR") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                }
                else if (ConvertToSelector.Text == "RGB")
                {
                    if (ConvertFromSelector.Text == "HSV") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Hsv2Rgb);
                    else if (ConvertFromSelector.Text == "Grayscale") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Gray2Rgb);
                }
                else if (ConvertToSelector.Text == "BGR")
                {
                    if (ConvertFromSelector.Text == "HSV") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
                    else if (ConvertFromSelector.Text == "Grayscale") CvInvoke.CvtColor(InputImage.GetImage(), output, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
                }

                OutputImage.SetImage(output);
            }
        }

        private void ConvertFromSelector_SelectedIndexChanged(object sender, EventArgs e) => Convert(sender, e);

        private void ConvertToSelector_SelectedIndexChanged(object sender, EventArgs e) => Convert(sender, e);
    }
}
