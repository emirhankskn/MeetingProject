using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAvi;
using SharpAvi.Codecs;
using SharpAvi.Output;
using System.Windows.Forms;

namespace meetingProject
{
    public partial class meetingForm : Form
    {
        public meetingForm()
        {
            InitializeComponent();
            btnMeeting.Click += NavbarButton_Click;
            btnTranslateFile.Click += NavbarButton_Click;
            btnSpeechToText.Click += NavbarButton_Click;
            btnOldRecords.Click += NavbarButton_Click;
            btnMeetingAnalysis.Click += NavbarButton_Click;
        }

        private void BackButton()
        {
            Button backbutton = new Button();
            backbutton.Location = new Point(298, 678);
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

        #region FORM MOVEABLE FROM PANEL (DOESN'T WORK LOOK IT LATER)
        private bool mouseDownBool;
        private Point lastLocation;
        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseDownBool = true;
            lastLocation = e.Location;
        }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownBool)
            {
                // Yeni form konumunu hesapla
                Point newLocation = this.Location;
                newLocation.X += e.X - lastLocation.X;
                newLocation.Y += e.Y - lastLocation.Y;

                // Formun ekranın dışına çıkmasını engelle
                newLocation.X = Math.Max(0, newLocation.X);
                newLocation.Y = Math.Max(0, newLocation.Y);
                newLocation.X = Math.Min(Screen.PrimaryScreen.WorkingArea.Width - this.Width, newLocation.X);
                newLocation.Y = Math.Min(Screen.PrimaryScreen.WorkingArea.Height - this.Height, newLocation.Y);

                this.Location = newLocation;
            }
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            mouseDownBool = false;
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

        private void btnRecord_Click(object sender, EventArgs e)
        {
            btnRecord.Enabled = false;
            var rec = new Recorder(new RecorderParams("out.avi", 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 70));

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }
    }
}
