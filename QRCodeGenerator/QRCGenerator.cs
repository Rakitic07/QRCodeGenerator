using QRCoder;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCGenerator
{
    public partial class QRCGenerator : Form
    {
        public QRCGenerator()
        {
            InitializeComponent();
            circleProgress.SendToBack();
        }

        Random rdm = new Random();
        private void PBox2_Paint(object sender, PaintEventArgs e)
        {
            //pBox2.BackColor = Color.White;            
            using (Font myFont = new Font("Comic Sans MS", 11, FontStyle.Italic))
            {
                e.Graphics.DrawString("Your Logo\nhas been\nSet", myFont, Brushes.SlateGray, new Point(1, 4));
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void GenerateQRBtn_Click(object sender, EventArgs e)
        {
            circleProgress.Value = 0;
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PNG/JPEG/ICON Files (*.png,*.jpg,*.ico)|*.png;*.jpg;*.ico";
            if (of.ShowDialog() == DialogResult.OK)
            {
                //pBox2.ImageLocation = of.FileName;
                circleProgress.ProgressColor = Color.FromArgb(rdm.Next(1, 250), rdm.Next(1, 250), rdm.Next(1, 250));
                circleProgress.ForeColor = Color.FromArgb(rdm.Next(1, 250), rdm.Next(1, 250), rdm.Next(1, 250));
                pBox.Image = null;
                await Task.Delay(30);
                circleProgress.BringToFront();
            }

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRText.Text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);

            for (int i = circleProgress.Value; i <= 100; i++)
            {
                if (circleProgress.Value > 95)
                    break;
                circleProgress.Value += rdm.Next(1, 5);
                await Task.Delay(rdm.Next(1, 30));
            }
            circleProgress.SendToBack();
            await Task.Delay(30);

            pBox.Image = qrCode.GetGraphic(12, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(of.FileName), 15, 5, false);
        }

        private void QRText_Enter(object sender, EventArgs e)
        {
            QRText.Text = null;
            QRText.ForeColor = Color.FromArgb(220, 220, 220);
        }

        private void QRText_Leave(object sender, EventArgs e)
        {
            QRText.Text = "...Your Text here...";
            QRText.ForeColor = Color.FromArgb(130, 130, 130);
        }
    }
}
