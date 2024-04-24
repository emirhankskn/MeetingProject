using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meetingProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            btnMeeting.Click += NavbarButton_Click;
            btnTranslateFile.Click += NavbarButton_Click;
            btnSpeechToText.Click += NavbarButton_Click;
            btnOldRecords.Click += NavbarButton_Click;
            btnMeetingAnalysis.Click += NavbarButton_Click;
        }

        #region NAVBAR
        private void NavbarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Tıklanan butonun Tag özelliğine göre ilgili formu aç
            if (clickedButton != null && clickedButton.Tag != null)
            {
                string formName = clickedButton.Tag.ToString();
                Form formToShow = null;

                // Form isimlerini ve form nesnelerini eşleştirmek için bir switch kullanıyoruz
                switch (formName)
                {
                    case "meetingForm": formToShow = new meetingForm(); break;
                    case "translateFileForm": formToShow = new meetingForm(); break;
                    case "speechToTextForm": formToShow = new meetingForm(); break;
                    default: break;
                }

                // Sağdaki panele seçilen formu yükle
                if (formToShow != null)
                {
                    formToShow.TopLevel = false;
                    formToShow.FormBorderStyle = FormBorderStyle.None;
                    formToShow.Dock = DockStyle.Fill;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(formToShow);
                    formToShow.Show();
                }
            }
        }
        #endregion

        #region FORM MOVEABLE FROM PANEL
        public Point mouseLocation; //mouseLocation isimli bir Point nesnesi oluşturuldu
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X - 254, -e.Y); //Lokasyonu verildi fakat bizim panel tam olarak bütün form genişliğinde olmadığından
                                                         // doğru çalışması için x ekseninde değişklik yapılması gerekti
        }
        //Bu fonksiyon sayesinde mouse hareket ettiğinde formun lokasyonunu da mousenin lokasyonuna göre ayarlamsını sağlıyoruz
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        #endregion

        #region EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void exitTopRight_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

    }
}
