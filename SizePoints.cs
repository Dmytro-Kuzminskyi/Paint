using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class MainForm
    {
        private bool resizeEnabled = false;

        private void SizePoint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                resizeEnabled = true;
        }

        private void SizePoint_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                resizeEnabled = false;
                freeRoamGraphics = canvas.CreateGraphics();
                freeRoamGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                if (drawningMode != DrawningMode.Free)
                {
                    segmentGraphics = canvas.CreateGraphics();
                    segmentGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                }
            }
        }

        private void SizePoint_MouseEnter(object sender, EventArgs e)
        {
            var s = (sender as PictureBox);
            if (s == sSizePoint)
                s.Cursor = Cursors.SizeNS;
            else if (s == eSizePoint)
                Cursor = Cursors.SizeWE;
            else
                Cursor = Cursors.SizeNWSE;
        }

        private void SizePoint_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void SizePoint_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as PictureBox;
            if (resizeEnabled)
            {
                if (s == sSizePoint)
                    canvas.Height = canvas.Height - s.Height + e.Y;
                else if (s == eSizePoint)
                    canvas.Width = canvas.Width - s.Width + e.X;
                else
                {
                    canvas.Width = canvas.Width - seSizePoint.Width + e.X;
                    canvas.Height = canvas.Height - seSizePoint.Height + e.Y;
                }
            }
        }
    }
}
