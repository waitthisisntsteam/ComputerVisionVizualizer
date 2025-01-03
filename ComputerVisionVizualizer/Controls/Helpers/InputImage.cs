﻿using Emgu.CV;
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
    public partial class InputImage : ImageBase
    {
        public EventHandler ImageSubmitted;

        public InputImage()
        {
            InitializeComponent();

            InputPictureSelector.DataSource = SavedImages.Keys.ToList();
            InputPictureSelector.DisplayMember = SavedImages.Keys.ToString();
            //InputPictureSelector.ValueMember = SavedImages.Values.ToString();
        }

        public IInputArray GetImage() => InputPictureBox.DisplayedImage;

        private void InputPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes)
            {
                InputPictureBox.DisplayedImage = new Mat(fileDirectory.FileName);
                ImageSubmitted?.Invoke(this, e);
            }
        }

        private void InputPictureSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }
    }
}
