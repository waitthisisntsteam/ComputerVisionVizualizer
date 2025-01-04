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

namespace ComputerVisionVizualizer.Controls.Helpers
{
    public partial class OutputImage : ImageBase
    {
        public OutputImage()
        {
            InitializeComponent();
        }

        public void SetImage(IInputArray image) => OutputPictureBox.DisplayedImage = (image as Mat).Clone();

        private void OutputPictureName_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputPictureName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SavedImages.Add(OutputPictureName.Text, (OutputPictureBox.DisplayedImage as Mat).Clone());
                ImageSaved?.Invoke(sender, e);
            }
        }
    }
}
