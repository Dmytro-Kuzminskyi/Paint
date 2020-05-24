using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private DrawningMode drawningMode = DrawningMode.Free;
        private enum DrawningMode
        {
            Free,
            Line,
            Rectangle,
            FilledRectangle,
            Ellipse,
            FilledEllipse
        }

        private void DrawLineButton_Click(object sender, EventArgs e)
        {
            drawRectangleButton.BackColor = SystemColors.Control;
            drawFilledRectangleButton.BackColor = SystemColors.Control;
            drawEllipseButton.BackColor = SystemColors.Control;
            drawFilledEllipseButton.BackColor = SystemColors.Control;
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

        private void DrawRectangleButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Control;
            drawFilledRectangleButton.BackColor = SystemColors.Control;
            drawEllipseButton.BackColor = SystemColors.Control;
            drawFilledEllipseButton.BackColor = SystemColors.Control;
            if (drawRectangleButton.BackColor == SystemColors.Control)
            {
                drawningMode = DrawningMode.Rectangle;
                drawRectangleButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawRectangleButton.BackColor = SystemColors.Control;
            }
        }

        private void DrawFilledRectangleButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Control;
            drawRectangleButton.BackColor = SystemColors.Control;
            drawEllipseButton.BackColor = SystemColors.Control;
            drawFilledEllipseButton.BackColor = SystemColors.Control;
            if (drawFilledRectangleButton.BackColor == SystemColors.Control)
            {
                drawningMode = DrawningMode.FilledRectangle;
                drawFilledRectangleButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawFilledRectangleButton.BackColor = SystemColors.Control;
            }
        }

        private void DrawEllipseButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Control;
            drawRectangleButton.BackColor = SystemColors.Control;
            drawFilledRectangleButton.BackColor = SystemColors.Control;
            drawFilledEllipseButton.BackColor = SystemColors.Control;
            if (drawEllipseButton.BackColor == SystemColors.Control)
            {
                drawningMode = DrawningMode.Ellipse;
                drawEllipseButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawEllipseButton.BackColor = SystemColors.Control;
            }
        }

        private void DrawFilledEllipseButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Control;
            drawRectangleButton.BackColor = SystemColors.Control;
            drawFilledRectangleButton.BackColor = SystemColors.Control;
            drawEllipseButton.BackColor = SystemColors.Control;
            if (drawFilledEllipseButton.BackColor == SystemColors.Control)
            {
                drawningMode = DrawningMode.FilledEllipse;
                drawFilledEllipseButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawFilledEllipseButton.BackColor = SystemColors.Control;
            }
        }
    }
}
