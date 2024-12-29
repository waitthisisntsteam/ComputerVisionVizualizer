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
        public EventHandler SliderChanged;

        public Slider()
        {
            InitializeComponent();
        }

        private void Increment_ValueChanged(object sender, EventArgs e)
        {
            Bar.Value = (int)Increment.Value;
            SliderChanged?.Invoke(this, e);
        }

        private void Bar_Scroll(object sender, EventArgs e)
        {
            Increment.Value = Bar.Value;
            SliderChanged?.Invoke(this, e);
        }

        public int GetValue() => Bar.Value;
        public void SetValue(int val)
        {
            Increment.Value = val;
            Bar.Value = val;
        }

        public void SetMin(int min)
        {
            Increment.Minimum = min;
            Bar.Minimum = min;
        }
        public void SetMax(int max)
        {
            Increment.Maximum = max;
            Bar.Maximum = max;
        }

        public void SetTickIncrement(int inc)
        {
            Increment.Increment = inc;
            Bar.TickFrequency = inc;
        }

        public void SetName(string name) => SliderName.Text = name;
    }
}
