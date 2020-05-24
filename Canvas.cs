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
        private Point position;

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
                    using (var g = Graphics.FromImage(canvas.Image))
                    {
                        using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                        {
                            pen.Width = float.Parse(thicknessValue.Text);
                            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                            g.DrawLine(pen, position, e.Location);
                            position = e.Location;
                            canvas.Refresh();
                        }
                    }
                }
                else
                {
                    using (var g = canvas.CreateGraphics())
                    {
                        CreateFigure(g, e);
                    }
                }
            }
        }

        private void CreateFigure(Graphics g, MouseEventArgs e)
        {
            if (drawningMode == DrawningMode.Line)
            {
                using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                {
                    pen.Width = float.Parse(thicknessValue.Text);
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    g.Clear(Color.White);
                    canvas.Refresh();
                    g.DrawLine(pen, position, e.Location);
                }
            }
            else if (drawningMode == DrawningMode.Rectangle || drawningMode == DrawningMode.Ellipse)
            {
                if (drawningMode == DrawningMode.Rectangle)
                    drawFigureAction = g.DrawRectangle;
                else if (drawningMode == DrawningMode.Ellipse)
                    drawFigureAction = g.DrawEllipse;
                using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                {
                    pen.Width = float.Parse(thicknessValue.Text);
                    pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    g.Clear(Color.White);
                    canvas.Refresh();
                    if (e.X >= position.X && e.Y >= position.Y)
                        drawFigureAction(pen, new Rectangle(position.X, position.Y, e.X - position.X, e.Y - position.Y));
                    else if (e.X >= position.X && e.Y < position.Y)
                    {
                        g.TranslateTransform(0, canvas.Height);
                        g.ScaleTransform(1, -1);
                        drawFigureAction(pen, new Rectangle(position.X, canvas.Height - position.Y, e.X - position.X, position.Y - e.Y));
                    }
                    else if (e.X < position.X && e.Y >= position.Y)
                    {
                        g.TranslateTransform(canvas.Width, 0);
                        g.ScaleTransform(-1, 1);
                        drawFigureAction(pen, new Rectangle(canvas.Width - position.X, position.Y, position.X - e.X, e.Y - position.Y));
                    }
                    else
                    {
                        g.TranslateTransform(canvas.Width, canvas.Height);
                        g.ScaleTransform(-1, -1);
                        drawFigureAction(pen, new Rectangle(canvas.Width - position.X, canvas.Height - position.Y, position.X - e.X, position.Y - e.Y));
                    }
                }
            }
            else
            {
                if (drawningMode == DrawningMode.FilledRectangle)
                    fillFigureAction = g.FillRectangle;
                else if (drawningMode == DrawningMode.FilledEllipse)
                    fillFigureAction = g.FillEllipse;
                using (var brush = isMainColorActivated ? new SolidBrush(color0) : new SolidBrush(color1))
                {
                    g.Clear(Color.White);
                    canvas.Refresh();
                    if (e.X >= position.X && e.Y >= position.Y)
                        fillFigureAction(brush, new Rectangle(position.X, position.Y, e.X - position.X, e.Y - position.Y));
                    else if (e.X >= position.X && e.Y < position.Y)
                    {
                        g.TranslateTransform(0, canvas.Height);
                        g.ScaleTransform(1, -1);
                        fillFigureAction(brush, new Rectangle(position.X, canvas.Height - position.Y, e.X - position.X, position.Y - e.Y));
                    }
                    else if (e.X < position.X && e.Y >= position.Y)
                    {
                        g.TranslateTransform(canvas.Width, 0);
                        g.ScaleTransform(-1, 1);
                        fillFigureAction(brush, new Rectangle(canvas.Width - position.X, position.Y, position.X - e.X, e.Y - position.Y));
                    }
                    else
                    {
                        g.TranslateTransform(canvas.Width, canvas.Height);
                        g.ScaleTransform(-1, -1);
                        fillFigureAction(brush, new Rectangle(canvas.Width - position.X, canvas.Height - position.Y, position.X - e.X, position.Y - e.Y));
                    }
                }
            }
        }
    }
}
