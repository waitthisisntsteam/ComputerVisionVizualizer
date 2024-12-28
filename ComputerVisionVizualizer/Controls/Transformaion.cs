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

    public partial class Transformaion : CVIOBase
    {
        public Transformaion()
        {
            InitializeComponent();
        }

        Mat? OriginalMat;

        private void Transformaion_Load(object sender, EventArgs e)
        {
            OriginalMat = originalPicture.Image as Mat;
        }

        private void ImportPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes) originalPicture.Image = new Mat(fileDirectory.FileName);

            OriginalMat = originalPicture.Image as Mat;
            updatedPicture.Image = OriginalMat;
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            Mat output = new();
            CvInvoke.Rotate(OriginalMat, output, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);

            updatedPicture.Image = output;
        }

        private void SavePictureButton_Click(object sender, EventArgs e)
        {
            OriginalMat = updatedPicture.Image as Mat;
            originalPicture.Image = OriginalMat;
        }

        private void ResizeBar_Scroll(object sender, EventArgs e)
        {
            if (OriginalMat != null)
            {
                Mat output = new();
                if (ResizeBar.Value > 0) CvInvoke.Resize(OriginalMat, output, new Size(OriginalMat.Width * ResizeBar.Value, OriginalMat.Height * ResizeBar.Value));
                else output = OriginalMat;

                updatedPicture.Image = output;
            }
        }

        private void ROIButton_Click(object sender, EventArgs e)
        {
            if (OriginalMat != null)
            {
                Mat selectedRegion = new();
                CvInvoke.Resize(OriginalMat, selectedRegion, new Size(OriginalMat.Width / 2, OriginalMat.Height / 2));

                Mat copiedRegion = new(OriginalMat, new Rectangle(0, 0, selectedRegion.Width, selectedRegion.Height));
                selectedRegion.CopyTo(copiedRegion);

                updatedPicture.Image = selectedRegion;
            }
        }
    }
}
