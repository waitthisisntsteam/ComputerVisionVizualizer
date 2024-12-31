using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ComputerVisionVizualizer.Controls
{
    public partial class DilationErosion : CVIOBase
    {
        public DilationErosion()
        {
            InitializeComponent();

            SizeBar.SliderChanged += Adjust;
            SizeBar.SetName("Size:");
            SizeBar.SetValue(0);
            SizeBar.SetMin(0);
            SizeBar.SetMax(10);

            InputImage.ImageSubmitted += Adjust;

            List<Item> options = [
            new Item() { Text = "Dilation", Value = 0 },
            new Item() { Text = "Erosion", Value = 1 }
            ];

            OptionSelector.DataSource = options;
            OptionSelector.DisplayMember = "Text";
            OptionSelector.ValueMember = "Value";
        }

        private void Adjust(object sender, EventArgs e)
        {
            int size = SizeBar.GetValue();

            if (InputImage.GetImage() != null)
            {
                using Mat output = new();
                using Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

                if (OptionSelector.Text == "Dilation") CvInvoke.Dilate(InputImage.GetImage(), output, element, new Point(-1, -1), SizeBar.GetValue(), Emgu.CV.CvEnum.BorderType.Constant, new Emgu.CV.Structure.MCvScalar(0, 0, 0));
                else if (OptionSelector.Text == "Erosion") CvInvoke.Erode(InputImage.GetImage(), output, element, new Point(-1, -1), SizeBar.GetValue(), Emgu.CV.CvEnum.BorderType.Constant, new Emgu.CV.Structure.MCvScalar(0, 0, 0));

                OutputImage.SetImage(output);
            }
        }
    }
}
