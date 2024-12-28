using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionVizualizer.Controls
{
    public partial class BitwiseOperation : CVIOBase
    {
        public BitwiseOperation()
        {
            InitializeComponent();
        }

        private void BitwiseOperation_Load(object sender, EventArgs e)
        {
            List<Item> items = [
            new Item() { Text = "AND", Value = 0 },
            new Item() { Text = "OR", Value = 1 },
            new Item() { Text = "XOR", Value = 2 },
            //new Item() { Text = "NOT", Value = 3 },
            new Item() { Text = "ADD", Value = 4 },
            new Item() { Text = "SUB", Value = 5 },
            new Item() { Text = "MUL", Value = 6 },
            new Item() { Text = "DIV", Value = 6 }
            ];


            BitwiseOperatorSelect.DataSource = items;
            BitwiseOperatorSelect.DisplayMember = "Text";
            BitwiseOperatorSelect.ValueMember = "Value";
        }

        private void Combine()
        {
            if (InputPictureOne.DisplayedImage != null && InputPictureTwo.DisplayedImage != null)
            {
                Mat output = new();

                if (BitwiseOperatorSelect.Text == "AND") CvInvoke.BitwiseAnd(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                else if (BitwiseOperatorSelect.Text == "OR") CvInvoke.BitwiseOr(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                else if (BitwiseOperatorSelect.Text == "XOR") CvInvoke.BitwiseXor(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                //else if (BitwiseOperatorSelect.Text == "NOT") CvInvoke.BitwiseNot(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                else if (BitwiseOperatorSelect.Text == "") CvInvoke.Add(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                else if (BitwiseOperatorSelect.Text == "") CvInvoke.Subtract(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                else if (BitwiseOperatorSelect.Text == "") CvInvoke.Multiply(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);
                else if (BitwiseOperatorSelect.Text == "") CvInvoke.Divide(InputPictureOne.DisplayedImage, InputPictureTwo.DisplayedImage, output);

                OutputImage.DisplayedImage = output;
            }
        }

        private void InputPictureOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes)
            {
                InputPictureOne.Image = new Mat(fileDirectory.FileName);
                Combine();
            }
        }

        private void InputPictureTwo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDirectory = new OpenFileDialog();
            var file = fileDirectory.ShowDialog();

            if (file == DialogResult.OK || file == DialogResult.Yes)
            {
                InputPictureTwo.Image = new Mat(fileDirectory.FileName);
                Combine();
            }
        }

        private void OutputImageName_TextChanged(object sender, EventArgs e)
        {
            //SavedImages.Add();
            //ComputerVisionVizualizer.Form1.
        }

        private void InputPictureOneSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputPictureTwoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BitwiseOperatorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combine();
        }
    }
}
