using System;
using Paint.Properties;
using System.Drawing;
using System.Windows.Forms;

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
            Image = new Bitmap(Resources.canvas, new Size(width, height));
        }

        public Canvas(Bitmap img)
        {
            Width = img.Width;
            Height = img.Height;
            Image = img;
        }
        public void UpdateImage()
        {
            var b =  new Bitmap(Resources.canvas, Width, Height);
            using (var g = Graphics.FromImage(b))
            {
                g.DrawImage(Image, 0, 0);
                Dispose();
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
