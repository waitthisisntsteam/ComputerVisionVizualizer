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
    public partial class InRangeOperation : CVIOBase
    {
        public InRangeOperation()
        {
            InitializeComponent();

            Min1.SetName("Min B:");
            Min2.SetName("Min G:");
            Min3.SetName("Min R:");

            Max1.SetName("Max H:");
            Max2.SetName("Max S:");
            Max3.SetName("Max V:");


            Min1.SliderChanged += Convert;
            Min2.SliderChanged += Convert;
            Min3.SliderChanged += Convert;

            Max1.SliderChanged += Convert;
            Max2.SliderChanged += Convert;
            Max3.SliderChanged += Convert;

            InputImage.ImageSubmitted += Convert;
        }

        //private void Input(object sender, EventArgs e)
        //{
        //    var result = loadMatDIalong.ShowDIalog();
        //    if (result == DialogResult.OK)
        //    {
        //        mat?.Dispose();
        //        inputSlelectionBox.SelectedItem = null;

        //        mat = CvInvoke.Imread();

        //    }
        //}

        private void Convert(object sender, EventArgs e)
        {
            if (InputImage.GetImage() != null)
            {
                using Mat output = new();

                CvInvoke.InRange(InputImage.GetImage(),
                                 new ScalarArray(new Emgu.CV.Structure.MCvScalar(Min1.GetValue(),
                                                                                 Min2.GetValue(),
                                                                                 Min3.GetValue())),
                                 new ScalarArray(new Emgu.CV.Structure.MCvScalar(Max1.GetValue(),
                                                                                 Max2.GetValue(),
                                                                                 Max3.GetValue())),
                                 output);

                OutputImage.SetImage(output);
            }
        }
    }
}
