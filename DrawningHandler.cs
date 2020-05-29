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
                posX = e.X - layer.AutoScrollPosition.X;
                posY = e.Y - layer.AutoScrollPosition.Y;
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
            posFX = e.X - layer.AutoScrollPosition.X;
            posFY = e.Y - layer.AutoScrollPosition.Y;
            isCanvasArea = (e.X >= CANVAS_OFFSET + layer.AutoScrollPosition.X && e.X <= layer.CanvasWidth + CANVAS_OFFSET + layer.AutoScrollPosition.X
                && e.Y >= CANVAS_OFFSET + layer.AutoScrollPosition.Y && e.Y <= layer.CanvasHeight + CANVAS_OFFSET + layer.AutoScrollPosition.Y) ? true : false;
            if (isCanvasArea)
            {
                var xl = e.X - CANVAS_OFFSET - layer.AutoScrollPosition.X;
                var yl = e.Y - CANVAS_OFFSET - layer.AutoScrollPosition.Y;
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
                    using (var g = Graphics.FromImage(layer.Image))
                    {
                        using (var pen = drawningMode == DrawningMode.Eraser ? new Pen(Color.White) :
                            isMainColorActivated ? new Pen(color0) : new Pen(color1))
                        {
                            pen.Width = float.Parse(thicknessValue.Text);
                            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                            g.DrawLine(pen, posX - CANVAS_OFFSET, posY - CANVAS_OFFSET,
                                e.X - CANVAS_OFFSET - layer.AutoScrollPosition.X, e.Y - CANVAS_OFFSET - layer.AutoScrollPosition.Y);
                            posX = e.X - layer.AutoScrollPosition.X;
                            posY = e.Y - layer.AutoScrollPosition.Y;
                        }
                    }
                }
                layer.Invalidate();
            }
        }

        private void Layer_Paint(object sender, PaintEventArgs e)
        {
            layerSizeLabel.Text = "   " + layer.CanvasWidth + " x " + layer.CanvasHeight + "px";
            sSizePoint.Location = new Point(layer.CanvasWidth / 2 - 3 + CANVAS_OFFSET + layer.AutoScrollPosition.X,
                layer.CanvasHeight + CANVAS_OFFSET + layer.AutoScrollPosition.Y);
            eSizePoint.Location = new Point(layer.CanvasWidth + CANVAS_OFFSET + layer.AutoScrollPosition.X,
                layer.CanvasHeight / 2 - 3 + CANVAS_OFFSET + layer.AutoScrollPosition.Y);
            seSizePoint.Location = new Point(layer.CanvasWidth + CANVAS_OFFSET + layer.AutoScrollPosition.X,
                layer.CanvasHeight + CANVAS_OFFSET + layer.AutoScrollPosition.Y);
            if (operation == Operation.Resize)
            {
                using (var pen = new Pen(Color.Gray, 1f))
                {
                    pen.DashStyle = DashStyle.Dash;
                    if (sSizePointInvoked)
                        e.Graphics.DrawRectangle(pen, new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET, layer.CanvasWidth, layer.CanvasHeight + resizeDY));
                    else if (eSizePointInvoked)
                        e.Graphics.DrawRectangle(pen, new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET, layer.CanvasWidth + resizeDX, layer.CanvasHeight));
                    else
                        e.Graphics.DrawRectangle(pen, new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET,
                            layer.CanvasWidth + resizeDX, layer.CanvasHeight + resizeDY));
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
            using (var r = new Region(new Rectangle(CANVAS_OFFSET, CANVAS_OFFSET, layer.CanvasWidth, layer.CanvasHeight)))
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
                            e.Graphics.TranslateTransform(0, layer.CanvasHeight);
                            e.Graphics.ScaleTransform(1, -1);
                            drawFigureAction(pen, new Rectangle(posX, layer.CanvasHeight - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            e.Graphics.TranslateTransform(layer.CanvasWidth, 0);
                            e.Graphics.ScaleTransform(-1, 1);
                            drawFigureAction(pen, new Rectangle(layer.CanvasWidth - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            e.Graphics.TranslateTransform(layer.CanvasWidth, layer.CanvasHeight);
                            e.Graphics.ScaleTransform(-1, -1);
                            drawFigureAction(pen, new Rectangle(layer.CanvasWidth - posX, layer.CanvasHeight - posY, posX - posFX, posY - posFY));
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
                            e.Graphics.TranslateTransform(0, layer.CanvasHeight);
                            e.Graphics.ScaleTransform(1, -1);
                            fillFigureAction(brush, new Rectangle(posX, layer.CanvasHeight - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            e.Graphics.TranslateTransform(layer.CanvasWidth, 0);
                            e.Graphics.ScaleTransform(-1, 1);
                            fillFigureAction(brush, new Rectangle(layer.CanvasWidth - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            e.Graphics.TranslateTransform(layer.CanvasWidth, layer.CanvasHeight);
                            e.Graphics.ScaleTransform(-1, -1);
                            fillFigureAction(brush, new Rectangle(layer.CanvasWidth - posX, layer.CanvasHeight - posY, posX - posFX, posY - posFY));
                        }
                    }
                }
            }
            return true;
        }

        private bool SaveFigure()
        {
            using (var g = Graphics.FromImage(layer.Image))
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
                            g.TranslateTransform(-CANVAS_OFFSET, layer.CanvasHeight - CANVAS_OFFSET);
                            g.ScaleTransform(1, -1);
                            drawFigureAction(pen, new Rectangle(posX, layer.CanvasHeight - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            g.TranslateTransform(layer.CanvasWidth - CANVAS_OFFSET, -CANVAS_OFFSET);
                            g.ScaleTransform(-1, 1);
                            drawFigureAction(pen, new Rectangle(layer.CanvasWidth - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            g.TranslateTransform(layer.CanvasWidth - CANVAS_OFFSET, layer.CanvasHeight - CANVAS_OFFSET);
                            g.ScaleTransform(-1, -1);
                            drawFigureAction(pen, new Rectangle(layer.CanvasWidth - posX, layer.CanvasHeight - posY, posX - posFX, posY - posFY));
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
                            g.TranslateTransform(-CANVAS_OFFSET, layer.CanvasHeight - CANVAS_OFFSET);
                            g.ScaleTransform(1, -1);
                            fillFigureAction(brush, new Rectangle(posX, layer.CanvasHeight - posY, posFX - posX, posY - posFY));
                        }
                        else if (posFX < posX && posFY >= posY)
                        {
                            g.TranslateTransform(layer.CanvasWidth - CANVAS_OFFSET, -CANVAS_OFFSET);
                            g.ScaleTransform(-1, 1);
                            fillFigureAction(brush, new Rectangle(layer.CanvasWidth - posX, posY, posX - posFX, posFY - posY));
                        }
                        else
                        {
                            g.TranslateTransform(layer.CanvasWidth - CANVAS_OFFSET, layer.CanvasHeight - CANVAS_OFFSET);
                            g.ScaleTransform(-1, -1);
                            fillFigureAction(brush, new Rectangle(layer.CanvasWidth - posX, layer.CanvasHeight - posY, posX - posFX, posY - posFY));
                        }
                    }
                }
            }
            return true;
        }
    }
}