namespace ComputerVisionVizualizer.Controls.Helpers
{
    partial class Slider
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
            label1 = new Label();
            Increment = new NumericUpDown();
            Bar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)Increment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Label";
            // 
            // Increment
            // 
            Increment.Location = new Point(69, 12);
            Increment.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            Increment.Name = "Increment";
            Increment.Size = new Size(47, 23);
            Increment.TabIndex = 1;
            Increment.ValueChanged += Increment_ValueChanged;
            // 
            // Bar
            // 
            Bar.Location = new Point(12, 41);
            Bar.Maximum = 255;
            Bar.Name = "Bar";
            Bar.Size = new Size(170, 45);
            Bar.TabIndex = 2;
            Bar.Scroll += Bar_Scroll;
            // 
            // Slider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Bar);
            Controls.Add(Increment);
            Controls.Add(label1);
            Name = "Slider";
            Size = new Size(200, 90);
            ((System.ComponentModel.ISupportInitialize)Increment).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown Increment;
        private TrackBar Bar;
    }
}
