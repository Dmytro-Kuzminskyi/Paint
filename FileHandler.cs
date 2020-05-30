using Paint.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm
    {
        private string filePath, fileName, extension;

        private void AboutButton_Click(object sender, EventArgs e)
        {
            using (var aboutWindow = new AboutWindow())
                aboutWindow.ShowDialog();
        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            filePath = fileName = extension = null;
            Controls.Remove(sSizePoint);
            Controls.Remove(eSizePoint);
            Controls.Remove(seSizePoint);
            sSizePoint.Dispose();
            eSizePoint.Dispose();
            seSizePoint.Dispose();
            layer.Image = new Bitmap(Resources.canvas, 128, 128);
            OnLoad(null);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                ofd.RestoreDirectory = true;
                ofd.Filter = "Bitmap Files|*.bmp;*.dib|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|GIF|*.gif|TIFF|*.tif;*.tiff|" +
                    "PNG|*.png|ICO|*.ico|All Picture Files|*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;" +
                    "*.png;*.ico|All Files|*.*";
                ofd.FilterIndex = 7;
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                var result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Controls.Remove(sSizePoint);
                    Controls.Remove(eSizePoint);
                    Controls.Remove(seSizePoint);
                    sSizePoint.Dispose();
                    eSizePoint.Dispose();
                    seSizePoint.Dispose();
                    var bmpTemp = (Bitmap)Image.FromFile(ofd.FileName);
                    layer.Image = new Bitmap(bmpTemp);
                    OnLoad(null);
                    filePath = ofd.FileName;
                    fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                    extension = Path.GetExtension(ofd.FileName);
                    Text = fileName + " - Paint";
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Text == Resources.BASE_HEADER)
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                    sfd.RestoreDirectory = true;
                    sfd.CheckPathExists = true;
                    sfd.AddExtension = true;
                    sfd.DefaultExt = "bmp";
                    sfd.Filter = "Bitmap Files|*.bmp;*.dib|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|GIF|*.gif|" +
                        "TIFF|*.tif;*.tiff|PNG|*.png|ICO|*.ico";
                    var result = sfd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        filePath = sfd.FileName;
                        fileName = Path.GetFileNameWithoutExtension(sfd.FileName);
                        extension = Path.GetExtension(sfd.FileName);
                        if (extension == ".bmp" || extension == ".dib")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/bmp", sfd.FileName);
                        else if (extension == ".jpg" || extension == ".jpeg" || extension == ".jpe")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/jpeg", sfd.FileName);
                        else if (extension == ".jfif")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/pjpeg", sfd.FileName);
                        else if (extension == ".gif")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/gif", sfd.FileName);
                        else if (extension == ".tif" || extension == ".tiff")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/tiff", sfd.FileName);
                        else if (extension == ".png")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/png", sfd.FileName);
                        else if (extension == ".ico")
                            ImageProcessor.SaveImage((Bitmap)layer.Image, "image/x-icon", sfd.FileName);
                        Text = fileName + " - Paint";
                    }
                }
            }
            else
            {
                if (extension == ".bmp" || extension == ".dib")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/bmp", filePath);
                else if (extension == ".jpg" || extension == ".jpeg" || extension == ".jpe")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/jpeg", filePath);
                else if (extension == ".jfif")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/pjpeg", filePath);
                else if (extension == ".gif")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/gif", filePath);
                else if (extension == ".tif" || extension == ".tiff")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/tiff", filePath);
                else if (extension == ".png")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/png", filePath);
                else if (extension == ".ico")
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/x-icon", filePath);
                else
                    ImageProcessor.SaveImage((Bitmap)layer.Image, "image/bmp", filePath);
            }
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                sfd.RestoreDirectory = true;
                sfd.CheckPathExists = true;
                sfd.AddExtension = true;
                sfd.DefaultExt = "bmp";
                sfd.Filter = "Bitmap Files|*.bmp;*.dib|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|GIF|*.gif|" +
                    "TIFF|*.tif;*.tiff|PNG|*.png|ICO|*.ico";
                var result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filePath = sfd.FileName;
                    fileName = Path.GetFileNameWithoutExtension(sfd.FileName);
                    extension = Path.GetExtension(sfd.FileName);
                    if (extension == ".bmp" || extension == ".dib")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/bmp", sfd.FileName);
                    else if (extension == ".jpg" || extension == ".jpeg" || extension == ".jpe")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/jpeg", sfd.FileName);
                    else if (extension == ".jfif")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/pjpeg", sfd.FileName);
                    else if (extension == ".gif")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/gif", sfd.FileName);
                    else if (extension == ".tif" || extension == ".tiff")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/tiff", sfd.FileName);
                    else if (extension == ".png")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/png", sfd.FileName);
                    else if (extension == ".ico")
                        ImageProcessor.SaveImage((Bitmap)layer.Image, "image/x-icon", sfd.FileName);
                    Text = fileName + " - Paint";
                }
            }
        }
    }
}
