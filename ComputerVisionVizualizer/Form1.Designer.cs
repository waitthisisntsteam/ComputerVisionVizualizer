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
            NewTabButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            tabs = new TabControl();
            tabPage1 = new TabPage();
            buttonList = new TableLayoutPanel();
            TabName = new TextBox();
            CloseTabButton = new Button();
            tabs.SuspendLayout();
            buttonList.SuspendLayout();
            SuspendLayout();
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
            // tabs
            // 
            tabs.Controls.Add(tabPage1);
            tabs.Location = new Point(93, 12);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(850, 520);
            tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonList
            // 
            buttonList.BackColor = SystemColors.InactiveCaption;
            buttonList.ColumnCount = 1;
            buttonList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonList.Controls.Add(NewTabButton, 0, 0);
            buttonList.Controls.Add(TabName, 0, 1);
            buttonList.Controls.Add(CloseTabButton, 0, 2);
            buttonList.Location = new Point(10, 12);
            buttonList.Name = "buttonList";
            buttonList.RowCount = 17;
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            buttonList.Size = new Size(77, 517);
            buttonList.TabIndex = 1;
            // 
            // TabName
            // 
            TabName.Location = new Point(3, 33);
            TabName.Name = "TabName";
            TabName.Size = new Size(71, 23);
            TabName.TabIndex = 2;
            TabName.TextChanged += TabName_TextChanged;
            // 
            // CloseTabButton
            // 
            CloseTabButton.Location = new Point(3, 63);
            CloseTabButton.Name = "CloseTabButton";
            CloseTabButton.Size = new Size(71, 23);
            CloseTabButton.TabIndex = 1;
            CloseTabButton.Text = "Close Tab";
            CloseTabButton.UseVisualStyleBackColor = true;
            CloseTabButton.Click += CloseTabButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 536);
            Controls.Add(buttonList);
            Controls.Add(tabs);
            Name = "Form1";
            Text = "Form1";
            tabs.ResumeLayout(false);
            buttonList.ResumeLayout(false);
            buttonList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button NewTabButton;
        private OpenFileDialog openFileDialog1;
        private TabControl tabs;
        private TableLayoutPanel buttonList;
        private Button CloseTabButton;
        private TextBox TabName;
        private TabPage tabPage1;
    }
}
