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
    public partial class InputImage : UserControl
    {
        public InputImage()
        {
            InitializeComponent();
        }

        public IInputArray GetImage() => InputPictureBox.DisplayedImage;

        private void InputPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes) InputPictureBox.DisplayedImage = new Mat(fileDirectory.FileName);
        }

        private void InputPictureSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
