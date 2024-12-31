namespace ComputerVisionVizualizer.Controls
{
    partial class InRangeOperation
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
            Min1 = new Helpers.Slider();
            Min2 = new Helpers.Slider();
            Min3 = new Helpers.Slider();
            Max3 = new Helpers.Slider();
            Max2 = new Helpers.Slider();
            Max1 = new Helpers.Slider();
            InputImage = new Helpers.InputImage();
            OutputImage = new Helpers.OutputImage();
            SuspendLayout();
            // 
            // Min1
            // 
            Min1.Location = new Point(32, 137);
            Min1.Name = "Min1";
            Min1.Size = new Size(200, 90);
            Min1.TabIndex = 3;
            // 
            // Min2
            // 
            Min2.Location = new Point(32, 207);
            Min2.Name = "Min2";
            Min2.Size = new Size(200, 90);
            Min2.TabIndex = 4;
            // 
            // Min3
            // 
            Min3.Location = new Point(32, 277);
            Min3.Name = "Min3";
            Min3.Size = new Size(200, 90);
            Min3.TabIndex = 5;
            // 
            // Max3
            // 
            Max3.Location = new Point(322, 277);
            Max3.Name = "Max3";
            Max3.Size = new Size(200, 90);
            Max3.TabIndex = 10;
            // 
            // Max2
            // 
            Max2.Location = new Point(322, 207);
            Max2.Name = "Max2";
            Max2.Size = new Size(200, 90);
            Max2.TabIndex = 9;
            // 
            // Max1
            // 
            Max1.Location = new Point(322, 137);
            Max1.Name = "Max1";
            Max1.Size = new Size(200, 90);
            Max1.TabIndex = 8;
            // 
            // InputImage
            // 
            InputImage.Location = new Point(71, 2);
            InputImage.Name = "InputImage";
            InputImage.Size = new Size(106, 137);
            InputImage.TabIndex = 15;
            // 
            // OutputImage
            // 
            OutputImage.Location = new Point(362, 2);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 16;
            // 
            // InRangeOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Controls.Add(Max3);
            Controls.Add(Max2);
            Controls.Add(Max1);
            Controls.Add(Min3);
            Controls.Add(Min2);
            Controls.Add(Min1);
            Name = "InRangeOperation";
            Size = new Size(553, 348);
            ResumeLayout(false);
        }

        #endregion
        private Helpers.Slider Min1;
        private Helpers.Slider Min2;
        private Helpers.Slider Min3;
        private Helpers.Slider Max3;
        private Helpers.Slider Max2;
        private Helpers.Slider Max1;
        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
    }
}
