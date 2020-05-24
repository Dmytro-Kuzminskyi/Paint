using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm
    {
        Action<Pen, Rectangle> drawFigureAction;
        Action<Brush, Rectangle> fillFigureAction;
        private bool isDrawningStarted = false;
        private int x0, y0, x1, y1;

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

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x0 = e.X;
                y0 = e.Y;
                isDrawningStarted = true;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawningStarted = false;
                canvas.Invalidate();
                canvas.Image = ImageProcessor.DrawControlToBitmap(canvas);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            canvasCoordinateLabel.Text = e.X.ToString() + ", " + e.Y.ToString() + "px";
            if (isDrawningStarted)
            {
                x1 = e.X;
                y1 = e.Y;
                if (drawningMode == DrawningMode.Free)
                {
                    using (var g = Graphics.FromImage(canvas.Image))
                    {
                        using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                        {
                            pen.Width = float.Parse(thicknessValue.Text);
                            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                            g.DrawLine(pen, x0, y0, e.X, e.Y);
                            x0 = e.X;
                            y0 = e.Y;
                        }
                    }
                }
                canvas.Invalidate();
            }            
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawningStarted && drawningMode != DrawningMode.Free)
            {
                CreateFigure(e);
            }
        }

        private void CreateFigure(PaintEventArgs e)
        {
            if (drawningMode == DrawningMode.Line)
            {
                using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                {
                    pen.Width = float.Parse(thicknessValue.Text);
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    e.Graphics.DrawLine(pen, x0, y0, x1, y1);
                }
            }
            else if (drawningMode == DrawningMode.Rectangle || drawningMode == DrawningMode.Ellipse)
            {
                if (drawningMode == DrawningMode.Rectangle)
                    drawFigureAction = e.Graphics.DrawRectangle;
                else if (drawningMode == DrawningMode.Ellipse)
                    drawFigureAction = e.Graphics.DrawEllipse;
                using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                {
                    pen.Width = float.Parse(thicknessValue.Text);
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    if (x1 >= x0 && y1 >= y0)
                        drawFigureAction(pen, new Rectangle(x0, y0, x1 - x0, y1 - y0));
                    else if (x1 >= x0 && y1 < y0)
                    {
                        e.Graphics.TranslateTransform(0, canvas.Height);
                        e.Graphics.ScaleTransform(1, -1);
                        drawFigureAction(pen, new Rectangle(x0, canvas.Height - y0, x1 - x0, y0 - y1));
                    }
                    else if (x1 < x0 && y1 >= y0)
                    {
                        e.Graphics.TranslateTransform(canvas.Width, 0);
                        e.Graphics.ScaleTransform(-1, 1);
                        drawFigureAction(pen, new Rectangle(canvas.Width - x0, y0, x0 - x1, y1 - y0));
                    }
                    else
                    {
                        e.Graphics.TranslateTransform(canvas.Width, canvas.Height);
                        e.Graphics.ScaleTransform(-1, -1);
                        drawFigureAction(pen, new Rectangle(canvas.Width - x0, canvas.Height - y0, x0 - x1, y0 - y1));
                    }
                }
            }
            else
            {
                if (drawningMode == DrawningMode.FilledRectangle)
                    fillFigureAction = e.Graphics.FillRectangle;
                else if (drawningMode == DrawningMode.FilledEllipse)
                    fillFigureAction = e.Graphics.FillEllipse;
                using (var brush = isMainColorActivated ? new SolidBrush(color0) : new SolidBrush(color1))
                {
                    if (x1 >= x0 && y1 >= y0)
                        fillFigureAction(brush, new Rectangle(x0, y0, x1 - x0, y1 - y0));
                    else if (x1 >= x0 && y1 < y0)
                    {
                        e.Graphics.TranslateTransform(0, canvas.Height);
                        e.Graphics.ScaleTransform(1, -1);
                        fillFigureAction(brush, new Rectangle(x0, canvas.Height - y0, x1 - x0, y0 - y1));
                    }
                    else if (x1 < x0 && y1 >= y0)
                    {
                        e.Graphics.TranslateTransform(canvas.Width, 0);
                        e.Graphics.ScaleTransform(-1, 1);
                        fillFigureAction(brush, new Rectangle(canvas.Width - x0, y0, x0 - x1, y1 - y0));
                    }
                    else
                    {
                        e.Graphics.TranslateTransform(canvas.Width, canvas.Height);
                        e.Graphics.ScaleTransform(-1, -1);
                        fillFigureAction(brush, new Rectangle(canvas.Width - x0, canvas.Height - y0, x0 - x1, y0 - y1));
                    }
                }
            }
        }
    }
}
