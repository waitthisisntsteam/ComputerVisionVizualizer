using ComputerVisionVizualizer.Controls.Helpers;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ComputerVisionVizualizer.Controls
{
    public partial class Contours : CVIOBase
    {
        public Contours()
        {
            InitializeComponent();

            ThicknessBar.SetName("Thickness:");
            ThicknessBar.SetMin(0);
            ThicknessBar.SetMax(20);
            ThicknessBar.SliderChanged += DrawContours;

            BBar.SetName("B:");
            BBar.SliderChanged += DrawContours;

            GBar.SetName("G:");
            GBar.SliderChanged += DrawContours;

            RBar.SetName("R:");
            RBar.SliderChanged += DrawContours;

            InputImage.ImageSubmitted += DrawContours;
        }

        private void DrawContours(object sender, EventArgs e)
        {
            if (InputImage.GetImage() != null)
            {
                using Mat inputToGrayscale = new();

                CvInvoke.CvtColor(InputImage.GetImage(), inputToGrayscale, ColorConversion.Bgr2Gray);

                using Mat heirarchy = new();
                using VectorOfVectorOfPoint contours = new();
                CvInvoke.FindContours(inputToGrayscale, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

                using IInputOutputArray output = (InputImage.GetImage() as Mat).Clone();
                CvInvoke.DrawContours(output, contours, -1, new Emgu.CV.Structure.MCvScalar(BBar.GetValue(), GBar.GetValue(), RBar.GetValue()), ThicknessBar.GetValue());

                OutputImage.SetImage(output);
            }
        }
    }
}
