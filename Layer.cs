using System.Windows.Forms;
using System.Drawing;
using Paint.Properties;
using System.Drawing.Drawing2D;

namespace Paint
{
    public class Layer : Panel
    {
        private Image mImage;
        public int CanvasWidth { get; set; }
        public int CanvasHeight { get; set; }
        public Layer(int width, int height)
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            AutoScroll = true;
            CanvasWidth = width;
            CanvasHeight = height;
            mImage = new Bitmap(Resources.canvas, new Size(width, height));
        }

        public Image Image
        {
            get { return mImage; }
            set
            {
                mImage = value;
                if (value == null) 
                {
                    CanvasWidth = 0;
                    CanvasHeight = 0;
                    AutoScrollMinSize = new Size(0, 0); 
                }
                else
                {
                    var size = value.Size;
                    CanvasWidth = size.Width;
                    CanvasHeight = size.Height;
                    using (var g = CreateGraphics())
                    {
                        size.Width = (int)(size.Width * g.DpiX / value.HorizontalResolution);
                        size.Height = (int)(size.Height * g.DpiY / value.VerticalResolution);
                    }
                    AutoScrollMinSize = size;
                }
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
            if (mImage != null) e.Graphics.DrawImage(mImage, MainForm.CANVAS_OFFSET, MainForm.CANVAS_OFFSET);
            base.OnPaint(e);
        }

        public void UpdateImage()
        {
            var b = new Bitmap(Resources.canvas, CanvasWidth, CanvasHeight);
            using (var g = Graphics.FromImage(b))
            {
                g.DrawImage(mImage, 0, 0);
                mImage = b;
            }
        }

        public void ResizeImage(Size size)
        {

            int sourceWidth = mImage.Width;
            int sourceHeight = mImage.Height;
            float nPercent, nPercentW, nPercentH;

            nPercentW = (float)size.Width / (float)sourceWidth;
            nPercentH = (float)size.Height / (float)sourceHeight;

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            using (var g = Graphics.FromImage(b))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(mImage, 0, 0, destWidth, destHeight);
            }
            Image = b;
        }
    }
}
