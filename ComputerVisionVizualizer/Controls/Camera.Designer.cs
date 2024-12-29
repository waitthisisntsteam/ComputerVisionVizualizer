namespace ComputerVisionVizualizer.Controls
{
    partial class Camera
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
            CameraBox = new Emgu.CV.UI.ImageBox();
            comboBox1 = new ComboBox();
            TakenPicture = new Helpers.OutputImage();
            TakePic = new Button();
            ((System.ComponentModel.ISupportInitialize)CameraBox).BeginInit();
            SuspendLayout();
            // 
            // CameraBox
            // 
            CameraBox.BorderStyle = BorderStyle.FixedSingle;
            CameraBox.Location = new Point(3, 32);
            CameraBox.Name = "CameraBox";
            CameraBox.Size = new Size(225, 164);
            CameraBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CameraBox.TabIndex = 2;
            CameraBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TakenPicture
            // 
            TakenPicture.Location = new Point(234, 59);
            TakenPicture.Name = "TakenPicture";
            TakenPicture.Size = new Size(106, 137);
            TakenPicture.TabIndex = 4;
            // 
            // TakePic
            // 
            TakePic.Location = new Point(234, 30);
            TakePic.Name = "TakePic";
            TakePic.Size = new Size(106, 23);
            TakePic.TabIndex = 5;
            TakePic.Text = "Take Picture";
            TakePic.UseVisualStyleBackColor = true;
            TakePic.Click += TakePic_Click;
            // 
            // Camera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(TakePic);
            Controls.Add(TakenPicture);
            Controls.Add(comboBox1);
            Controls.Add(CameraBox);
            Name = "Camera";
            Size = new Size(342, 204);
            ((System.ComponentModel.ISupportInitialize)CameraBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox CameraBox;
        private ComboBox comboBox1;
        private Helpers.OutputImage TakenPicture;
        private Button TakePic;
    }
}
