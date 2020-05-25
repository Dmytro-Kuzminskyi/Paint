using System;
using Paint.Properties;
using System.Drawing;


namespace Paint
{
    class Canvas : IDisposable
    {
        public int Width {get; set; }
        public int Height { get; set; }
        public Bitmap Image { get; set; }

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
            Image = Resources.canvas;
        }

        public Canvas(int width, int height, Bitmap img)
        {
            Width = width;
            Height = height;
            Image = img;
        }

        public void UpdateImage()
        {
            var b = new Bitmap(Resources.canvas, Width, Height);
            using (var g = Graphics.FromImage(b))
            {
                g.DrawImage(Image, 0, 0);
                Image = b;
            }
        }
        public void Dispose()
        {
            if (Image != null)
                Image.Dispose();
        }
    }
}
