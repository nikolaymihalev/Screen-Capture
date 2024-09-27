namespace ScreenCapture
{
    public partial class mainForm : Form
    {
        captureForm captureForm = new captureForm();

        public mainForm()
        {
            InitializeComponent();
        }

        private void newCaptureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Thread.Sleep(200);

            captureForm.ShowDialog();

            Image tempImage = Clipboard.GetImage();

            this.Show();
        }
    }
}
