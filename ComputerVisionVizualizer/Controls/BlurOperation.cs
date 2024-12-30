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
            SizeBar.SetMin(1);
            SizeBar.SetMax(50);
            SizeBar.SetTickIncrement(1);

            SigmaBar.SliderChanged += Blur;
            SigmaBar.SetName("Sigma:");
            SigmaBar.SetMin(0);
            SigmaBar.SetMax(50);

            InputImage.ImageSubmitted += Blur;

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
            int size = SizeBar.GetValue();
            int sigma = SigmaBar.GetValue();

            if (InputImage.GetImage() != null && size % 2 == 1)
            {
                using Mat output = new();

                if (BlurSelector.Text == "Gaussian") CvInvoke.GaussianBlur(InputImage.GetImage(), output, new Size(size, size), sigma);
                else if (BlurSelector.Text == "Median") CvInvoke.MedianBlur(InputImage.GetImage(), output, size);

                OutputImage.SetImage(output);
            }
        }
    }
}
