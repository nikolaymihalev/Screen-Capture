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
        }

        private void captureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
