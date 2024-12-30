namespace ComputerVisionVizualizer.Controls
{
    partial class BitwiseOperation
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
            BitwiseOperatorSelect = new ComboBox();
            Output = new Label();
            InputImageOne = new Helpers.InputImage();
            InputImageTwo = new Helpers.InputImage();
            OutputImage = new Helpers.OutputImage();
            SuspendLayout();
            // 
            // BitwiseOperatorSelect
            // 
            BitwiseOperatorSelect.FormattingEnabled = true;
            BitwiseOperatorSelect.Location = new Point(146, 80);
            BitwiseOperatorSelect.Name = "BitwiseOperatorSelect";
            BitwiseOperatorSelect.Size = new Size(83, 23);
            BitwiseOperatorSelect.TabIndex = 4;
            BitwiseOperatorSelect.SelectedIndexChanged += BitwiseOperatorSelect_SelectedIndexChanged;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(341, 85);
            Output.Name = "Output";
            Output.Size = new Size(15, 15);
            Output.TabIndex = 6;
            Output.Text = "=";
            // 
            // InputImageOne
            // 
            InputImageOne.Location = new Point(34, 11);
            InputImageOne.Name = "InputImageOne";
            InputImageOne.Size = new Size(106, 137);
            InputImageOne.TabIndex = 10;
            // 
            // InputImageTwo
            // 
            InputImageTwo.Location = new Point(235, 10);
            InputImageTwo.Name = "InputImageTwo";
            InputImageTwo.Size = new Size(106, 137);
            InputImageTwo.TabIndex = 11;
            // 
            // OutputImage
            // 
            OutputImage.Location = new Point(362, 10);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(106, 137);
            OutputImage.TabIndex = 12;
            // 
            // BitwiseOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(OutputImage);
            Controls.Add(InputImageTwo);
            Controls.Add(InputImageOne);
            Controls.Add(Output);
            Controls.Add(BitwiseOperatorSelect);
            Name = "BitwiseOperation";
            Size = new Size(500, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox BitwiseOperatorSelect;
        private Label Output;
        private Helpers.InputImage InputImageOne;
        private Helpers.InputImage InputImageTwo;
        private Helpers.OutputImage OutputImage;
    }
}
