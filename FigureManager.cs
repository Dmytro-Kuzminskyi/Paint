using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private DrawningMode drawningMode = DrawningMode.Free;
        enum DrawningMode
        {
            Free,
            Line
        }

        private void DrawLineButton_Click(object sender, EventArgs e)
        {
            if (drawLineButton.BackColor == SystemColors.Control)
            {
                drawningMode = DrawningMode.Line;
                drawLineButton.BackColor = Color.LightBlue;
            } 
            else
            {
                drawningMode = DrawningMode.Free;
                drawLineButton.BackColor = SystemColors.Control;
            }
        }
    }
}
