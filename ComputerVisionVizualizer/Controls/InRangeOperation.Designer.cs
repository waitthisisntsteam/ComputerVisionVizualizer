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
            ConvertToSelector = new ComboBox();
            Transformation = new Label();
            ConvertFromSelector = new ComboBox();
            InputImage = new Helpers.InputImage();
            OutputImage = new Helpers.OutputImage();
            SuspendLayout();
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
            // ConvertToSelector
            // 
            ConvertToSelector.FormattingEnabled = true;
            ConvertToSelector.Location = new Point(245, 108);
            ConvertToSelector.Name = "ConvertToSelector";
            ConvertToSelector.Size = new Size(68, 23);
            ConvertToSelector.TabIndex = 14;
            // 
            // Transformation
            // 
            Transformation.AutoSize = true;
            Transformation.Location = new Point(268, 90);
            Transformation.Name = "Transformation";
            Transformation.Size = new Size(18, 15);
            Transformation.TabIndex = 13;
            Transformation.Text = "to";
            // 
            // ConvertFromSelector
            // 
            ConvertFromSelector.FormattingEnabled = true;
            ConvertFromSelector.Location = new Point(245, 64);
            ConvertFromSelector.Name = "ConvertFromSelector";
            ConvertFromSelector.Size = new Size(68, 23);
            ConvertFromSelector.TabIndex = 12;
            // 
            // InputImage
            // 
            InputImage.Location = new Point(79, 17);
            InputImage.Name = "InputImage";
            InputImage.Size = new Size(106, 137);
            InputImage.TabIndex = 15;
            // 
            // OutputImage
            // 
            OutputImage.Location = new Point(370, 17);
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
            Controls.Add(ConvertToSelector);
            Controls.Add(Transformation);
            Controls.Add(ConvertFromSelector);
            Controls.Add(Max3);
            Controls.Add(Max2);
            Controls.Add(Max1);
            Controls.Add(Min3);
            Controls.Add(Min2);
            Controls.Add(Min1);
            Name = "InRangeOperation";
            Size = new Size(553, 378);
            Load += InRangeOperation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Helpers.Slider Min1;
        private Helpers.Slider Min2;
        private Helpers.Slider Min3;
        private Helpers.Slider Max3;
        private Helpers.Slider Max2;
        private Helpers.Slider Max1;
        private ComboBox ConvertToSelector;
        private Label Transformation;
        private ComboBox ConvertFromSelector;
        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
    }
}
