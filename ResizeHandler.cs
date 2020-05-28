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
                canvasInitialWidth = layer.CanvasWidth;
                canvasInitialHeight = layer.CanvasHeight;
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
                    layer.CanvasHeight += e.Y;
                    sSizePointInvoked = false;
                }
                else if (eSizePointInvoked)
                {
                    layer.CanvasWidth += e.X;
                    eSizePointInvoked = false;
                }
                else
                {
                    layer.CanvasWidth += e.X;
                    layer.CanvasHeight += e.Y;
                }
                if (layer.CanvasWidth <= 0 || layer.CanvasHeight <= 0)
                {
                    layer.CanvasWidth = canvasInitialWidth;
                    layer.CanvasHeight = canvasInitialHeight;
                } 
                else
                    layer.UpdateImage();
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
