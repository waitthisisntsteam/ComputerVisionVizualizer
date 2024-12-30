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
            ConvertFromSelector = new ComboBox();
            Transformation = new Label();
            ConvertToSelector = new ComboBox();
            InputImage = new Helpers.InputImage();
            OutputImage = new Helpers.OutputImage();
            SuspendLayout();
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
            // InputImage
            // 
            InputImage.Location = new Point(4, 8);
            InputImage.Name = "InputImage";
            InputImage.Size = new Size(106, 137);
            InputImage.TabIndex = 9;
            // 
            // OutputImage
            // 
            OutputImage.Location = new Point(189, 8);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 10;
            // 
            // ConvertColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Controls.Add(ConvertToSelector);
            Controls.Add(Transformation);
            Controls.Add(ConvertFromSelector);
            Name = "ConvertColor";
            Size = new Size(298, 148);
            Load += ConvertColor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox ConvertFromSelector;
        private Label Transformation;
        private ComboBox ConvertToSelector;
        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
    }
}
