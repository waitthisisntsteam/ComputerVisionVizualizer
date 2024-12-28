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
            new Item() { Text = "BGR", Value = 1 }
            ];

            ConvertFromSelector.DataSource = convertFrom;
            ConvertFromSelector.DisplayMember = "Text";
            ConvertFromSelector.ValueMember = "Value";

            List<Item> convertTo = [
            new Item() { Text = "HSV", Value = 0 },
            new Item() { Text = "Grayscale", Value = 0 }
            ];

            ConvertToSelector.DataSource = convertTo;
            ConvertToSelector.DisplayMember = "Text";
            ConvertToSelector.ValueMember = "Value";
        }

        private void Convert()
        {
            if (InputPicture.DisplayedImage != null)
            {
                Mat output = new();

                if (ConvertToSelector.Text == "HSV")
                {
                    if (ConvertFromSelector.Text == "RGB") CvInvoke.CvtColor(InputPicture.DisplayedImage, output, Emgu.CV.CvEnum.ColorConversion.Rgb2Hsv);
                    else if (ConvertFromSelector.Text == "BGR") CvInvoke.CvtColor(InputPicture.DisplayedImage, output, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                }
                else if (ConvertToSelector.Text == "Grayscale")
                {
                    if (ConvertFromSelector.Text == "RGB") CvInvoke.CvtColor(InputPicture.DisplayedImage, output, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);
                    else if (ConvertFromSelector.Text == "BGR") CvInvoke.CvtColor(InputPicture.DisplayedImage, output, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);
                }

                OutputPicture.DisplayedImage = output;
            }
        }

        private void InputPictureSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void InputPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes) InputPicture.Image = new Mat(fileDirectory.FileName);
            Convert();
        }

        private void ConvertFromSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void ConvertToSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void OutputPictureName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
