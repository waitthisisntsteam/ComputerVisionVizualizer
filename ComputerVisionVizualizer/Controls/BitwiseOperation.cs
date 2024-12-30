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

            List<Item> items = [
            new Item() { Text = "AND", Value = 0 },
            new Item() { Text = "OR", Value = 1 },
            new Item() { Text = "XOR", Value = 2 },
            new Item() { Text = "NOT", Value = 3 },
            new Item() { Text = "ADD", Value = 4 },
            new Item() { Text = "SUB", Value = 5 },
            new Item() { Text = "MUL", Value = 6 },
            new Item() { Text = "DIV", Value = 6 }
            ];

            InputImageOne.ImageSubmitted += Combine;
            InputImageTwo.ImageSubmitted += Combine;

            BitwiseOperatorSelect.DataSource = items;
            BitwiseOperatorSelect.DisplayMember = "Text";
            BitwiseOperatorSelect.ValueMember = "Value";
        }

        private void Combine(object sender, EventArgs e)
        {
            if (InputImageOne.GetImage() != null && InputImageTwo.GetImage() != null)
            {
                Mat output = new();

                if (BitwiseOperatorSelect.Text == "AND") CvInvoke.BitwiseAnd(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "OR") CvInvoke.BitwiseOr(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "XOR") CvInvoke.BitwiseXor(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "NOT") CvInvoke.BitwiseNot(InputImageOne.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "ADD") CvInvoke.Add(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "SUB") CvInvoke.Subtract(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "MUL") CvInvoke.Multiply(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);
                else if (BitwiseOperatorSelect.Text == "DIV") CvInvoke.Divide(InputImageOne.GetImage(), InputImageTwo.GetImage(), output);

                OutputImage.SetImage(output);
            }
        }

        private void BitwiseOperatorSelect_SelectedIndexChanged(object sender, EventArgs e) => Combine(sender, e);
    }
}
