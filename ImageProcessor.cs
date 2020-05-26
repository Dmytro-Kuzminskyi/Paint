using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Paint
{
    class ImageProcessor
    {
        [DllImport("user32.dll")]
        private static extern IntPtr LoadCursorFromFile(string fileName);

        public static Cursor ActuallyLoadCursor(string path)
        {
            return new Cursor(LoadCursorFromFile(path));
        }

        public static void SaveImage(Bitmap img, string mimeType, string filePath)
        {
            using (var encParams = new EncoderParameters(1))
            {
                var b = new Bitmap(img);
                var info = ImageCodecInfo.GetImageEncoders().Where(codecInfo => codecInfo.MimeType == mimeType).First();
                encParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)100);
                b.Save(filePath, info, encParams);
            }
        }
    }
}
