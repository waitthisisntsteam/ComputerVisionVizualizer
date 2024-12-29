namespace ComputerVisionVizualizer.Controls.Helpers
{
    partial class InputImage
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
            InputPictureBox = new Emgu.CV.UI.ImageBox();
            InputPictureSelector = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)InputPictureBox).BeginInit();
            SuspendLayout();
            // 
            // InputPictureBox
            // 
            InputPictureBox.BorderStyle = BorderStyle.FixedSingle;
            InputPictureBox.Location = new Point(3, 32);
            InputPictureBox.Name = "InputPictureBox";
            InputPictureBox.Size = new Size(100, 100);
            InputPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            InputPictureBox.TabIndex = 2;
            InputPictureBox.TabStop = false;
            InputPictureBox.Click += InputPictureBox_Click;
            // 
            // InputPictureSelector
            // 
            InputPictureSelector.FormattingEnabled = true;
            InputPictureSelector.Location = new Point(3, 3);
            InputPictureSelector.Name = "InputPictureSelector";
            InputPictureSelector.Size = new Size(100, 23);
            InputPictureSelector.TabIndex = 3;
            InputPictureSelector.SelectedIndexChanged += InputPictureSelector_SelectedIndexChanged;
            // 
            // InputImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InputPictureSelector);
            Controls.Add(InputPictureBox);
            Name = "InputImage";
            Size = new Size(106, 137);
            ((System.ComponentModel.ISupportInitialize)InputPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox InputPictureBox;
        private ComboBox InputPictureSelector;
    }
}
