namespace ComputerVisionVizualizer.Controls
{
    partial class DilationErosion
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
            OptionSelector = new ComboBox();
            SizeBar = new Helpers.Slider();
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
            OutputImage.Location = new Point(209, 3);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 1;
            // 
            // OptionSelector
            // 
            OptionSelector.FormattingEnabled = true;
            OptionSelector.Location = new Point(115, 73);
            OptionSelector.Name = "OptionSelector";
            OptionSelector.Size = new Size(88, 23);
            OptionSelector.TabIndex = 2;
            // 
            // SizeBar
            // 
            SizeBar.Location = new Point(66, 146);
            SizeBar.Name = "SizeBar";
            SizeBar.Size = new Size(200, 74);
            SizeBar.TabIndex = 3;
            // 
            // DilationErosion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(SizeBar);
            Controls.Add(OptionSelector);
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Name = "DilationErosion";
            Size = new Size(315, 219);
            ResumeLayout(false);
        }

        #endregion

        private Helpers.InputImage InputImage;
        private Helpers.OutputImage OutputImage;
        private ComboBox OptionSelector;
        private Helpers.Slider SizeBar;
    }
}
