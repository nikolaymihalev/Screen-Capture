namespace ScreenCapture
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            newCaptureBtn = new Button();
            savePictureBtn = new Button();
            picScreenshot = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picScreenshot).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // newCaptureBtn
            // 
            newCaptureBtn.BackgroundImageLayout = ImageLayout.Zoom;
            newCaptureBtn.FlatAppearance.BorderSize = 0;
            newCaptureBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            newCaptureBtn.FlatStyle = FlatStyle.Flat;
            newCaptureBtn.Font = new Font("Segoe UI", 9F);
            newCaptureBtn.ForeColor = SystemColors.ControlText;
            newCaptureBtn.ImageAlign = ContentAlignment.TopLeft;
            newCaptureBtn.Location = new Point(0, 0);
            newCaptureBtn.Name = "newCaptureBtn";
            newCaptureBtn.Size = new Size(130, 52);
            newCaptureBtn.TabIndex = 0;
            newCaptureBtn.Text = "New Capture";
            newCaptureBtn.TextAlign = ContentAlignment.MiddleRight;
            newCaptureBtn.UseVisualStyleBackColor = true;
            newCaptureBtn.Click += newCaptureBtn_Click;
            // 
            // savePictureBtn
            // 
            savePictureBtn.BackColor = SystemColors.MenuBar;
            savePictureBtn.FlatAppearance.BorderSize = 0;
            savePictureBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            savePictureBtn.FlatStyle = FlatStyle.Flat;
            savePictureBtn.Location = new Point(211, 0);
            savePictureBtn.Name = "savePictureBtn";
            savePictureBtn.Size = new Size(102, 52);
            savePictureBtn.TabIndex = 1;
            savePictureBtn.Text = "Save Picture";
            savePictureBtn.UseVisualStyleBackColor = false;
            savePictureBtn.Click += savePictureBtn_Click;
            // 
            // picScreenshot
            // 
            picScreenshot.Dock = DockStyle.Fill;
            picScreenshot.Location = new Point(0, 0);
            picScreenshot.Name = "picScreenshot";
            picScreenshot.Size = new Size(800, 450);
            picScreenshot.TabIndex = 2;
            picScreenshot.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(savePictureBtn);
            panel1.Controls.Add(newCaptureBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(167, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 52);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 52);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(picScreenshot);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            Text = "Screen Capture";
            ((System.ComponentModel.ISupportInitialize)picScreenshot).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button newCaptureBtn;
        private Button savePictureBtn;
        private PictureBox picScreenshot;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
