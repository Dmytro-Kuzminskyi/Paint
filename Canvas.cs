using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm
    {
        private bool isDrawningStarted = false;
        private bool imagePainted = false;
        private Point? position;

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawningStarted = true;
                position = new Point(e.X, e.Y);
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawningStarted = false;
                position = null;
            }
        }
        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            canvasCoordinateLabel.Text = "";
        }

        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            int xOffset = canvas.Location.X;
            int yOffset = canvas.Location.Y;
            sSizePoint.Location = new Point(canvas.Width / 2 - 3 + xOffset, canvas.Height + yOffset);
            eSizePoint.Location = new Point(canvas.Width + xOffset, canvas.Height / 2 - 3 + yOffset);
            seSizePoint.Location = new Point(canvas.Width + xOffset, canvas.Height + yOffset);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            canvasCoordinateLabel.Text = e.X.ToString() + ", " + e.Y.ToString() + "px";
            if (drawningMode == DrawningMode.Free)
            {
                if (isDrawningStarted)
                {
                    freeRoamGraphics.DrawLine(pen, (PointF)position, e.Location);
                    position = e.Location;
                }
            }
            else if (drawningMode == DrawningMode.Line)
            {
                if (isDrawningStarted)
                {
                    segmentGraphics.Clear(Color.Transparent);
                    segmentGraphics.DrawLine(pen, (PointF)position, e.Location);
                }
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (filePath != null && img != null && !imagePainted)
            {
                e.Graphics.DrawImage(img, canvas.ClientRectangle);
                imagePainted = true;
            }
        }
    }
}
