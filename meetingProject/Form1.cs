using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace meetingProject
{
    public partial class Form1 : Form
    {
        private ScreenRecorder screenRecorder;
        public Form1()
        {
            InitializeComponent();
            screenRecorder = new ScreenRecorder();
        }

        

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string outputFilePath = @"C:\Users\Emir\Desktop\out.mp4";
            screenRecorder.StartRecording(outputFilePath);
            btnRecord.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            screenRecorder.StopRecording();
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
        }

        public class ScreenRecorder
        {
            private Process process;

            public void StartRecording(string outputFilePath)
            {
                string audioDevice = "Ses Cihazı"; // Kullanmak istediğiniz ses cihazının adını buraya yazın
                string ffmpegArgs = $"-f gdigrab -framerate 30 -i desktop -f dshow -i audio=\"{audioDevice}\" -c:v libx264 -preset ultrafast -qp 0 -tune zerolatency \"{outputFilePath}\"";


                // FFmpeg'i başlat
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\PATH_Programs\ffmpeg.exe",
                    Arguments = ffmpegArgs,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                process = new Process();
                process.StartInfo = startInfo;
                process.Start();
            }

            public void StopRecording()
            {
                // FFmpeg işlemini durdur
                if (process != null && !process.HasExited)
                {
                    process.Kill();
                    process.WaitForExit();
                }
            }
        }
    }
}
