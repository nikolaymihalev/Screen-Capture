using System.Drawing.Imaging;

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
            picScreenshot.Image = tempImage;

            this.Show();
        }

        private void savePictureBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg File|*.jpg";
            saveFileDialog.FileName = "Untitled";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                if (picScreenshot.Image != null) 
                {
                    picScreenshot.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);

                    MessageBox.Show(this, $"Saved Screenshot to {saveFileDialog.FileName}", 
                        "Saved", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
