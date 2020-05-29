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
			this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
			this.layerCoordinateLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.layerSizeLabel = new System.Windows.Forms.ToolStripLabel();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.zoomLevelLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
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
			this.eraserButton = new System.Windows.Forms.ToolStripButton();
			this.drawLineButton = new System.Windows.Forms.ToolStripButton();
			this.drawRectangleButton = new System.Windows.Forms.ToolStripButton();
			this.drawFilledRectangleButton = new System.Windows.Forms.ToolStripButton();
			this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
			this.drawFilledEllipseButton = new System.Windows.Forms.ToolStripButton();
			this.bottomToolStrip.SuspendLayout();
			this.mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// bottomToolStrip
			// 
			this.bottomToolStrip.AutoSize = false;
			this.bottomToolStrip.BackColor = System.Drawing.SystemColors.Window;
			this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bottomToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
			this.bottomToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layerCoordinateLabel,
            this.toolStripSeparator1,
            this.layerSizeLabel,
            this.zoomInButton,
            this.zoomOutButton,
            this.zoomLevelLabel,
            this.toolStripSeparator3});
			this.bottomToolStrip.Location = new System.Drawing.Point(0, 425);
			this.bottomToolStrip.Name = "bottomToolStrip";
			this.bottomToolStrip.Size = new System.Drawing.Size(800, 25);
			this.bottomToolStrip.TabIndex = 2;
			this.bottomToolStrip.Text = "toolStrip2";
			// 
			// layerCoordinateLabel
			// 
			this.layerCoordinateLabel.AutoSize = false;
			this.layerCoordinateLabel.Image = global::Paint.Properties.Resources.icons8_move_64;
			this.layerCoordinateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.layerCoordinateLabel.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
			this.layerCoordinateLabel.Name = "layerCoordinateLabel";
			this.layerCoordinateLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.layerCoordinateLabel.Size = new System.Drawing.Size(100, 22);
			this.layerCoordinateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// layerSizeLabel
			// 
			this.layerSizeLabel.AutoSize = false;
			this.layerSizeLabel.Image = global::Paint.Properties.Resources.icons8_surface_64;
			this.layerSizeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.layerSizeLabel.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
			this.layerSizeLabel.Name = "layerSizeLabel";
			this.layerSizeLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.layerSizeLabel.Size = new System.Drawing.Size(100, 22);
			this.layerSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// zoomInButton
			// 
			this.zoomInButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.zoomInButton.AutoToolTip = false;
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Image = global::Paint.Properties.Resources.icons8_plus_64;
			this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(23, 22);
			this.zoomInButton.Text = "Zoom in";
			this.zoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.zoomOutButton.AutoToolTip = false;
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Image = global::Paint.Properties.Resources.icons8_minus_64;
			this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(23, 22);
			this.zoomOutButton.Text = "Zoom out";
			this.zoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
			// 
			// zoomLevelLabel
			// 
			this.zoomLevelLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.zoomLevelLabel.AutoSize = false;
			this.zoomLevelLabel.Name = "zoomLevelLabel";
			this.zoomLevelLabel.Size = new System.Drawing.Size(40, 22);
			this.zoomLevelLabel.Text = "Zoom";
			this.zoomLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// mainToolStrip
			// 
			this.mainToolStrip.AutoSize = false;
			this.mainToolStrip.BackColor = System.Drawing.SystemColors.Window;
			this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.mainToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
			this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eraserButton,
            this.drawLineButton,
            this.drawRectangleButton,
            this.drawFilledRectangleButton,
            this.drawEllipseButton,
            this.drawFilledEllipseButton});
			this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Size = new System.Drawing.Size(800, 40);
			this.mainToolStrip.TabIndex = 3;
			this.mainToolStrip.Text = "toolStrip1";
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
			this.resizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
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
			this.rotateRightButton.Size = new System.Drawing.Size(156, 22);
			this.rotateRightButton.Text = "Rotate right 90°";
			this.rotateRightButton.Click += new System.EventHandler(this.RotationButton_Click);
			// 
			// rotateLeftButton
			// 
			this.rotateLeftButton.Image = global::Paint.Properties.Resources.icons8_rotate_left_50;
			this.rotateLeftButton.Name = "rotateLeftButton";
			this.rotateLeftButton.Size = new System.Drawing.Size(156, 22);
			this.rotateLeftButton.Text = "Rotate left 90°";
			this.rotateLeftButton.Click += new System.EventHandler(this.RotationButton_Click);
			// 
			// flipVerticalButton
			// 
			this.flipVerticalButton.Image = global::Paint.Properties.Resources.icons8_flip_vertical_50;
			this.flipVerticalButton.Name = "flipVerticalButton";
			this.flipVerticalButton.Size = new System.Drawing.Size(156, 22);
			this.flipVerticalButton.Text = "Flip vertical";
			this.flipVerticalButton.Click += new System.EventHandler(this.RotationButton_Click);
			// 
			// flipHorizontalButton
			// 
			this.flipHorizontalButton.Image = global::Paint.Properties.Resources.icons8_flip_horizontal_50;
			this.flipHorizontalButton.Name = "flipHorizontalButton";
			this.flipHorizontalButton.Size = new System.Drawing.Size(156, 22);
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
			this.thicknessValue.AutoSize = false;
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
			this.thicknessValue.Size = new System.Drawing.Size(30, 37);
			this.thicknessValue.Text = "5";
			// 
			// thickness0
			// 
			this.thickness0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.thickness0.Name = "thickness0";
			this.thickness0.Size = new System.Drawing.Size(86, 22);
			this.thickness0.Tag = "";
			this.thickness0.Text = "3";
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
			this.thickness1.Text = "5";
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
			// eraserButton
			// 
			this.eraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.eraserButton.Image = global::Paint.Properties.Resources.icons8_eraser_64;
			this.eraserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.eraserButton.Name = "eraserButton";
			this.eraserButton.Size = new System.Drawing.Size(23, 37);
			this.eraserButton.Text = "Eraser";
			this.eraserButton.Click += new System.EventHandler(this.EraserButton_Click);
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
			this.Controls.Add(this.mainToolStrip);
			this.Controls.Add(this.bottomToolStrip);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Paint";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.bottomToolStrip.ResumeLayout(false);
			this.bottomToolStrip.PerformLayout();
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripLabel layerCoordinateLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip mainToolStrip;
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
        private System.Windows.Forms.ToolStripButton eraserButton;
        private System.Windows.Forms.ToolStripLabel layerSizeLabel;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripLabel zoomLevelLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

