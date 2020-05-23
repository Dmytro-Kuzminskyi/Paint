using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    class ImageProcessor
    {
        private static Bitmap DrawControlToBitmap(Control c)
        {
            var bitmap = new Bitmap(c.Width, c.Height);
            var graphics = Graphics.FromImage(bitmap);
            var rect = c.RectangleToScreen(c.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, c.Size);
            return bitmap;
        }

        public static void SaveImage(PictureBox canvas, string mimeType, string filePath)
        {
            using (var encParams = new EncoderParameters(1))
            {
                var bmpTemp = DrawControlToBitmap(canvas);
                var info = ImageCodecInfo.GetImageEncoders().Where(codecInfo => codecInfo.MimeType == mimeType).First();
                encParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)100);
                bmpTemp.Save(filePath, info, encParams);
            }
        }
    }
}
