using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private enum DrawningMode
        {
            Free,
            Eraser,
            Line,
            Rectangle,
            FilledRectangle,
            Ellipse,
            FilledEllipse
        }

        private void DrawLineButton_Click(object sender, EventArgs e)
        {
            drawRectangleButton.BackColor = SystemColors.Window;
            drawFilledRectangleButton.BackColor = SystemColors.Window;
            drawEllipseButton.BackColor = SystemColors.Window;
            drawFilledEllipseButton.BackColor = SystemColors.Window;
            eraserButton.BackColor = SystemColors.Window;
            if (drawLineButton.BackColor == SystemColors.Window)
            {
                drawningMode = DrawningMode.Line;
                drawLineButton.BackColor = Color.LightBlue;
            } 
            else
            {
                drawningMode = DrawningMode.Free;
                drawLineButton.BackColor = SystemColors.Window;
            }
        }

        private void DrawRectangleButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Window;
            drawFilledRectangleButton.BackColor = SystemColors.Window;
            drawEllipseButton.BackColor = SystemColors.Window;
            drawFilledEllipseButton.BackColor = SystemColors.Window;
            eraserButton.BackColor = SystemColors.Window;
            if (drawRectangleButton.BackColor == SystemColors.Window)
            {
                drawningMode = DrawningMode.Rectangle;
                drawRectangleButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawRectangleButton.BackColor = SystemColors.Window;
            }
        }

        private void DrawFilledRectangleButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Window;
            drawRectangleButton.BackColor = SystemColors.Window;
            drawEllipseButton.BackColor = SystemColors.Window;
            drawFilledEllipseButton.BackColor = SystemColors.Window;
            eraserButton.BackColor = SystemColors.Window;
            if (drawFilledRectangleButton.BackColor == SystemColors.Window)
            {
                drawningMode = DrawningMode.FilledRectangle;
                drawFilledRectangleButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawFilledRectangleButton.BackColor = SystemColors.Window;
            }
        }

        private void DrawEllipseButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Window;
            drawRectangleButton.BackColor = SystemColors.Window;
            drawFilledRectangleButton.BackColor = SystemColors.Window;
            drawFilledEllipseButton.BackColor = SystemColors.Window;
            eraserButton.BackColor = SystemColors.Window;
            if (drawEllipseButton.BackColor == SystemColors.Window)
            {
                drawningMode = DrawningMode.Ellipse;
                drawEllipseButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawEllipseButton.BackColor = SystemColors.Window;
            }
        }

        private void DrawFilledEllipseButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Window;
            drawRectangleButton.BackColor = SystemColors.Window;
            drawFilledRectangleButton.BackColor = SystemColors.Window;
            drawEllipseButton.BackColor = SystemColors.Window;
            eraserButton.BackColor = SystemColors.Window;
            if (drawFilledEllipseButton.BackColor == SystemColors.Window)
            {
                drawningMode = DrawningMode.FilledEllipse;
                drawFilledEllipseButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                drawFilledEllipseButton.BackColor = SystemColors.Window;
            }
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            drawLineButton.BackColor = SystemColors.Window;
            drawRectangleButton.BackColor = SystemColors.Window;
            drawFilledRectangleButton.BackColor = SystemColors.Window;
            drawEllipseButton.BackColor = SystemColors.Window;
            drawFilledEllipseButton.BackColor = SystemColors.Window;
            if (eraserButton.BackColor == SystemColors.Window)
            {
                drawningMode = DrawningMode.Eraser;
                eraserButton.BackColor = Color.LightBlue;
            }
            else
            {
                drawningMode = DrawningMode.Free;
                eraserButton.BackColor = SystemColors.Window;
            }
        }
    }
}
