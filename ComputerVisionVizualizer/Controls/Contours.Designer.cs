namespace ComputerVisionVizualizer.Controls
{
    partial class Contours
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
            ThicknessBar = new Helpers.Slider();
            BBar = new Helpers.Slider();
            GBar = new Helpers.Slider();
            RBar = new Helpers.Slider();
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
            OutputImage.Location = new Point(223, 3);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 1;
            // 
            // ThicknessBar
            // 
            ThicknessBar.Location = new Point(74, 146);
            ThicknessBar.Name = "ThicknessBar";
            ThicknessBar.Size = new Size(200, 74);
            ThicknessBar.TabIndex = 2;
            // 
            // BBar
            // 
            BBar.Location = new Point(74, 215);
            BBar.Name = "BBar";
            BBar.Size = new Size(200, 74);
            BBar.TabIndex = 3;
            // 
            // GBar
            // 
            GBar.Location = new Point(74, 284);
            GBar.Name = "GBar";
            GBar.Size = new Size(200, 74);
            GBar.TabIndex = 4;
            // 
            // RBar
            // 
            RBar.Location = new Point(74, 352);
            RBar.Name = "RBar";
            RBar.Size = new Size(200, 74);
            RBar.TabIndex = 5;
            // 
            // Contours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(RBar);
            Controls.Add(GBar);
            Controls.Add(BBar);
            Controls.Add(ThicknessBar);
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Name = "Contours";
            Size = new Size(330, 422);
            ResumeLayout(false);
        }

        #endregion

        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
        private Helpers.Slider ThicknessBar;
        private Helpers.Slider BBar;
        private Helpers.Slider GBar;
        private Helpers.Slider RBar;
    }
}
