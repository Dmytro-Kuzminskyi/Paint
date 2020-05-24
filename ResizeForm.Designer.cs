namespace Paint
{
    partial class ResizeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pixelsRadioButton = new System.Windows.Forms.RadioButton();
            this.percentageRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ratioCheckBox = new System.Windows.Forms.CheckBox();
            this.verticalTextBox = new System.Windows.Forms.TextBox();
            this.horizontalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pixelsRadioButton);
            this.panel1.Controls.Add(this.percentageRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 41);
            this.panel1.TabIndex = 0;
            // 
            // pixelsRadioButton
            // 
            this.pixelsRadioButton.AutoSize = true;
            this.pixelsRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pixelsRadioButton.Location = new System.Drawing.Point(181, 0);
            this.pixelsRadioButton.Name = "pixelsRadioButton";
            this.pixelsRadioButton.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.pixelsRadioButton.Size = new System.Drawing.Size(91, 41);
            this.pixelsRadioButton.TabIndex = 2;
            this.pixelsRadioButton.TabStop = true;
            this.pixelsRadioButton.Text = "Pixels";
            this.pixelsRadioButton.UseVisualStyleBackColor = true;
            this.pixelsRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // percentageRadioButton
            // 
            this.percentageRadioButton.AutoSize = true;
            this.percentageRadioButton.Checked = true;
            this.percentageRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.percentageRadioButton.Location = new System.Drawing.Point(56, 0);
            this.percentageRadioButton.Name = "percentageRadioButton";
            this.percentageRadioButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.percentageRadioButton.Size = new System.Drawing.Size(125, 41);
            this.percentageRadioButton.TabIndex = 1;
            this.percentageRadioButton.TabStop = true;
            this.percentageRadioButton.Text = "Percentage";
            this.percentageRadioButton.UseVisualStyleBackColor = true;
            this.percentageRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "By:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ratioCheckBox);
            this.panel2.Controls.Add(this.verticalTextBox);
            this.panel2.Controls.Add(this.horizontalTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 173);
            this.panel2.TabIndex = 1;
            // 
            // ratioCheckBox
            // 
            this.ratioCheckBox.AutoSize = true;
            this.ratioCheckBox.Location = new System.Drawing.Point(16, 137);
            this.ratioCheckBox.Name = "ratioCheckBox";
            this.ratioCheckBox.Size = new System.Drawing.Size(175, 24);
            this.ratioCheckBox.TabIndex = 7;
            this.ratioCheckBox.Text = "Maintain aspect ratio";
            this.ratioCheckBox.UseVisualStyleBackColor = true;
            this.ratioCheckBox.CheckedChanged += new System.EventHandler(this.ratioCheckBox_CheckedChanged);
            // 
            // verticalTextBox
            // 
            this.verticalTextBox.Location = new System.Drawing.Point(227, 89);
            this.verticalTextBox.MaxLength = 4;
            this.verticalTextBox.Name = "verticalTextBox";
            this.verticalTextBox.Size = new System.Drawing.Size(45, 26);
            this.verticalTextBox.TabIndex = 6;
            this.verticalTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.verticalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValidate_KeyPress);
            // 
            // horizontalTextBox
            // 
            this.horizontalTextBox.Location = new System.Drawing.Point(227, 29);
            this.horizontalTextBox.MaxLength = 4;
            this.horizontalTextBox.Name = "horizontalTextBox";
            this.horizontalTextBox.Size = new System.Drawing.Size(45, 26);
            this.horizontalTextBox.TabIndex = 5;
            this.horizontalTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.horizontalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValidate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vertical:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horizontal:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Paint.Properties.Resources.icons8_resize_vertical_64;
            this.pictureBox3.Location = new System.Drawing.Point(96, 52);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Paint.Properties.Resources.icons8_resize_horizontal_64;
            this.pictureBox2.Location = new System.Drawing.Point(36, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Paint.Properties.Resources.icons8_picture_64;
            this.pictureBox1.Location = new System.Drawing.Point(16, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(66, 220);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(172, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.Text = "Resize";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResizeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton pixelsRadioButton;
        private System.Windows.Forms.RadioButton percentageRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox horizontalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox ratioCheckBox;
        private System.Windows.Forms.TextBox verticalTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}