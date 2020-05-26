using Paint.Properties;
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
        private bool isCanvasArea = false;
        private bool isDrawCompleted = false;
        private int posX, posY, posFX, posFY;

        private void Layer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
                if (isCanvasArea)
                {
                    operation = Operation.Drawning;                 
                }
            }
        }

        private void Layer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                operation = Operation.None;
                if (isDrawCompleted)
                {
                    isDrawCompleted = !SaveFigure();
                }
                layer.Invalidate();
            }
        }

        private void Layer_MouseMove(object sender, MouseEventArgs e)
        {
            posFX = e.X;
            posFY = e.Y;
            isCanvasArea = (e.X >= CANVAS_OFFSET && e.X <= canvas.Width + CANVAS_OFFSET 
                && e.Y >= CANVAS_OFFSET && e.Y <= canvas.Height + CANVAS_OFFSET) ? true : false;
            if (isCanvasArea)
            {
                var xl = e.X - CANVAS_OFFSET;
                var yl = e.Y - CANVAS_OFFSET;
                layerCoordinateLabel.Text = "   " + xl + ", " + yl + "px";
                if (drawningMode == DrawningMode.Eraser)
                {
                    var s = int.Parse(thicknessValue.Text);
                    using (var c = new Bitmap(s, s))
                    {
                        using (var g = Graphics.FromImage(c))
                        {
                            g.Clear(Color.White);
                            using (var p = new Pen(Color.Black, 1f))
                            {
                                g.DrawLines(p, new[] { new Point(0, 0), new Point(s - 1, 0), new Point(s - 1, s - 1),
                            new Point(0, s - 1), new Point(0, 0) });
                            }
                        }
                        Cursor = new Cursor(c.GetHicon());
                    }
                }
                else
                    Cursor = new Cursor(Resources.Crosshair.Handle);                          
            }
            else
            {
                Cursor = Cursors.Default;
                layerCoordinateLabel.Text = "";
            }
            if (operation == Operation.Drawning)
            {
                if (drawningMode == DrawningMode.Free || drawningMode == DrawningMode.Eraser)
                {
                    using (var g = Graphics.FromImage(canvas.Image))
                    {
                        using (var pen = drawningMode == DrawningMode.Eraser ? new Pen(Color.White) : 
                            isMainColorActivated ? new Pen(color0) : new Pen(color1))
                        {
                            pen.Width = float.Parse(thicknessValue.Text);
                            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                            g.DrawLine(pen, posX - CANVAS_OFFSET, posY - CANVAS_OFFSET, e.X - CANVAS_OFFSET, e.Y - CANVAS_OFFSET);
                            posX = e.X;
                            posY = e.Y;
                        }
                    }
                }
                layer.Invalidate();
            }
        }

        private void Layer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas.Image, CANVAS_OFFSET, CANVAS_OFFSET);
            layerSizeLabel.Text = "   " + canvas.Width + " x " + canvas.Height + "px";
            sSizePoint.Location = new Point(canvas.Width / 2 - 3 + CANVAS_OFFSET, canvas.Height + CANVAS_OFFSET);
            eSizePoint.Location = new Point(canvas.Width + CANVAS_OFFSET, canvas.Height / 2 - 3 + CANVAS_OFFSET);
            seSizePoint.Location = new Point(canvas.Width + CANVAS_OFFSET, canvas.Height + CANVAS_OFFSET);
            if (operation == Operation.Resize)
            {
                using (var pen = new Pen(Color.Gray, 1f))
                {
                    pen.DashStyle = DashStyle.Dash;
                    if (sSizePointInvoked)
                        e.Graphics.DrawRectangle(pen, new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET, canvas.Width, canvas.Height + resizeDY));
                    else if (eSizePointInvoked)
                        e.Graphics.DrawRectangle(pen, new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET, canvas.Width + resizeDX, canvas.Height));
                    else
                        e.Graphics.DrawRectangle(pen, new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET,
                            canvas.Width + resizeDX, canvas.Height + resizeDY));
                }
            }
            if (operation == Operation.Drawning)
            {
                if (drawningMode != DrawningMode.Free && drawningMode != DrawningMode.Eraser)
                    isDrawCompleted = CreateFigure(e);               
            } 
        }

        private bool CreateFigure(PaintEventArgs e)
        {
            using (var r = new Region(new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET, canvas.Width, canvas.Height)))
            {
                e.Graphics.SetClip(r, CombineMode.Replace);
                if (drawningMode == DrawningMode.Line)
                {
                    using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                    {
                        pen.Width = float.Parse(thicknessValue.Text);
                        pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                        e.Graphics.DrawLine(pen, posX, posY, posFX, posFY);
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
                        if (posFX >= posX && posFY >= posY)
                            drawFigureAction(pen, new Rectangle(posX, posY, posFX - posX, posFY - posY));
                        else if (posFX >= posX && posFY < posY)
                        {
                            e.Graphics.TranslateTransform(0, canvas.Height);
                            e.Graphics.ScaleTransform(1, -1);
                            drawFigureAction(pen, new Rectangle(posX, canvas.Height - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            e.Graphics.TranslateTransform(canvas.Width, 0);
                            e.Graphics.ScaleTransform(-1, 1);
                            drawFigureAction(pen, new Rectangle(canvas.Width - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            e.Graphics.TranslateTransform(canvas.Width, canvas.Height);
                            e.Graphics.ScaleTransform(-1, -1);
                            drawFigureAction(pen, new Rectangle(canvas.Width - posX, canvas.Height - posY, posX - posFX, posY - posFY));
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
                        if (posFX >= posX && posFY >= posY)
                            fillFigureAction(brush, new Rectangle(posX, posY, posFX - posX, posFY - posY));
                        else if (posFX >= posX && posFY < posY)
                        {
                            e.Graphics.TranslateTransform(0, canvas.Height);
                            e.Graphics.ScaleTransform(1, -1);
                            fillFigureAction(brush, new Rectangle(posX, canvas.Height - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            e.Graphics.TranslateTransform(canvas.Width, 0);
                            e.Graphics.ScaleTransform(-1, 1);
                            fillFigureAction(brush, new Rectangle(canvas.Width - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            e.Graphics.TranslateTransform(canvas.Width, canvas.Height);
                            e.Graphics.ScaleTransform(-1, -1);
                            fillFigureAction(brush, new Rectangle(canvas.Width - posX, canvas.Height - posY, posX - posFX, posY - posFY));
                        }
                    }
                }
            }
            return true;
        }

        private bool SaveFigure()
        {
            using (var g = Graphics.FromImage(canvas.Image))
            {
                if (drawningMode == DrawningMode.Line)
                {
                    using (var pen = isMainColorActivated ? new Pen(color0) : new Pen(color1))
                    {
                        pen.Width = float.Parse(thicknessValue.Text);
                        pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                        g.TranslateTransform(-CANVAS_OFFSET, -CANVAS_OFFSET);
                        g.DrawLine(pen, posX, posY, posFX, posFY);
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
                        if (posFX >= posX && posFY >= posY)
                        {
                            g.TranslateTransform(-CANVAS_OFFSET, -CANVAS_OFFSET);
                            drawFigureAction(pen, new Rectangle(posX, posY, posFX - posX, posFY - posY));
                        }
                        else if (posFX >= posX && posFY < posY)
                        {
                            g.TranslateTransform(-CANVAS_OFFSET, canvas.Height - CANVAS_OFFSET);
                            g.ScaleTransform(1, -1);
                            drawFigureAction(pen, new Rectangle(posX, canvas.Height - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            g.TranslateTransform(canvas.Width - CANVAS_OFFSET, -CANVAS_OFFSET);
                            g.ScaleTransform(-1, 1);
                            drawFigureAction(pen, new Rectangle(canvas.Width - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            g.TranslateTransform(canvas.Width - CANVAS_OFFSET, canvas.Height - CANVAS_OFFSET);
                            g.ScaleTransform(-1, -1);
                            drawFigureAction(pen, new Rectangle(canvas.Width - posX, canvas.Height - posY, posX - posFX, posY - posFY));
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
                        if (posFX >= posX && posFY >= posY)
                        {
                            g.TranslateTransform(-CANVAS_OFFSET, -CANVAS_OFFSET);
                            fillFigureAction(brush, new Rectangle(posX, posY, posFX - posX, posFY - posY));
                        }
                        else if (posFX >= posX && posFY < posY)
                        {
                            g.TranslateTransform(-CANVAS_OFFSET, canvas.Height - CANVAS_OFFSET);
                            g.ScaleTransform(1, -1);
                            fillFigureAction(brush, new Rectangle(posX, canvas.Height - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            g.TranslateTransform(canvas.Width - CANVAS_OFFSET, -CANVAS_OFFSET);
                            g.ScaleTransform(-1, 1);
                            fillFigureAction(brush, new Rectangle(canvas.Width - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            g.TranslateTransform(canvas.Width - CANVAS_OFFSET, canvas.Height - CANVAS_OFFSET);
                            g.ScaleTransform(-1, -1);
                            fillFigureAction(brush, new Rectangle(canvas.Width - posX, canvas.Height - posY, posX - posFX, posY - posFY));
                        }
                    }
                }
            }
            return true;
        }
    }
}
