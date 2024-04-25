#region LIBRARIES
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
using NAudio.Wave;
using System.IO;
using System.Diagnostics;
using System.Dynamic;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
#endregion

namespace meetingProject
{
    public partial class meetingForm : Form
    {
        #region VARIABLES FOR ALL FUNCTIONS
        private Recorder rec;
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputSoundPath;
        private bool closing = false;
        DateTime date;
        #endregion

        #region FORM CONSTRUCTOR
        public meetingForm()
        {
            InitializeComponent();
            #region TO MAKE NAVBAR BUTTONS DO THE SAME THING ON CLICK EVENT
            btnMeeting.Click += NavbarButton_Click;
            btnTranslateFile.Click += NavbarButton_Click;
            btnSpeechToText.Click += NavbarButton_Click;
            btnOldRecords.Click += NavbarButton_Click;
            btnMeetingAnalysis.Click += NavbarButton_Click;
            #endregion
        }
        #endregion

        #region FORM LOAD
        private void meetingForm_Load(object sender, EventArgs e)
        {
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
        }
        #endregion

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

        #region BROWSE FOLDER
        private void browseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK) txtOutputFolder.Text = diag.SelectedPath;
            else txtOutputFolder.Text = "";
        }
        #endregion

        #region RECORD FUNCTION
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (txtOutputFolder.Text.Length == 0) lblErrorSelectFolder.Visible = true;
            else
            {
                lblErrorSelectFolder.Visible = false;
                date = DateTime.Now;
                
                #region VIDEO
                btnRecord.Enabled = false;
                rec = new Recorder(new RecorderParams(date.ToString("d_MMM_yy_HH-mm")+".avi",
                                   txtOutputFolder.Text, 10,
                                   SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 30));
                #endregion

                #region SOUND
                var outputFolder = txtOutputFolder.Text;
                Directory.CreateDirectory(outputFolder);
                outputSoundPath = Path.Combine(outputFolder, "recorded.wav");

                waveIn = new WaveInEvent();
                waveIn.DataAvailable += WaveIn_DataAvailable;
                waveIn.RecordingStopped += WaveIn_RecordingStopped;

                writer = new WaveFileWriter(outputSoundPath, waveIn.WaveFormat);
                waveIn.StartRecording();

                btnRecord.Enabled = false;
                btnStop.Enabled = true;
                #endregion
            }
        }
        #endregion

        #region STOP RECORD FUNCTION
        private void btnStop_Click(object sender, EventArgs e)
        {
            #region VIDEO
            rec.Dispose();
            #endregion


            #region SOUND
            waveIn.StopRecording();
            #endregion


            #region PYTHON ENTEGRATION
            string jsonFilePath = Environment.CurrentDirectory+@"\parameters.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            JObject jsonObj = JObject.Parse(jsonContent);
            jsonObj["output_file"] = Path.Combine(txtOutputFolder.Text, "transcript.txt");
            jsonObj["file_url"] = txtOutputFolder.Text + @"\recorded.wav";

            File.WriteAllText(jsonFilePath, jsonObj.ToString());

            string pythonExePath = FindPythonExecutable();

            if (pythonExePath != null)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = pythonExePath;
                startInfo.Arguments = Environment.CurrentDirectory + @"\rl.py";

                Process.Start(startInfo);
            }
            else MessageBox.Show("Python is not exists on your computer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

            txtOutputFolder.Clear();

        }
        #endregion

        #region FIND PYTHON FUNCTION
        static string FindPythonExecutable()
        {
            string[] pythonPaths = Environment.GetEnvironmentVariable("PATH").Split(Path.PathSeparator);
            foreach (string path in pythonPaths)
            {
                string pythonExePath = Path.Combine(path, "python.exe");
                if (File.Exists(pythonExePath)) return pythonExePath;
            }
            return null;
        }
        #endregion

        #region SOUND RECORDER FUNCTIONS
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
        private void WaveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer?.Dispose();
            writer = null;
            btnRecord.Enabled = true;
            btnStop.Enabled = false;

            if (closing)
            {
                waveIn.Dispose();
            }
        }
        private void meetingForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            closing = true;
            waveIn.StopRecording();
        }
        #endregion

        #region SOUND AND VIDEO RECORD MERGE FUNCTION
        //public static void MergeVideoAndAudio(string videoFilePath, string audioFilePath, string outputFilePath)
        //{
        //    string arguments = $"-i \"{videoFilePath}\" -i \"{audioFilePath}\" -c:v copy -c:a aac -strict experimental \"{outputFilePath}\"";

        //    ProcessStartInfo startInfo = new ProcessStartInfo
        //    {
        //        FileName = @"C:\PATH_Programs\ffmpeg.exe", 
        //        Arguments = arguments,
        //        UseShellExecute = false,
        //        RedirectStandardOutput = true,
        //        CreateNoWindow = true
        //    };

        //    using (Process process = Process.Start(startInfo))
        //    {
        //        process.WaitForExit();
        //    }
        //}
        #endregion

        #region SETTINGS BUTTON
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm f = new settingsForm();
            f.Show();
        }
        #endregion

        #region EXIT BUTTONS
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
