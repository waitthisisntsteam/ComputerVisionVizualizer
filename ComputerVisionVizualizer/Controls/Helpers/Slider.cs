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
    public partial class Slider : UserControl
    {
        public Slider()
        {
            InitializeComponent();
        }

        private void Increment_ValueChanged(object sender, EventArgs e)
        {
            Bar.Value = (int)Increment.Value;
        }

        private void Bar_Scroll(object sender, EventArgs e)
        {
            Increment.Value = Bar.Value;
        }
    }
}
