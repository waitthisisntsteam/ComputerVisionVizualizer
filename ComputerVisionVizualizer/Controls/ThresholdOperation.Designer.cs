namespace ComputerVisionVizualizer.Controls
{
    partial class ThresholdOperation
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
            MaxValueBar = new Helpers.Slider();
            ThresholdBar = new Helpers.Slider();
            OptionSelector = new ComboBox();
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
            OutputImage.Location = new Point(242, 3);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 1;
            // 
            // MaxValueBar
            // 
            MaxValueBar.Location = new Point(77, 210);
            MaxValueBar.Name = "MaxValueBar";
            MaxValueBar.Size = new Size(200, 74);
            MaxValueBar.TabIndex = 2;
            // 
            // ThresholdBar
            // 
            ThresholdBar.Location = new Point(77, 146);
            ThresholdBar.Name = "ThresholdBar";
            ThresholdBar.Size = new Size(200, 74);
            ThresholdBar.TabIndex = 3;
            // 
            // OptionSelector
            // 
            OptionSelector.FormattingEnabled = true;
            OptionSelector.Location = new Point(115, 74);
            OptionSelector.Name = "OptionSelector";
            OptionSelector.Size = new Size(121, 23);
            OptionSelector.TabIndex = 4;
            // 
            // ThresholdOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OptionSelector);
            Controls.Add(ThresholdBar);
            Controls.Add(MaxValueBar);
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Name = "ThresholdOperation";
            Size = new Size(350, 281);
            ResumeLayout(false);
        }

        #endregion

        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
        private Helpers.Slider MaxValueBar;
        private Helpers.Slider ThresholdBar;
        private ComboBox OptionSelector;
    }
}
