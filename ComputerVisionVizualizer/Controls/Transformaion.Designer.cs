namespace ComputerVisionVizualizer.Controls
{
    partial class Transformaion
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
            FactorLabel = new Label();
            FactorText = new TextBox();
            SavePictureButton = new Button();
            RotateButton = new Button();
            ImportPictureButton = new Button();
            updatedPicture = new Emgu.CV.UI.ImageBox();
            originalPicture = new Emgu.CV.UI.ImageBox();
            ResizeBar = new TrackBar();
            ResizeLabel = new Label();
            ROIButton = new Button();
            ((System.ComponentModel.ISupportInitialize)updatedPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResizeBar).BeginInit();
            SuspendLayout();
            // 
            // FactorLabel
            // 
            FactorLabel.AutoSize = true;
            FactorLabel.Location = new Point(330, 288);
            FactorLabel.Name = "FactorLabel";
            FactorLabel.Size = new Size(40, 15);
            FactorLabel.TabIndex = 17;
            FactorLabel.Text = "Factor";
            // 
            // FactorText
            // 
            FactorText.Location = new Point(300, 306);
            FactorText.Name = "FactorText";
            FactorText.Size = new Size(100, 23);
            FactorText.TabIndex = 16;
            // 
            // SavePictureButton
            // 
            SavePictureButton.Location = new Point(475, 302);
            SavePictureButton.Name = "SavePictureButton";
            SavePictureButton.Size = new Size(100, 23);
            SavePictureButton.TabIndex = 14;
            SavePictureButton.Text = "Save Picture";
            SavePictureButton.UseVisualStyleBackColor = true;
            SavePictureButton.Click += SavePictureButton_Click;
            // 
            // RotateButton
            // 
            RotateButton.Location = new Point(218, 342);
            RotateButton.Name = "RotateButton";
            RotateButton.Size = new Size(75, 23);
            RotateButton.TabIndex = 13;
            RotateButton.Text = "Rotate";
            RotateButton.UseVisualStyleBackColor = true;
            RotateButton.Click += RotateButton_Click;
            // 
            // ImportPictureButton
            // 
            ImportPictureButton.Location = new Point(125, 302);
            ImportPictureButton.Name = "ImportPictureButton";
            ImportPictureButton.Size = new Size(102, 23);
            ImportPictureButton.TabIndex = 12;
            ImportPictureButton.Text = "Import Picture";
            ImportPictureButton.UseVisualStyleBackColor = true;
            ImportPictureButton.Click += ImportPictureButton_Click;
            // 
            // updatedPicture
            // 
            updatedPicture.BorderStyle = BorderStyle.FixedSingle;
            updatedPicture.Location = new Point(394, 46);
            updatedPicture.Name = "updatedPicture";
            updatedPicture.Size = new Size(250, 250);
            updatedPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            updatedPicture.TabIndex = 11;
            updatedPicture.TabStop = false;
            // 
            // originalPicture
            // 
            originalPicture.BorderStyle = BorderStyle.FixedSingle;
            originalPicture.Location = new Point(55, 46);
            originalPicture.Name = "originalPicture";
            originalPicture.Size = new Size(250, 250);
            originalPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            originalPicture.TabIndex = 10;
            originalPicture.TabStop = false;
            // 
            // ResizeBar
            // 
            ResizeBar.Location = new Point(394, 364);
            ResizeBar.Name = "ResizeBar";
            ResizeBar.Size = new Size(104, 45);
            ResizeBar.TabIndex = 18;
            ResizeBar.Scroll += ResizeBar_Scroll;
            // 
            // ResizeLabel
            // 
            ResizeLabel.AutoSize = true;
            ResizeLabel.Location = new Point(427, 346);
            ResizeLabel.Name = "ResizeLabel";
            ResizeLabel.Size = new Size(39, 15);
            ResizeLabel.TabIndex = 19;
            ResizeLabel.Text = "Resize";
            // 
            // ROIButton
            // 
            ROIButton.Location = new Point(218, 371);
            ROIButton.Name = "ROIButton";
            ROIButton.Size = new Size(75, 23);
            ROIButton.TabIndex = 20;
            ROIButton.Text = "ROI";
            ROIButton.UseVisualStyleBackColor = true;
            ROIButton.Click += ROIButton_Click;
            // 
            // Transformaion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ROIButton);
            Controls.Add(ResizeLabel);
            Controls.Add(ResizeBar);
            Controls.Add(FactorLabel);
            Controls.Add(FactorText);
            Controls.Add(SavePictureButton);
            Controls.Add(RotateButton);
            Controls.Add(ImportPictureButton);
            Controls.Add(updatedPicture);
            Controls.Add(originalPicture);
            Name = "Transformaion";
            Size = new Size(690, 430);
            Load += Transformaion_Load;
            ((System.ComponentModel.ISupportInitialize)updatedPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResizeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FactorLabel;
        private TextBox FactorText;
        private Button SavePictureButton;
        private Button RotateButton;
        private Button ImportPictureButton;
        private Emgu.CV.UI.ImageBox updatedPicture;
        private Emgu.CV.UI.ImageBox originalPicture;
        private TrackBar ResizeBar;
        private Label ResizeLabel;
        private Button ROIButton;
    }
}
