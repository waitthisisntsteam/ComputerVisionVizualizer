namespace ComputerVisionVizualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ResizeButton = new Button();
            RotateButton = new Button();
            NewTabButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            tabPage1 = new TabPage();
            FactorLabel = new Label();
            FactorText = new TextBox();
            SavePictureButton = new Button();
            ImportPictureButton = new Button();
            updatedPicture = new Emgu.CV.UI.ImageBox();
            originalPicture = new Emgu.CV.UI.ImageBox();
            TabControl = new TabControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updatedPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPicture).BeginInit();
            TabControl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ResizeButton
            // 
            ResizeButton.Location = new Point(401, 369);
            ResizeButton.Name = "ResizeButton";
            ResizeButton.Size = new Size(75, 23);
            ResizeButton.TabIndex = 7;
            ResizeButton.Text = "Resize";
            ResizeButton.UseVisualStyleBackColor = true;
            ResizeButton.Click += ResizeButton_Click;
            // 
            // RotateButton
            // 
            RotateButton.Location = new Point(219, 369);
            RotateButton.Name = "RotateButton";
            RotateButton.Size = new Size(75, 23);
            RotateButton.TabIndex = 5;
            RotateButton.Text = "Rotate";
            RotateButton.UseVisualStyleBackColor = true;
            RotateButton.Click += RotateButton_Click;
            // 
            // NewTabButton
            // 
            NewTabButton.Location = new Point(3, 3);
            NewTabButton.Name = "NewTabButton";
            NewTabButton.Size = new Size(71, 23);
            NewTabButton.TabIndex = 0;
            NewTabButton.Text = "New Tab";
            NewTabButton.UseVisualStyleBackColor = true;
            NewTabButton.Click += NewTabButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(FactorLabel);
            tabPage1.Controls.Add(FactorText);
            tabPage1.Controls.Add(ResizeButton);
            tabPage1.Controls.Add(SavePictureButton);
            tabPage1.Controls.Add(RotateButton);
            tabPage1.Controls.Add(ImportPictureButton);
            tabPage1.Controls.Add(updatedPicture);
            tabPage1.Controls.Add(originalPicture);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(687, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FactorLabel
            // 
            FactorLabel.AutoSize = true;
            FactorLabel.Enabled = false;
            FactorLabel.Location = new Point(322, 301);
            FactorLabel.Name = "FactorLabel";
            FactorLabel.Size = new Size(40, 15);
            FactorLabel.TabIndex = 9;
            FactorLabel.Text = "Factor";
            FactorLabel.Visible = false;
            // 
            // FactorText
            // 
            FactorText.Enabled = false;
            FactorText.Location = new Point(292, 319);
            FactorText.Name = "FactorText";
            FactorText.Size = new Size(100, 23);
            FactorText.TabIndex = 8;
            FactorText.Visible = false;
            FactorText.TextChanged += FactorText_TextChanged;
            // 
            // SavePictureButton
            // 
            SavePictureButton.Location = new Point(479, 312);
            SavePictureButton.Name = "SavePictureButton";
            SavePictureButton.Size = new Size(100, 23);
            SavePictureButton.TabIndex = 6;
            SavePictureButton.Text = "Save Picture";
            SavePictureButton.UseVisualStyleBackColor = true;
            SavePictureButton.Click += SavePictureButton_Click;
            // 
            // ImportPictureButton
            // 
            ImportPictureButton.Location = new Point(104, 312);
            ImportPictureButton.Name = "ImportPictureButton";
            ImportPictureButton.Size = new Size(102, 23);
            ImportPictureButton.TabIndex = 4;
            ImportPictureButton.Text = "Import Picture";
            ImportPictureButton.UseVisualStyleBackColor = true;
            ImportPictureButton.Click += ImportPictureButton_Click;
            // 
            // updatedPicture
            // 
            updatedPicture.Location = new Point(381, 6);
            updatedPicture.Name = "updatedPicture";
            updatedPicture.Size = new Size(300, 300);
            updatedPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            updatedPicture.TabIndex = 3;
            updatedPicture.TabStop = false;
            // 
            // originalPicture
            // 
            originalPicture.Location = new Point(6, 6);
            originalPicture.Name = "originalPicture";
            originalPicture.Size = new Size(300, 300);
            originalPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            originalPicture.TabIndex = 2;
            originalPicture.TabStop = false;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Location = new Point(93, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(695, 426);
            TabControl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NewTabButton, 0, 0);
            tableLayoutPanel1.Location = new Point(10, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(77, 426);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TabControl);
            Name = "Form1";
            Text = "Form1";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updatedPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPicture).EndInit();
            TabControl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button NewTabButton;
        private OpenFileDialog openFileDialog1;
        private Button RotateButton;
        private Button ResizeButton;
        private TabPage tabPage1;
        private Label FactorLabel;
        private TextBox FactorText;
        private Button SavePictureButton;
        private Button ImportPictureButton;
        private Emgu.CV.UI.ImageBox updatedPicture;
        private Emgu.CV.UI.ImageBox originalPicture;
        private TabControl TabControl;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
