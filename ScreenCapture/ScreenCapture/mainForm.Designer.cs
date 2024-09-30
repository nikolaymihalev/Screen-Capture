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
            newCaptureBtn = new Button();
            savePictureBtn = new Button();
            mainImageBox = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mainImageBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // newCaptureBtn
            // 
            newCaptureBtn.Location = new Point(17, 20);
            newCaptureBtn.Name = "newCaptureBtn";
            newCaptureBtn.Size = new Size(102, 52);
            newCaptureBtn.TabIndex = 0;
            newCaptureBtn.Text = "New Capture";
            newCaptureBtn.UseVisualStyleBackColor = true;
            newCaptureBtn.Click += newCaptureBtn_Click;
            // 
            // savePictureBtn
            // 
            savePictureBtn.Location = new Point(154, 20);
            savePictureBtn.Name = "savePictureBtn";
            savePictureBtn.Size = new Size(102, 52);
            savePictureBtn.TabIndex = 1;
            savePictureBtn.Text = "Save Picture";
            savePictureBtn.UseVisualStyleBackColor = true;
            savePictureBtn.Click += savePictureBtn_Click;
            // 
            // mainImageBox
            // 
            mainImageBox.Dock = DockStyle.Fill;
            mainImageBox.Location = new Point(0, 0);
            mainImageBox.Name = "mainImageBox";
            mainImageBox.Size = new Size(800, 450);
            mainImageBox.TabIndex = 2;
            mainImageBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(savePictureBtn);
            panel1.Controls.Add(newCaptureBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 3;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(mainImageBox);
            Name = "mainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mainImageBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button newCaptureBtn;
        private Button savePictureBtn;
        private PictureBox mainImageBox;
        private Panel panel1;
    }
}
