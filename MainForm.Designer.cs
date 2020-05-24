namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.canvasCoordinateLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.thicknessLabel = new System.Windows.Forms.ToolStripLabel();
            this.thicknessValue = new System.Windows.Forms.ToolStripDropDownButton();
            this.thickness0 = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.color0Button = new System.Windows.Forms.ToolStripButton();
            this.color1Button = new System.Windows.Forms.ToolStripButton();
            this.pickColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.drawLineButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawFilledRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawFilledEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canvasCoordinateLabel,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 425);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // canvasCoordinateLabel
            // 
            this.canvasCoordinateLabel.AutoSize = false;
            this.canvasCoordinateLabel.Image = global::Paint.Properties.Resources.icons8_move_64;
            this.canvasCoordinateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.canvasCoordinateLabel.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.canvasCoordinateLabel.Name = "canvasCoordinateLabel";
            this.canvasCoordinateLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.canvasCoordinateLabel.Size = new System.Drawing.Size(100, 22);
            this.canvasCoordinateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Location = new System.Drawing.Point(0, 41);
            this.canvas.Margin = new System.Windows.Forms.Padding(1);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(128, 128);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.SizeChanged += new System.EventHandler(this.Canvas_SizeChanged);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.canvas.MouseEnter += new System.EventHandler(this.Canvas_MouseEnter);
            this.canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.toolStripSeparator2,
            this.resizeButton,
            this.toolStripSeparator4,
            this.rotateButton,
            this.toolStripSeparator5,
            this.thicknessLabel,
            this.thicknessValue,
            this.toolStripSeparator6,
            this.color0Button,
            this.color1Button,
            this.pickColorButton,
            this.toolStripSeparator7,
            this.drawLineButton,
            this.drawRectangleButton,
            this.drawFilledRectangleButton,
            this.drawEllipseButton,
            this.drawFilledEllipseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileButton
            // 
            this.fileButton.AutoToolTip = false;
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.saveAsButton});
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(38, 37);
            this.fileButton.Text = "File";
            // 
            // newButton
            // 
            this.newButton.Image = global::Paint.Properties.Resources.icons8_add_file_50;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(112, 22);
            this.newButton.Text = "New";
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // openButton
            // 
            this.openButton.Image = global::Paint.Properties.Resources.icons8_file_50;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(112, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::Paint.Properties.Resources.icons8_save_50;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = global::Paint.Properties.Resources.icons8_save_as_50;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(112, 22);
            this.saveAsButton.Text = "Save as";
            this.saveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // resizeButton
            // 
            this.resizeButton.AutoToolTip = false;
            this.resizeButton.Image = global::Paint.Properties.Resources.icons8_resize_file_64;
            this.resizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(59, 37);
            this.resizeButton.Text = "Resize";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // rotateButton
            // 
            this.rotateButton.AutoToolTip = false;
            this.rotateButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateRightButton,
            this.rotateLeftButton,
            this.flipVerticalButton,
            this.flipHorizontalButton});
            this.rotateButton.Image = global::Paint.Properties.Resources.icons8_rotate_50;
            this.rotateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(70, 37);
            this.rotateButton.Text = "Rotate";
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Image = global::Paint.Properties.Resources.icons8_rotate_right_50;
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(180, 22);
            this.rotateRightButton.Text = "Rotate right 90°";
            this.rotateRightButton.Click += new System.EventHandler(this.RotationButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Image = global::Paint.Properties.Resources.icons8_rotate_left_50;
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(180, 22);
            this.rotateLeftButton.Text = "Rotate left 90°";
            this.rotateLeftButton.Click += new System.EventHandler(this.RotationButton_Click);
            // 
            // flipVerticalButton
            // 
            this.flipVerticalButton.Image = global::Paint.Properties.Resources.icons8_flip_vertical_50;
            this.flipVerticalButton.Name = "flipVerticalButton";
            this.flipVerticalButton.Size = new System.Drawing.Size(180, 22);
            this.flipVerticalButton.Text = "Flip vertical";
            this.flipVerticalButton.Click += new System.EventHandler(this.RotationButton_Click);
            // 
            // flipHorizontalButton
            // 
            this.flipHorizontalButton.Image = global::Paint.Properties.Resources.icons8_flip_horizontal_50;
            this.flipHorizontalButton.Name = "flipHorizontalButton";
            this.flipHorizontalButton.Size = new System.Drawing.Size(180, 22);
            this.flipHorizontalButton.Text = "Flip horizontal";
            this.flipHorizontalButton.Click += new System.EventHandler(this.RotationButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(61, 37);
            this.thicknessLabel.Text = "Thickness:";
            // 
            // thicknessValue
            // 
            this.thicknessValue.AutoToolTip = false;
            this.thicknessValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.thicknessValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thickness0,
            this.thickness1,
            this.thickness2,
            this.thickness3});
            this.thicknessValue.Image = ((System.Drawing.Image)(resources.GetObject("thicknessValue.Image")));
            this.thicknessValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.thicknessValue.Name = "thicknessValue";
            this.thicknessValue.Size = new System.Drawing.Size(26, 37);
            this.thicknessValue.Text = "4";
            // 
            // thickness0
            // 
            this.thickness0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.thickness0.Name = "thickness0";
            this.thickness0.Size = new System.Drawing.Size(86, 22);
            this.thickness0.Tag = "";
            this.thickness0.Text = "1";
            this.thickness0.Click += new System.EventHandler(this.ThicknessButton_Click);
            // 
            // thickness1
            // 
            this.thickness1.Checked = true;
            this.thickness1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thickness1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.thickness1.Name = "thickness1";
            this.thickness1.Size = new System.Drawing.Size(86, 22);
            this.thickness1.Tag = "";
            this.thickness1.Text = "4";
            this.thickness1.Click += new System.EventHandler(this.ThicknessButton_Click);
            // 
            // thickness2
            // 
            this.thickness2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.thickness2.Name = "thickness2";
            this.thickness2.Size = new System.Drawing.Size(86, 22);
            this.thickness2.Text = "8";
            this.thickness2.Click += new System.EventHandler(this.ThicknessButton_Click);
            // 
            // thickness3
            // 
            this.thickness3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.thickness3.Name = "thickness3";
            this.thickness3.Size = new System.Drawing.Size(86, 22);
            this.thickness3.Text = "12";
            this.thickness3.Click += new System.EventHandler(this.ThicknessButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
            // 
            // color0Button
            // 
            this.color0Button.AutoToolTip = false;
            this.color0Button.Image = ((System.Drawing.Image)(resources.GetObject("color0Button.Image")));
            this.color0Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color0Button.Name = "color0Button";
            this.color0Button.Size = new System.Drawing.Size(49, 37);
            this.color0Button.Tag = "0";
            this.color0Button.Text = "Color 1";
            this.color0Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.color0Button.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // color1Button
            // 
            this.color1Button.AutoToolTip = false;
            this.color1Button.Image = ((System.Drawing.Image)(resources.GetObject("color1Button.Image")));
            this.color1Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color1Button.Name = "color1Button";
            this.color1Button.Size = new System.Drawing.Size(49, 37);
            this.color1Button.Tag = "1";
            this.color1Button.Text = "Color 2";
            this.color1Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.color1Button.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // pickColorButton
            // 
            this.pickColorButton.AutoToolTip = false;
            this.pickColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pickColorButton.Image = ((System.Drawing.Image)(resources.GetObject("pickColorButton.Image")));
            this.pickColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(63, 37);
            this.pickColorButton.Text = "Pick color";
            this.pickColorButton.Click += new System.EventHandler(this.PickColorButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 40);
            // 
            // drawLineButton
            // 
            this.drawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineButton.Image = global::Paint.Properties.Resources.icons8_line_64;
            this.drawLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(23, 37);
            this.drawLineButton.Text = "Line";
            this.drawLineButton.Click += new System.EventHandler(this.DrawLineButton_Click);
            // 
            // drawRectangleButton
            // 
            this.drawRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleButton.Image = global::Paint.Properties.Resources.icons8_rectangular_64;
            this.drawRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleButton.Name = "drawRectangleButton";
            this.drawRectangleButton.Size = new System.Drawing.Size(23, 37);
            this.drawRectangleButton.Text = "Rectangle";
            this.drawRectangleButton.Click += new System.EventHandler(this.DrawRectangleButton_Click);
            // 
            // drawFilledRectangleButton
            // 
            this.drawFilledRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawFilledRectangleButton.Image = global::Paint.Properties.Resources.icons8_rectangle_64;
            this.drawFilledRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawFilledRectangleButton.Name = "drawFilledRectangleButton";
            this.drawFilledRectangleButton.Size = new System.Drawing.Size(23, 37);
            this.drawFilledRectangleButton.Text = "Filled rectangle";
            this.drawFilledRectangleButton.Click += new System.EventHandler(this.DrawFilledRectangleButton_Click);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = global::Paint.Properties.Resources.icons8_oval_64;
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(23, 37);
            this.drawEllipseButton.Text = "Ellipse";
            this.drawEllipseButton.Click += new System.EventHandler(this.DrawEllipseButton_Click);
            // 
            // drawFilledEllipseButton
            // 
            this.drawFilledEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawFilledEllipseButton.Image = global::Paint.Properties.Resources.icons8_ellipse_64;
            this.drawFilledEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawFilledEllipseButton.Name = "drawFilledEllipseButton";
            this.drawFilledEllipseButton.Size = new System.Drawing.Size(23, 37);
            this.drawFilledEllipseButton.Text = "Filled ellipse";
            this.drawFilledEllipseButton.Click += new System.EventHandler(this.DrawFilledEllipseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.canvas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel canvasCoordinateLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileButton;
        private System.Windows.Forms.ToolStripMenuItem newButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton resizeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton rotateButton;
        private System.Windows.Forms.ToolStripMenuItem rotateRightButton;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftButton;
        private System.Windows.Forms.ToolStripMenuItem flipVerticalButton;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontalButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel thicknessLabel;
        private System.Windows.Forms.ToolStripDropDownButton thicknessValue;
        private System.Windows.Forms.ToolStripMenuItem thickness0;
        private System.Windows.Forms.ToolStripMenuItem thickness1;
        private System.Windows.Forms.ToolStripMenuItem thickness2;
        private System.Windows.Forms.ToolStripMenuItem thickness3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton color0Button;
        private System.Windows.Forms.ToolStripButton color1Button;
        private System.Windows.Forms.ToolStripButton pickColorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton drawLineButton;
        private System.Windows.Forms.ToolStripButton drawRectangleButton;
        private System.Windows.Forms.ToolStripButton drawFilledRectangleButton;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawFilledEllipseButton;
    }
}

