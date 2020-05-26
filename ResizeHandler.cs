using System;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm
    {
        private int canvasInitialWidth, canvasInitialHeight;
        private bool sSizePointInvoked = false;
        private bool eSizePointInvoked = false;
        private int resizeDX, resizeDY;

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
        private void SizePoint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                operation = Operation.Resize;
                canvasInitialWidth = canvas.Width;
                canvasInitialHeight = canvas.Height;
                var s = sender as PictureBox;
                if (s == sSizePoint)
                    sSizePointInvoked = true;
                else if (s == eSizePoint)
                    eSizePointInvoked = true;
            }
        }

        private void SizePoint_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                operation = Operation.None;
                if (sSizePointInvoked)
                {
                    canvas.Height += e.Y;
                    sSizePointInvoked = false;
                }
                else if (eSizePointInvoked)
                {
                    canvas.Width += e.X;
                    eSizePointInvoked = false;
                }
                else
                {
                    canvas.Width += e.X;
                    canvas.Height += e.Y;
                }
                if (canvas.Width <= 0 || canvas.Height <= 0)
                {
                    canvas.Width = canvasInitialWidth;
                    canvas.Height = canvasInitialHeight;
                } 
                else
                    canvas.UpdateImage(null);
                layer.Invalidate();
            }
        }

        private void SizePoint_MouseMove(object sender, MouseEventArgs e)
        {
            if (operation == Operation.Resize)
            {
                if (sSizePointInvoked)
                {
                    resizeDY = e.Y;
                }
                else if (eSizePointInvoked)
                {
                    resizeDX = e.X;
                }
                else
                {
                    resizeDX = e.X;
                    resizeDY = e.Y;
                }
                layer.Invalidate();
            }
        }
    }
}
