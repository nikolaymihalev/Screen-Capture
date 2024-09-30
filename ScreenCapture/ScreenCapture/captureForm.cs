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

        }
    }
}
