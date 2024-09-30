using System.Drawing.Imaging;
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
        }
    }
}
