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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
#endregion

namespace meetingProject
{
    public partial class meetingForm : Form
    {

        private Recorder rec;
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputSoundPath;
        private bool closing = false;
        private double soundDuration = 0;
        DateTime date;

        private bool chronoRunning = false;
        private TimeSpan elapsedTime;
        private DateTime chronoStart;

        private MySqlConnection connection;
        private string connectionString = "server=193.57.41.19;user=kskn;password=26589479124Ek;database=recordmeeting;";

        private LoginUI UserDatas;


        public meetingForm(LoginUI loginUI)
        {
            InitializeComponent();
            #region TO MAKE NAVBAR BUTTONS DO THE SAME THING ON CLICK EVENT
            btnMeeting.Click += NavbarButton_Click;
            btnTranslateFile.Click += NavbarButton_Click;
            btnSpeechToText.Click += NavbarButton_Click;
            btnOldRecords.Click += NavbarButton_Click;
            btnMeetingAnalysis.Click += NavbarButton_Click;
            #endregion

            this.UserDatas = loginUI;
            string email = UserDatas.emailP;
            string username = UserDatas.usernameP;
            int userID = UserDatas.userIDP;
        }


        #region FORM LOAD
        private void meetingForm_Load(object sender, EventArgs e)
        {
            btnRecord.Enabled = true;
            btnStop.Enabled = false;

            var columns = new List<string> { "ID", "title", "subject", "duration", "date_time" };
            fillDataGridView("meetingrecords", columns, dataGridView1);
        }
        #endregion

        #region GET DATAS AND WRITE IT TO DATAGRIDVIEW
        public void fillDataGridView(string table, List<string> columns, DataGridView datagridname)
        {
            var data = getData(table, columns);

            dataGridView1.Rows.Clear();

            foreach (var row in data)
            {
                var values = columns.Select(column => row[column]).ToArray();
                datagridname.Rows.Add(values);
            }
        }
        public List<Dictionary<string, object>> getData(string table, List<string> columns)
        {
            dataGridView1.Rows.Clear();

            var results = new List<Dictionary<string, object>>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string columnNames = string.Join(", ", columns);
                string query = $"SELECT {columnNames} FROM {table}";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            foreach (var column in columns) row[column] = reader[column];

                            results.Add(row);
                        }
                    }
                }
            }
            return results;
        }
        #endregion 

        #region NAVBAR
        private void NavbarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Tag != null)
            {
                string formName = clickedButton.Tag.ToString();
                Form formToShow = null;

                switch (formName)
                {
                    case "meetingForm": formToShow = new meetingForm(this.UserDatas); break;
                    case "translateFileForm": formToShow = new meetingForm(this.UserDatas); break;
                    case "speechToTextForm": formToShow = new meetingForm(this.UserDatas); break;
                    default: break;
                }

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
        private Point mouseLocation;
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X - 254, -e.Y);
        }
        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
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

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - chronoStart;
            lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss");
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

                #region TIMER
                lblTimer.Visible = true;
                timer1.Start();
                chronoStart = DateTime.Now - elapsedTime;
                chronoRunning = true;
                #endregion

                #region VIDEO
                btnRecord.Enabled = false;
                rec = new Recorder(new RecorderParams(date.ToString("d_MMM_yy_HH-mm")+".avi",
                                   txtOutputFolder.Text, 10,
                                   SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 30));
                #endregion

                #region SOUND
                var outputFolder = txtOutputFolder.Text;
                Directory.CreateDirectory(outputFolder);
                outputSoundPath = Path.Combine(outputFolder, date.ToString("d_MMM_yy_HH-mm")+".wav");

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

            #region TIMER
            timer1.Stop();
            chronoRunning = false;
            #endregion

            #region PYTHON ENTEGRATION
            string jsonFilePath = Environment.CurrentDirectory + @"\parameters.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            JObject jsonObj = JObject.Parse(jsonContent);
            jsonObj["output_file"] = Path.Combine(txtOutputFolder.Text, "transcript.txt");
            jsonObj["file_url"] = outputSoundPath;


            File.WriteAllText(jsonFilePath, jsonObj.ToString());

            string pythonExePath = FindPythonExecutable();

            if (pythonExePath != null)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = pythonExePath;
                startInfo.Arguments = Environment.CurrentDirectory + @"\rl.py";

                Process.Start(startInfo);
            }
            else { MessageBox.Show("Python is not exists on your computer !", "Error"); Environment.Exit(0); }

            #region ADD AND REMOVE DURATIONS IN DATABASE
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM transcript_calculate";
                using (var command = new MySqlCommand(countQuery, connection))
                {
                    int rowCount = Convert.ToInt32(command.ExecuteScalar());

                    if (rowCount > 24)
                    {
                        string deleteQuery = "DELETE FROM transcript_calculate ORDER BY ID ASC LIMIT 1";
                        using (var deleteCommand = new MySqlCommand(deleteQuery, connection)) { deleteCommand.ExecuteNonQuery(); }
                    }
                    else
                    {
                        double transcriptDuration = double.Parse(jsonObj["transcript_duration"].ToString());

                        soundDuration = double.Parse(elapsedTime.TotalSeconds.ToString());
                        elapsedTime = TimeSpan.Zero;

                        string query = $"INSERT INTO transcript_calculate (sound_duration, transcript_duration)" +
                                       $" VALUES ('{soundDuration.ToString(System.Globalization.CultureInfo.InvariantCulture)}'," +
                                       $" '{transcriptDuration.ToString(System.Globalization.CultureInfo.InvariantCulture)}')";

                        using (var cmd = new MySqlCommand(query, connection)) { cmd.ExecuteNonQuery(); }
                    }
                }
            }
            #endregion

            #endregion

            pnlAdd.Visible = true;

        }
        #endregion

        #region ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = "";
            string subject = "";
            
            if (!string.IsNullOrEmpty(txtMeetingTitle.Text)) title = txtMeetingTitle.Text;
            else title = "-";

            if (!string.IsNullOrEmpty(txtMeetingTitle.Text)) subject = rTxtMeetingSubject.Text;
            else subject = "-";

            string duration = lblTimer.Text;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO meetingrecords (title, subject, duration) " +
                               $"VALUES ('{title}', '{subject}', '{duration}')";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Meeting record added successfully!", "Success");
                }
            }

            var columns = new List<string> { "ID", "title", "subject", "duration", "date_time" };
            fillDataGridView("meetingrecords", columns, dataGridView1);

            lblTimer.Text = "";
            txtMeetingTitle.Text = "";
            rTxtMeetingSubject.Text = "";
            pnlAdd.Visible = false;
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
