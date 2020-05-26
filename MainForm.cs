using Paint.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Paint
{
    public partial class MainForm : Form
    {
        public const int CANVAS_OFFSET = 16;
        private Operation operation;
        private DrawningMode drawningMode;
        private PictureBox sSizePoint, eSizePoint, seSizePoint;
        private Canvas canvas;
        private Layer layer;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private const int WM_SETREDRAW = 0xB;

        private enum Operation
        {
            None,
            Resize,
            Drawning
        }

        public MainForm()
        {
            canvas = new Canvas(128, 128);           
            layer = new Layer();
            layer.Name = "layer";
            layer.Dock = DockStyle.Fill;
            layer.AutoScroll = true;
            layer.Paint += new PaintEventHandler(Layer_Paint);
            layer.MouseUp += new MouseEventHandler(Layer_MouseUp);
            layer.MouseDown += new MouseEventHandler(Layer_MouseDown);
            layer.MouseMove += new MouseEventHandler(Layer_MouseMove);
            layer.Scroll += new ScrollEventHandler(Layer_Scroll);
            Controls.Add(layer);
            InitializeComponent();
            SetColorButton(color0Button, color0);
            SetColorButton(color1Button, color1);
            color0Button.BackColor = Color.LightBlue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            layerSizeLabel.Text = canvas.Width + " x " + canvas.Height + "px";
            Text = Resources.BASE_HEADER;
            sSizePoint = new PictureBox();
            ((ISupportInitialize)(sSizePoint)).BeginInit();
            sSizePoint.BackColor = SystemColors.Window;
            sSizePoint.BorderStyle = BorderStyle.FixedSingle;
            sSizePoint.Location = new Point(canvas.Width / 2 - 3 + CANVAS_OFFSET, canvas.Height + CANVAS_OFFSET);
            sSizePoint.Name = "sSizePoint";
            sSizePoint.Size = new Size(6, 6);
            sSizePoint.MouseEnter += new EventHandler(SizePoint_MouseEnter);
            sSizePoint.MouseLeave += new EventHandler(SizePoint_MouseLeave);
            sSizePoint.MouseDown += new MouseEventHandler(SizePoint_MouseDown);
            sSizePoint.MouseUp += new MouseEventHandler(SizePoint_MouseUp);
            sSizePoint.MouseMove += new MouseEventHandler(SizePoint_MouseMove);
            layer.Controls.Add(sSizePoint);
            ((ISupportInitialize)(sSizePoint)).EndInit();
            sSizePoint.BringToFront();
            eSizePoint = new PictureBox();
            ((ISupportInitialize)(eSizePoint)).BeginInit();
            eSizePoint.BackColor = SystemColors.Window;
            eSizePoint.BorderStyle = BorderStyle.FixedSingle;
            eSizePoint.Location = new Point(canvas.Width + CANVAS_OFFSET, canvas.Height / 2 - 3 + CANVAS_OFFSET);
            eSizePoint.Name = "eSizePoint";
            eSizePoint.Size = new Size(6, 6);
            eSizePoint.MouseEnter += new EventHandler(SizePoint_MouseEnter);
            eSizePoint.MouseLeave += new EventHandler(SizePoint_MouseLeave);
            eSizePoint.MouseDown += new MouseEventHandler(SizePoint_MouseDown);
            eSizePoint.MouseUp += new MouseEventHandler(SizePoint_MouseUp);
            eSizePoint.MouseMove += new MouseEventHandler(SizePoint_MouseMove);
            layer.Controls.Add(eSizePoint);
            ((ISupportInitialize)(eSizePoint)).EndInit();
            eSizePoint.BringToFront();
            seSizePoint = new PictureBox();
            ((ISupportInitialize)(seSizePoint)).BeginInit();
            seSizePoint.BackColor = SystemColors.Window;
            seSizePoint.BorderStyle = BorderStyle.FixedSingle;
            seSizePoint.Location = new Point(canvas.Width + CANVAS_OFFSET, canvas.Height + CANVAS_OFFSET);
            seSizePoint.Name = "seSizePoint";
            seSizePoint.Size = new Size(6, 6);
            seSizePoint.MouseEnter += new EventHandler(SizePoint_MouseEnter);
            seSizePoint.MouseLeave += new EventHandler(SizePoint_MouseLeave);
            seSizePoint.MouseDown += new MouseEventHandler(SizePoint_MouseDown);
            seSizePoint.MouseUp += new MouseEventHandler(SizePoint_MouseUp);
            seSizePoint.MouseMove += new MouseEventHandler(SizePoint_MouseMove);
            layer.Controls.Add(seSizePoint);
            ((ISupportInitialize)(seSizePoint)).EndInit();
            seSizePoint.BringToFront();
            isMainColorActivated = true;
            color0 = Color.Black;
            color1 = Color.White;
            SetColorButton(color0Button, color0);
            SetColorButton(color1Button, color1);
            color0Button.BackColor = Color.LightBlue;
            color1Button.BackColor = SystemColors.Window;
            drawLineButton.BackColor = SystemColors.Window;
            drawRectangleButton.BackColor = SystemColors.Window;
            drawFilledRectangleButton.BackColor = SystemColors.Window;
            drawEllipseButton.BackColor = SystemColors.Window;
            drawFilledEllipseButton.BackColor = SystemColors.Window;
            drawningMode = DrawningMode.Free;
            operation = Operation.None;
        }

        private void Layer_Scroll(object sender, ScrollEventArgs e)
        {
            Control s = sender as Control;
            if (e.Type == ScrollEventType.ThumbTrack)
            {
                SendMessage(s.Handle, WM_SETREDRAW, 1, 0);
                s.Refresh();                        
                SendMessage(s.Handle, WM_SETREDRAW, 0, 0);
            }
            else
            {
                SendMessage(s.Handle, WM_SETREDRAW, 1, 0);
                s.Invalidate();
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {/*
            using (var resizeDialog = new ResizeForm(canvas.Image.Width, canvas.Image.Height))
            {
                var result = resizeDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var width = resizeDialog.OutputWidth;
                    var height = resizeDialog.OutputHeight;
                    if (canvas.Width != width || canvas.Height != height)
                    {
                        canvas.Width = width;
                        canvas.Height = height;
                        canvas.Image = new Bitmap(canvas.Image, new Size(canvas.Width, canvas.Height));
                    }
                }
            }*/
        }

        private void ThicknessButton_Click(object sender, EventArgs e)
        {
            thickness0.Checked = false;
            thickness0.CheckState = CheckState.Unchecked;
            thickness1.Checked = false;
            thickness1.CheckState = CheckState.Unchecked;
            thickness2.Checked = false;
            thickness2.CheckState = CheckState.Unchecked;
            thickness3.Checked = false;
            thickness3.CheckState = CheckState.Unchecked;
            var s = sender as ToolStripMenuItem;
            s.Checked = true;
            s.CheckState = CheckState.Checked;
            thicknessValue.Text = s.Text;
        }

        private void RotationButton_Click(object sender, EventArgs e)
        {
            var s = sender as ToolStripMenuItem;
            if (s == rotateRightButton)
            {
                
                var width = canvas.Width;
                canvas.Width = canvas.Height;
                canvas.Height = width;
                canvas.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            } 
            else if (s == rotateLeftButton)
            {
                var width = canvas.Width;
                canvas.Width = canvas.Height;
                canvas.Height = width;
                canvas.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (s == flipHorizontalButton)
                canvas.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            else if (s == flipVerticalButton)
                canvas.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            layer.Invalidate();
        }
    }
}
