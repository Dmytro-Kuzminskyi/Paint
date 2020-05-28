using Paint.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        public const int CANVAS_OFFSET = 16;
        private Operation operation;
        private DrawningMode drawningMode;
        private PictureBox sSizePoint, eSizePoint, seSizePoint;
        private Layer layer;

        private enum Operation
        {
            None,
            Resize,
            Drawning
        }

        public MainForm()
        {        
            layer = new Layer(128, 128);
            layer.Name = "layer";
            layer.Dock = DockStyle.Fill;
            layer.AutoScroll = true;
            layer.Paint += new PaintEventHandler(Layer_Paint);
            layer.MouseUp += new MouseEventHandler(Layer_MouseUp);
            layer.MouseDown += new MouseEventHandler(Layer_MouseDown);
            layer.MouseMove += new MouseEventHandler(Layer_MouseMove);
            Controls.Add(layer);
            InitializeComponent();
            SetColorButton(color0Button, color0);
            SetColorButton(color1Button, color1);
            color0Button.BackColor = Color.LightBlue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            layerSizeLabel.Text = layer.CanvasWidth + " x " + layer.CanvasHeight + "px";
            Text = Resources.BASE_HEADER;
            sSizePoint = new PictureBox();
            ((ISupportInitialize)(sSizePoint)).BeginInit();
            sSizePoint.BackColor = SystemColors.Window;
            sSizePoint.BorderStyle = BorderStyle.FixedSingle;
            sSizePoint.Location = new Point(layer.CanvasWidth / 2 - 3 + CANVAS_OFFSET, layer.CanvasHeight + CANVAS_OFFSET);
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
            eSizePoint.Location = new Point(layer.CanvasWidth + CANVAS_OFFSET, layer.CanvasHeight / 2 - 3 + CANVAS_OFFSET);
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
            seSizePoint.Location = new Point(layer.CanvasWidth + CANVAS_OFFSET, layer.CanvasHeight + CANVAS_OFFSET);
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

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            using (var resizeDialog = new ResizeForm(layer.Image.Width, layer.Image.Height))
            {
                var result = resizeDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var width = resizeDialog.OutputWidth;
                    var height = resizeDialog.OutputHeight;
                    if (layer.CanvasWidth != width || layer.CanvasHeight != height)
                        layer.ResizeImage(new Size(width, height));
                }
            }
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
                var width = layer.CanvasWidth;
                layer.CanvasWidth = layer.CanvasHeight;
                layer.CanvasHeight = width;
                layer.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            } 
            else if (s == rotateLeftButton)
            {
                var width = layer.CanvasWidth;
                layer.CanvasWidth = layer.CanvasHeight;
                layer.CanvasHeight = width;
                layer.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (s == flipHorizontalButton)
                layer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            else if (s == flipVerticalButton)
                layer.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            layer.Invalidate();
        }
    }
}
