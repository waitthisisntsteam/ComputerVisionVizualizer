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
    public partial class OutputImage : UserControl
    {
        public EventHandler NameChanged;

        public OutputImage()
        {
            InitializeComponent();
        }

        public void SetImage(IInputArray image) => OutputPictureBox.DisplayedImage = image;

        private void OutputPictureName_TextChanged(object sender, EventArgs e)
        {
            NameChanged?.Invoke(this, e);
        }
    }
}
