using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                segmentGraphics = canvas.CreateGraphics();
                segmentGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                drawningMode = DrawningMode.Line;
                drawLineButton.BackColor = Color.LightBlue;
            } 
            else
            {
                segmentGraphics.Dispose();
                drawningMode = DrawningMode.Free;
                drawLineButton.BackColor = SystemColors.Control;
            }
        }
    }
}
