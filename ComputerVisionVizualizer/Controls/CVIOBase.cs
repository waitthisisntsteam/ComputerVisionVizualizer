using Emgu.CV;
using Emgu.CV.Stitching;
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
    public partial class CVIOBase : UserControl
    {
        //public CvControlDisplayNameAttribute;

        private static Dictionary<string, Mat> SavedImages;

        //public CVIOControlPropertyChangedEventArgs(string propertyName, T oldValue, T newValue)

        public CVIOBase()
        {
            InitializeComponent();

            SavedImages = new();
        }

        private void CVIOBase_Load(object sender, EventArgs e)
        {

        }
    }
}
