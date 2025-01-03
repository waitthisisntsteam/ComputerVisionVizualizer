﻿using Emgu.CV;
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
        public CVIOBase()
        {
            InitializeComponent();
        }

        private void CVIOBase_Load(object sender, EventArgs e)
        {

        }

        public class CvControlDisplayNameAttribute : Attribute
        {
            public string Name { get; }
            public CvControlDisplayNameAttribute(string name) { Name = name; }
        }
    }
}
