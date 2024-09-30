namespace ScreenCapture
{
    partial class captureForm
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
            picCapture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCapture).BeginInit();
            SuspendLayout();
            // 
            // picCapture
            // 
            picCapture.Location = new Point(12, 12);
            picCapture.Name = "picCapture";
            picCapture.Size = new Size(100, 100);
            picCapture.TabIndex = 0;
            picCapture.TabStop = false;
            picCapture.MouseDown += picCapture_MouseDown;
            // 
            // captureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picCapture);
            Name = "captureForm";
            Text = "captureForm";
            Load += captureForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCapture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCapture;
    }
}