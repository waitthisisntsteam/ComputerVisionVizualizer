namespace ComputerVisionVizualizer.Controls
{
    partial class ConvertColor
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
            OutputPicture = new Emgu.CV.UI.ImageBox();
            ConvertFromSelector = new ComboBox();
            Transformation = new Label();
            ConvertToSelector = new ComboBox();
            InputPictureSelector = new ComboBox();
            OutputPictureName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)InputPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputPicture).BeginInit();
            SuspendLayout();
            // 
            // InputPicture
            // 
            InputPicture.BorderStyle = BorderStyle.FixedSingle;
            InputPicture.Location = new Point(10, 40);
            InputPicture.Name = "InputPicture";
            InputPicture.Size = new Size(100, 100);
            InputPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            InputPicture.TabIndex = 2;
            InputPicture.TabStop = false;
            InputPicture.Click += InputPicture_Click;
            // 
            // OutputPicture
            // 
            OutputPicture.BorderStyle = BorderStyle.FixedSingle;
            OutputPicture.Location = new Point(190, 40);
            OutputPicture.Name = "OutputPicture";
            OutputPicture.Size = new Size(100, 100);
            OutputPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPicture.TabIndex = 3;
            OutputPicture.TabStop = false;
            // 
            // ConvertFromSelector
            // 
            ConvertFromSelector.FormattingEnabled = true;
            ConvertFromSelector.Location = new Point(116, 60);
            ConvertFromSelector.Name = "ConvertFromSelector";
            ConvertFromSelector.Size = new Size(68, 23);
            ConvertFromSelector.TabIndex = 4;
            ConvertFromSelector.SelectedIndexChanged += ConvertFromSelector_SelectedIndexChanged;
            // 
            // Transformation
            // 
            Transformation.AutoSize = true;
            Transformation.Location = new Point(139, 86);
            Transformation.Name = "Transformation";
            Transformation.Size = new Size(18, 15);
            Transformation.TabIndex = 5;
            Transformation.Text = "to";
            // 
            // ConvertToSelector
            // 
            ConvertToSelector.FormattingEnabled = true;
            ConvertToSelector.Location = new Point(116, 104);
            ConvertToSelector.Name = "ConvertToSelector";
            ConvertToSelector.Size = new Size(68, 23);
            ConvertToSelector.TabIndex = 6;
            ConvertToSelector.SelectedIndexChanged += ConvertToSelector_SelectedIndexChanged;
            // 
            // InputPictureSelector
            // 
            InputPictureSelector.FormattingEnabled = true;
            InputPictureSelector.Location = new Point(10, 11);
            InputPictureSelector.Name = "InputPictureSelector";
            InputPictureSelector.Size = new Size(100, 23);
            InputPictureSelector.TabIndex = 7;
            InputPictureSelector.SelectedIndexChanged += InputPictureSelector_SelectedIndexChanged;
            // 
            // OutputPictureName
            // 
            OutputPictureName.Location = new Point(190, 11);
            OutputPictureName.Name = "OutputPictureName";
            OutputPictureName.Size = new Size(100, 23);
            OutputPictureName.TabIndex = 8;
            OutputPictureName.TextChanged += OutputPictureName_TextChanged;
            // 
            // ConvertColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(OutputPictureName);
            Controls.Add(InputPictureSelector);
            Controls.Add(ConvertToSelector);
            Controls.Add(Transformation);
            Controls.Add(ConvertFromSelector);
            Controls.Add(OutputPicture);
            Controls.Add(InputPicture);
            Name = "ConvertColor";
            Size = new Size(298, 148);
            Load += ConvertColor_Load;
            ((System.ComponentModel.ISupportInitialize)InputPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InputPicture;
        private Emgu.CV.UI.ImageBox OutputPicture;
        private ComboBox ConvertFromSelector;
        private Label Transformation;
        private ComboBox ConvertToSelector;
        private ComboBox InputPictureSelector;
        private TextBox OutputPictureName;
    }
}
