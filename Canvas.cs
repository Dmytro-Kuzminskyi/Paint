using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm
    {
        private bool isDrawningStarted = false;
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
                if (drawningMode != DrawningMode.Free)
                    canvas.Image = ImageProcessor.DrawControlToBitmap(canvas);
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
            if (isDrawningStarted)
            {
                if (drawningMode == DrawningMode.Free)
                {
                    var g = Graphics.FromImage(canvas.Image);
                    g.DrawLine(pen, (PointF)position, e.Location);
                    position = e.Location;
                    canvas.Refresh();
                    g.Dispose();
                }
                else if (drawningMode == DrawningMode.Line)
                {
                    using (var g = canvas.CreateGraphics())
                    {
                        g.Clear(Color.White);
                        canvas.Refresh();
                        g.DrawLine(pen, (PointF)position, e.Location);
                    }
                }
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(snapshot, new Point(0, 0));
        }
    }
}
