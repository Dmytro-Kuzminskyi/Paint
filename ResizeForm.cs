using System;
using System.Windows.Forms;

namespace Paint
{
    public partial class ResizeForm : Form
    {
        private int width, height;
        private bool isInvalidDataPresent = false;
        public int OutputWidth { get; set; }
        public int OutputHeight { get; set; }

        public ResizeForm(int w, int h)
        {
            width = w;
            height = h;
            InitializeComponent();
            okButton.DialogResult = DialogResult.OK;
            horizontalTextBox.Text = "100";
            verticalTextBox.Text = "100";
            horizontalTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (percentageRadioButton.Checked)
            {
                horizontalTextBox.Text = "100";
                verticalTextBox.Text = "100";
            }
            else
            {
                horizontalTextBox.Text = width.ToString();
                verticalTextBox.Text = height.ToString();
            }
        }

        private void TextBoxValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ratioCheckBox.Checked && percentageRadioButton.Checked)
            {
                var s = sender as TextBox;
                if (s == horizontalTextBox)
                    verticalTextBox.Text = s.Text;
                else
                    horizontalTextBox.Text = s.Text;
                horizontalTextBox.SelectionStart = horizontalTextBox.Text.Length;
                horizontalTextBox.SelectionLength = 0;
                verticalTextBox.SelectionStart = verticalTextBox.Text.Length;
                verticalTextBox.SelectionLength = 0;
            }
            if (ratioCheckBox.Checked && !percentageRadioButton.Checked)
            {
                var s = sender as TextBox;
                var aspectRatio = width / height;
                if (s.Text != "0" && s.Text != "")
                {
                    if (s == horizontalTextBox)
                        verticalTextBox.Text = ((int.Parse(s.Text) / aspectRatio)).ToString();
                    else
                        horizontalTextBox.Text = ((int.Parse(s.Text) * aspectRatio)).ToString();
                }
                horizontalTextBox.SelectionStart = horizontalTextBox.Text.Length;
                horizontalTextBox.SelectionLength = 0;
                verticalTextBox.SelectionStart = verticalTextBox.Text.Length;
                verticalTextBox.SelectionLength = 0;
            }
        }

        private void ResizeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                isInvalidDataPresent = false;
            if (isInvalidDataPresent)
                e.Cancel = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            isInvalidDataPresent = false;
        }

        private void ratioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var s = sender as CheckBox;
            if (s.Checked)
            {
                var aspectRatio = width / height;
                var hv = Math.Abs(1 - (int.Parse(horizontalTextBox.Text) / width));
                var vv = Math.Abs(1 - (int.Parse(verticalTextBox.Text) / height));
                if (hv > vv)
                    verticalTextBox.Text = ((int.Parse(horizontalTextBox.Text) / aspectRatio)).ToString();
                else
                    horizontalTextBox.Text = ((int.Parse(verticalTextBox.Text) * aspectRatio)).ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (horizontalTextBox.Text == "" || verticalTextBox.Text == "")
            {
                isInvalidDataPresent = true;
                MessageBox.Show("Please enter a positive number.", "Paint",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (percentageRadioButton.Checked && (horizontalTextBox.Text == "0" || verticalTextBox.Text == "0" ||
                    int.Parse(horizontalTextBox.Text) > 500 || int.Parse(verticalTextBox.Text) > 500))
            { 
                isInvalidDataPresent = true;
                MessageBox.Show("Please enter a valid number between 1 and 500.", "Paint",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (!percentageRadioButton.Checked && (horizontalTextBox.Text == "0" || verticalTextBox.Text == "0"))
            {
                isInvalidDataPresent = true;
                MessageBox.Show("Please enter a valid number between 1 and 9999.", "Paint",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            else
            {
                isInvalidDataPresent = false;
                if (percentageRadioButton.Checked)
                {
                    OutputWidth = width * int.Parse(horizontalTextBox.Text) / 100;
                    OutputHeight = height *  int.Parse(verticalTextBox.Text) / 100;
                }
                else
                {
                    OutputWidth = int.Parse(horizontalTextBox.Text);
                    OutputHeight = int.Parse(verticalTextBox.Text);
                }
            }
        }
    }
}
