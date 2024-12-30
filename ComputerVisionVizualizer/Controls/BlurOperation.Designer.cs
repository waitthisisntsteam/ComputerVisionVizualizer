﻿namespace ComputerVisionVizualizer.Controls
{
    partial class BlurOperation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputImage = new Helpers.InputImage();
            OutputImage = new Helpers.OutputImage();
            BlurSelector = new ComboBox();
            SizeBar = new Helpers.Slider();
            SigmaBar = new Helpers.Slider();
            SuspendLayout();
            // 
            // InputImage
            // 
            InputImage.Location = new Point(3, 3);
            InputImage.Name = "InputImage";
            InputImage.Size = new Size(106, 137);
            InputImage.TabIndex = 0;
            // 
            // OutputImage
            // 
            OutputImage.Location = new Point(215, 3);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 1;
            // 
            // BlurSelector
            // 
            BlurSelector.FormattingEnabled = true;
            BlurSelector.Location = new Point(115, 72);
            BlurSelector.Name = "BlurSelector";
            BlurSelector.Size = new Size(94, 23);
            BlurSelector.TabIndex = 2;
            // 
            // SizeBar
            // 
            SizeBar.Location = new Point(76, 143);
            SizeBar.Name = "SizeBar";
            SizeBar.Size = new Size(200, 74);
            SizeBar.TabIndex = 3;
            // 
            // SigmaBar
            // 
            SigmaBar.Location = new Point(76, 223);
            SigmaBar.Name = "SigmaBar";
            SigmaBar.Size = new Size(200, 74);
            SigmaBar.TabIndex = 4;
            // 
            // BlurOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(SigmaBar);
            Controls.Add(SizeBar);
            Controls.Add(BlurSelector);
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Name = "BlurOperation";
            Size = new Size(324, 301);
            ResumeLayout(false);
        }

        #endregion

        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
        private ComboBox BlurSelector;
        private Helpers.Slider SizeBar;
        private Helpers.Slider SigmaBar;
    }
}
