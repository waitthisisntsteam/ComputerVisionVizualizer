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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitwiseOperation));
            InputPictureOne = new Emgu.CV.UI.ImageBox();
            InputPictureTwo = new Emgu.CV.UI.ImageBox();
            BitwiseOperatorSelect = new ComboBox();
            OutputImage = new Emgu.CV.UI.ImageBox();
            Output = new Label();
            InputPictureOneSelect = new ComboBox();
            InputPictureTwoSelect = new ComboBox();
            OutputPictureName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)InputPictureOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPictureTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputImage).BeginInit();
            SuspendLayout();
            // 
            // InputPictureOne
            // 
            InputPictureOne.BorderStyle = BorderStyle.FixedSingle;
            InputPictureOne.InitialImage = (Image)resources.GetObject("InputPictureOne.InitialImage");
            InputPictureOne.Location = new Point(40, 40);
            InputPictureOne.Name = "InputPictureOne";
            InputPictureOne.Size = new Size(100, 100);
            InputPictureOne.SizeMode = PictureBoxSizeMode.StretchImage;
            InputPictureOne.TabIndex = 2;
            InputPictureOne.TabStop = false;
            InputPictureOne.Click += InputPictureOne_Click;
            // 
            // InputPictureTwo
            // 
            InputPictureTwo.BorderStyle = BorderStyle.FixedSingle;
            InputPictureTwo.InitialImage = (Image)resources.GetObject("InputPictureTwo.InitialImage");
            InputPictureTwo.Location = new Point(235, 40);
            InputPictureTwo.Name = "InputPictureTwo";
            InputPictureTwo.Size = new Size(100, 100);
            InputPictureTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            InputPictureTwo.TabIndex = 3;
            InputPictureTwo.TabStop = false;
            InputPictureTwo.Click += InputPictureTwo_Click;
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
            // OutputImage
            // 
            OutputImage.BorderStyle = BorderStyle.FixedSingle;
            OutputImage.InitialImage = (Image)resources.GetObject("OutputImage.InitialImage");
            OutputImage.Location = new Point(362, 40);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(100, 100);
            OutputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputImage.TabIndex = 5;
            OutputImage.TabStop = false;
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
            // InputPictureOneSelect
            // 
            InputPictureOneSelect.FormattingEnabled = true;
            InputPictureOneSelect.Location = new Point(40, 11);
            InputPictureOneSelect.Name = "InputPictureOneSelect";
            InputPictureOneSelect.Size = new Size(100, 23);
            InputPictureOneSelect.TabIndex = 7;
            InputPictureOneSelect.SelectedIndexChanged += InputPictureOneSelect_SelectedIndexChanged;
            // 
            // InputPictureTwoSelect
            // 
            InputPictureTwoSelect.FormattingEnabled = true;
            InputPictureTwoSelect.Location = new Point(235, 11);
            InputPictureTwoSelect.Name = "InputPictureTwoSelect";
            InputPictureTwoSelect.Size = new Size(100, 23);
            InputPictureTwoSelect.TabIndex = 8;
            InputPictureTwoSelect.SelectedIndexChanged += InputPictureTwoSelect_SelectedIndexChanged;
            // 
            // OutputPictureName
            // 
            OutputPictureName.Location = new Point(362, 11);
            OutputPictureName.Name = "OutputPictureName";
            OutputPictureName.Size = new Size(100, 23);
            OutputPictureName.TabIndex = 9;
            OutputPictureName.TextChanged += OutputImageName_TextChanged;
            // 
            // BitwiseOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(OutputPictureName);
            Controls.Add(InputPictureTwoSelect);
            Controls.Add(InputPictureOneSelect);
            Controls.Add(Output);
            Controls.Add(OutputImage);
            Controls.Add(BitwiseOperatorSelect);
            Controls.Add(InputPictureTwo);
            Controls.Add(InputPictureOne);
            Name = "BitwiseOperation";
            Size = new Size(500, 150);
            Load += BitwiseOperation_Load;
            ((System.ComponentModel.ISupportInitialize)InputPictureOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPictureTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InputPictureOne;
        private Emgu.CV.UI.ImageBox InputPictureTwo;
        private ComboBox BitwiseOperatorSelect;
        private Emgu.CV.UI.ImageBox OutputImage;
        private Label Output;
        private ComboBox InputPictureOneSelect;
        private ComboBox InputPictureTwoSelect;
        private TextBox OutputPictureName;
    }
}
