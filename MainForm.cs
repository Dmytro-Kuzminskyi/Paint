﻿using Paint.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private PictureBox sSizePoint, eSizePoint, seSizePoint;
        private Graphics freeRoamGraphics;
        private Graphics segmentGraphics;
        private Image img;
        private Pen pen;

        public MainForm()
        {
            InitializeComponent();
            img = new Bitmap(128, 128);
            freeRoamGraphics = canvas.CreateGraphics();
            freeRoamGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            InitializePen(color0, float.Parse(thicknessValue.Text));
            SetColorButton(color0Button, color0);
            SetColorButton(color1Button, color1);
            color0Button.BackColor = Color.LightBlue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = Resources.BASE_HEADER;
            int xOffset = canvas.Location.X;
            int yOffset = canvas.Location.Y;
            sSizePoint = new PictureBox();
            ((ISupportInitialize)(sSizePoint)).BeginInit();
            sSizePoint.BackColor = SystemColors.Window;
            sSizePoint.BorderStyle = BorderStyle.FixedSingle;
            sSizePoint.Location = new Point(canvas.Width / 2 - 3 + xOffset, canvas.Height + yOffset);
            sSizePoint.Name = "sSizePoint";
            sSizePoint.Size = new Size(6, 6);
            sSizePoint.MouseEnter += new EventHandler(SizePoint_MouseEnter);
            sSizePoint.MouseLeave += new EventHandler(SizePoint_MouseLeave);
            sSizePoint.MouseDown += new MouseEventHandler(SizePoint_MouseDown);
            sSizePoint.MouseUp += new MouseEventHandler(SizePoint_MouseUp);
            sSizePoint.MouseMove += new MouseEventHandler(SizePoint_MouseMove);
            Controls.Add(sSizePoint);
            ((ISupportInitialize)(sSizePoint)).EndInit();
            sSizePoint.BringToFront();
            eSizePoint = new PictureBox();
            ((ISupportInitialize)(eSizePoint)).BeginInit();
            eSizePoint.BackColor = SystemColors.Window;
            eSizePoint.BorderStyle = BorderStyle.FixedSingle;
            eSizePoint.Location = new Point(canvas.Width + xOffset, canvas.Height / 2 - 3 + yOffset);
            eSizePoint.Name = "eSizePoint";
            eSizePoint.Size = new Size(6, 6);
            eSizePoint.MouseEnter += new EventHandler(SizePoint_MouseEnter);
            eSizePoint.MouseLeave += new EventHandler(SizePoint_MouseLeave);
            eSizePoint.MouseDown += new MouseEventHandler(SizePoint_MouseDown);
            eSizePoint.MouseUp += new MouseEventHandler(SizePoint_MouseUp);
            eSizePoint.MouseMove += new MouseEventHandler(SizePoint_MouseMove);
            Controls.Add(eSizePoint);
            ((ISupportInitialize)(eSizePoint)).EndInit();
            eSizePoint.BringToFront();
            seSizePoint = new PictureBox();
            ((ISupportInitialize)(seSizePoint)).BeginInit();
            seSizePoint.BackColor = SystemColors.Window;
            seSizePoint.BorderStyle = BorderStyle.FixedSingle;
            seSizePoint.Location = new Point(canvas.Width + xOffset, canvas.Height + yOffset);
            seSizePoint.Name = "seSizePoint";
            seSizePoint.Size = new Size(6, 6);
            seSizePoint.MouseEnter += new EventHandler(SizePoint_MouseEnter);
            seSizePoint.MouseLeave += new EventHandler(SizePoint_MouseLeave);
            seSizePoint.MouseDown += new MouseEventHandler(SizePoint_MouseDown);
            seSizePoint.MouseUp += new MouseEventHandler(SizePoint_MouseUp);
            seSizePoint.MouseMove += new MouseEventHandler(SizePoint_MouseMove);
            Controls.Add(seSizePoint);
            ((ISupportInitialize)(seSizePoint)).EndInit();
            seSizePoint.BringToFront();
            if (img == null)
                img = new Bitmap(128, 128);
            canvas.Size = img.Size;
            freeRoamGraphics = canvas.CreateGraphics();
            freeRoamGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (drawningMode != DrawningMode.Free)
            {
                segmentGraphics = canvas.CreateGraphics();
                segmentGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            }
            imagePainted = false;
            isMainColorActivated = true;
            color0 = Color.Black;
            color1 = Color.White;
            SetColorButton(color0Button, color0);
            SetColorButton(color1Button, color1);
            InitializePen(color0, float.Parse(thicknessValue.Text));
        }

        private void InitializePen(Color color, float width)
        {
            if (pen != null)
                pen.Dispose();
            pen = new Pen(color);
            pen.Width = width;
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void Thickness_Click(object sender, EventArgs e)
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
            if (isMainColorActivated)
                InitializePen(color0, float.Parse(thicknessValue.Text));
            else
                InitializePen(color1, float.Parse(thicknessValue.Text));
        }
    }
}
