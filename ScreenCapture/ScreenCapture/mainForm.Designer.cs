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
            SuspendLayout();
            // 
            // newCaptureBtn
            // 
            newCaptureBtn.Location = new Point(46, 37);
            newCaptureBtn.Name = "newCaptureBtn";
            newCaptureBtn.Size = new Size(102, 52);
            newCaptureBtn.TabIndex = 0;
            newCaptureBtn.Text = "New Capture";
            newCaptureBtn.UseVisualStyleBackColor = true;
            // 
            // savePictureBtn
            // 
            savePictureBtn.Location = new Point(187, 37);
            savePictureBtn.Name = "savePictureBtn";
            savePictureBtn.Size = new Size(102, 52);
            savePictureBtn.TabIndex = 1;
            savePictureBtn.Text = "Save Picture";
            savePictureBtn.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(savePictureBtn);
            Controls.Add(newCaptureBtn);
            Name = "mainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button newCaptureBtn;
        private Button savePictureBtn;
    }
}
