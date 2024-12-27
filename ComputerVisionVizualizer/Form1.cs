using Emgu.CV;

namespace ComputerVisionVizualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ImportPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes) originalPicture.Image = new Mat(fileDirectory.FileName);

            updatedPicture.Image = originalPicture.Image;
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            Mat output = new();
            CvInvoke.Rotate(originalPicture.Image, output, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);

            updatedPicture.Image = output;
        }

        private void SavePictureButton_Click(object sender, EventArgs e)
        {
            originalPicture.Image = updatedPicture.Image;
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            FactorText.Enabled = true;
            FactorText.Visible = true;

            FactorLabel.Enabled = true;
            FactorLabel.Visible = true;
        }

        private void FactorText_TextChanged(object sender, EventArgs e)
        {
            int scaleFactor = int.Parse(FactorText.Text);

            if (scaleFactor > 0)
            {
                Mat output = new();
                CvInvoke.Resize(originalPicture.Image, output, new Size(originalPicture.Width * scaleFactor, originalPicture.Height * scaleFactor));

                updatedPicture.Image = output;
            }
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Add(new TabPage(TabName.Text));
        }

        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            int removedIndex = 0;



            TabControl.TabPages.Remove(TabControl.TabPages[removedIndex]);
        }
    }
}
