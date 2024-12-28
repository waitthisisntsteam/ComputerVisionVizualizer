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

        private void InputPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes) InputPicture.Image = new Mat(fileDirectory.FileName);
        }

        private void OutputPictureName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
