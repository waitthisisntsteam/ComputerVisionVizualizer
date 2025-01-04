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
    public partial class ImageBase : UserControl
    {
        public static Dictionary<string, Mat> SavedImages;

        public static EventHandler ImageSaved;

        public ImageBase()
        {
            InitializeComponent();

            SavedImages = new();
            ImageSaved += AddSavedImage;
        }

        public void AddSavedImage(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;

            ;
        }
    }
}
