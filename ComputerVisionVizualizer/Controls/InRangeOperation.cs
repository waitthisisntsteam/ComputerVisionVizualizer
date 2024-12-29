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

        private void Convert()
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

        private void InRangeOperation_Load(object sender, EventArgs e)
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

            Min1.SetName("Min R:");
            Min2.SetName("Min G:");
            Min3.SetName("Min B:");

            Max1.SetName("Max R:");
            Max2.SetName("Max G:");
            Max3.SetName("Max B:");


            Min1.SliderChanged += ValueChanged;
            Min2.SliderChanged += ValueChanged;
            Min3.SliderChanged += ValueChanged;

            Max1.SliderChanged += ValueChanged;
            Max2.SliderChanged += ValueChanged;
            Max3.SliderChanged += ValueChanged;
        }

        private void ValueChanged(object sender, EventArgs e) => Convert();
    }
}
