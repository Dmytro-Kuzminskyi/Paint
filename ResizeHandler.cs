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
                    layer.CanvasHeight += (int)(e.Y / zoomFactor);
                    sSizePointInvoked = false;
                }
                else if (eSizePointInvoked)
                {
                    layer.CanvasWidth += (int)(e.X / zoomFactor);
                    eSizePointInvoked = false;
                }
                else
                {
                    layer.CanvasWidth += (int)(e.X / zoomFactor);
                    layer.CanvasHeight += (int)(e.Y / zoomFactor);
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
                    resizeDY = (int)(e.Y / zoomFactor);
                }
                else if (eSizePointInvoked)
                {
                    resizeDX = (int)(e.X / zoomFactor);
                }
                else
                {
                    resizeDX = (int)(e.X / zoomFactor);
                    resizeDY = (int)(e.Y / zoomFactor);
                }
                layer.Invalidate();
            }
        }
    }
}