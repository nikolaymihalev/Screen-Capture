﻿using System.Drawing.Imaging;
namespace ScreenCapture
{
    public partial class captureForm : Form
    {
        int selectX;
        int selectY;
        int selectWidth;
        int selectHeight;
        public Pen selectPen;
        public Bitmap ScreenShot;

        bool start = false;

        public captureForm()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 0;
            this.Left = 0;
        }

        private void captureForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            Bitmap printScreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printScreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printScreen.Size);

            using (MemoryStream ms = new MemoryStream())
            {
                printScreen.Save(ms, ImageFormat.Bmp);
                picCapture.Size = new System.Drawing.Size(this.Width, this.Height);
                picCapture.Image = Image.FromStream(ms);
            }

            this.Show();

            Cursor = Cursors.Cross;
        }

        private void picCapture_MouseDown(object sender, MouseEventArgs e)
        {
            if (!start)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    selectX = e.X;
                    selectY = e.Y;
                    selectPen = new Pen(Color.Red, 4);
                    selectPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }

                picCapture.Refresh();

                start = true;
            }
        }

        private void picCapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (picCapture.Image == null)
                return;

            if (start)
            {
                picCapture.Refresh();

                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;

                picCapture.CreateGraphics().SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                picCapture.CreateGraphics().DrawRectangle(selectPen, selectX, selectY, selectWidth, selectHeight);
            }
        }

        private void picCapture_MouseUp(object sender, MouseEventArgs e)
        {
            if (picCapture.Image == null)
                return;

            if (e.Button == MouseButtons.Left) 
            {
                picCapture.Refresh();
                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;
                picCapture.CreateGraphics().DrawRectangle(selectPen, selectX, selectY, selectWidth, selectHeight);
            }

            start = false;

            SaveToClipboard();
        }

        private void SaveToClipboard() 
        {
            if (selectWidth > 0) 
            {
                Rectangle rect = new Rectangle(selectX, selectY, selectWidth, selectHeight);

                Bitmap originalImage = new Bitmap(picCapture.Image, picCapture.Width, picCapture.Height);

                Bitmap _image = new Bitmap(selectWidth, selectHeight);
                
                Graphics gr = Graphics.FromImage(_image);

                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.DrawImage(originalImage, 0, 0, rect, GraphicsUnit.Pixel);

                Clipboard.SetImage(_image);
            }

            this.Close();
        }
    }
}
