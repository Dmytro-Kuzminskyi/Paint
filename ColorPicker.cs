using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Paint
{
    public partial class MainForm
    {
        private bool isMainColorActivated = true;
        private Color color0 = Color.Black;
        private Color color1 = Color.White;

        private void SetColorButton(ToolStripButton btn, Color c)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var tmp = new Bitmap(16, 16))
                {
                    using (var graphics = Graphics.FromImage(tmp))
                    {
                        graphics.Clear(c);
                        using (var p = new Pen(Color.Black, 1f))
                        {
                            graphics.DrawLines(p, new[] { new Point(0, 0), new Point(15, 0), new Point(15, 15), 
                                new Point(0, 15), new Point(0, 0) });
                        }
                        tmp.Save(memoryStream, ImageFormat.Bmp);
                        btn.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var s = sender as ToolStripButton;
            if (s.Tag.ToString() == 0.ToString())
            {
                s.BackColor = Color.LightBlue;
                color1Button.BackColor = SystemColors.Window;
                isMainColorActivated = true;
            } 
            else
            {
                s.BackColor = Color.LightBlue;
                color0Button.BackColor = SystemColors.Window;
                isMainColorActivated = false;
            }
        }

        private void PickColorButton_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                DialogResult result = cd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (isMainColorActivated)
                    {
                        color0 = cd.Color;
                        SetColorButton(color0Button, color0);
                    }
                    else
                    {
                        color1 = cd.Color;
                        SetColorButton(color1Button, color1);
                    }
                }
            }
        }
    }
}
