namespace ComputerVisionVizualizer.Controls.Helpers
{
    partial class OutputImage
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
            OutputPictureBox = new Emgu.CV.UI.ImageBox();
            OutputPictureName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OutputPictureBox).BeginInit();
            SuspendLayout();
            // 
            // OutputPictureBox
            // 
            OutputPictureBox.BorderStyle = BorderStyle.FixedSingle;
            OutputPictureBox.Location = new Point(3, 32);
            OutputPictureBox.Name = "OutputPictureBox";
            OutputPictureBox.Size = new Size(100, 100);
            OutputPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPictureBox.TabIndex = 2;
            OutputPictureBox.TabStop = false;
            // 
            // OutputPictureName
            // 
            OutputPictureName.Location = new Point(3, 3);
            OutputPictureName.Name = "OutputPictureName";
            OutputPictureName.Size = new Size(100, 23);
            OutputPictureName.TabIndex = 3;
            OutputPictureName.TextChanged += OutputPictureName_TextChanged;
            OutputPictureName.KeyPress += OutputPictureName_KeyPress;
            // 
            // OutputImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OutputPictureName);
            Controls.Add(OutputPictureBox);
            Name = "OutputImage";
            Size = new Size(106, 137);
            ((System.ComponentModel.ISupportInitialize)OutputPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox OutputPictureBox;
        private TextBox OutputPictureName;
    }
}
