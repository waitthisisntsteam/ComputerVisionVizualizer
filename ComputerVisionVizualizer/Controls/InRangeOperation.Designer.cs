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
            components = new System.ComponentModel.Container();
            InputPicture = new Emgu.CV.UI.ImageBox();
            Min1 = new Helpers.Slider();
            Min2 = new Helpers.Slider();
            Min3 = new Helpers.Slider();
            InputPictureSelector = new ComboBox();
            Max3 = new Helpers.Slider();
            Max2 = new Helpers.Slider();
            Max1 = new Helpers.Slider();
            OutputPicture = new Emgu.CV.UI.ImageBox();
            OutputPictureName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)InputPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputPicture).BeginInit();
            SuspendLayout();
            // 
            // InputPicture
            // 
            InputPicture.BorderStyle = BorderStyle.FixedSingle;
            InputPicture.Location = new Point(86, 46);
            InputPicture.Name = "InputPicture";
            InputPicture.Size = new Size(100, 100);
            InputPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            InputPicture.TabIndex = 2;
            InputPicture.TabStop = false;
            InputPicture.Click += InputPicture_Click;
            // 
            // Min1
            // 
            Min1.Location = new Point(40, 152);
            Min1.Name = "Min1";
            Min1.Size = new Size(200, 90);
            Min1.TabIndex = 3;
            // 
            // Min2
            // 
            Min2.Location = new Point(40, 222);
            Min2.Name = "Min2";
            Min2.Size = new Size(200, 90);
            Min2.TabIndex = 4;
            // 
            // Min3
            // 
            Min3.Location = new Point(40, 292);
            Min3.Name = "Min3";
            Min3.Size = new Size(200, 90);
            Min3.TabIndex = 5;
            // 
            // InputPictureSelector
            // 
            InputPictureSelector.FormattingEnabled = true;
            InputPictureSelector.Location = new Point(86, 17);
            InputPictureSelector.Name = "InputPictureSelector";
            InputPictureSelector.Size = new Size(100, 23);
            InputPictureSelector.TabIndex = 6;
            // 
            // Max3
            // 
            Max3.Location = new Point(330, 292);
            Max3.Name = "Max3";
            Max3.Size = new Size(200, 90);
            Max3.TabIndex = 10;
            // 
            // Max2
            // 
            Max2.Location = new Point(330, 222);
            Max2.Name = "Max2";
            Max2.Size = new Size(200, 90);
            Max2.TabIndex = 9;
            // 
            // Max1
            // 
            Max1.Location = new Point(330, 152);
            Max1.Name = "Max1";
            Max1.Size = new Size(200, 90);
            Max1.TabIndex = 8;
            // 
            // OutputPicture
            // 
            OutputPicture.BorderStyle = BorderStyle.FixedSingle;
            OutputPicture.Location = new Point(376, 46);
            OutputPicture.Name = "OutputPicture";
            OutputPicture.Size = new Size(100, 100);
            OutputPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPicture.TabIndex = 7;
            OutputPicture.TabStop = false;
            // 
            // OutputPictureName
            // 
            OutputPictureName.Location = new Point(376, 17);
            OutputPictureName.Name = "OutputPictureName";
            OutputPictureName.Size = new Size(100, 23);
            OutputPictureName.TabIndex = 11;
            OutputPictureName.TextChanged += OutputPictureName_TextChanged;
            // 
            // InRangeOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OutputPictureName);
            Controls.Add(Max3);
            Controls.Add(Max2);
            Controls.Add(Max1);
            Controls.Add(OutputPicture);
            Controls.Add(InputPictureSelector);
            Controls.Add(Min3);
            Controls.Add(Min2);
            Controls.Add(Min1);
            Controls.Add(InputPicture);
            Name = "InRangeOperation";
            Size = new Size(555, 380);
            ((System.ComponentModel.ISupportInitialize)InputPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InputPicture;
        private Helpers.Slider Min1;
        private Helpers.Slider Min2;
        private Helpers.Slider Min3;
        private ComboBox InputPictureSelector;
        private Helpers.Slider Max3;
        private Helpers.Slider Max2;
        private Helpers.Slider Max1;
        private Emgu.CV.UI.ImageBox OutputPicture;
        private TextBox OutputPictureName;
    }
}
