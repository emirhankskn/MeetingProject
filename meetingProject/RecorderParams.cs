using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpAvi;
using SharpAvi.Codecs;
using SharpAvi.Output;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace meetingProject
{
    public class RecorderParams
    {
        public RecorderParams(string filename, string filepath, int FrameRate, FourCC Encoder, int Quality)
        {
            FileName = filename;
            FilePath = filepath;
            FramesPerSecond = FrameRate;
            Codec = Encoder;
            this.Quality = Quality;

            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
        }

        string FileName, FilePath;
        public int FramesPerSecond, Quality;
        FourCC Codec;

        public int Height { get; private set; }
        public int Width { get; private set; }

        public AviWriter CreateAviWriter()
        {
            return new AviWriter(Path.Combine(FilePath, FileName))
            {
                FramesPerSecond = FramesPerSecond,
                EmitIndex1 = true,
            };
        }

        public IAviVideoStream CreateVideoStream(AviWriter writer)
        {
            if (Codec == KnownFourCCs.Codecs.Uncompressed)
                return writer.AddUncompressedVideoStream(Width, Height);
            else if (Codec == KnownFourCCs.Codecs.MotionJpeg)
                return writer.AddMotionJpegVideoStream(Width, Height, Quality);
            else
            {
                return writer.AddMpeg4VideoStream(Width, Height, (double)writer.FramesPerSecond,
                    quality: Quality,
                    codec: Codec,
                    forceSingleThreadedAccess: true);
            }
        }
    }
    public class Recorder : IDisposable
    {
        #region Fields
        AviWriter writer;
        RecorderParams Params;
        IAviVideoStream videoStream;
        Thread screenThread;
        ManualResetEvent stopThread = new ManualResetEvent(false);
        #endregion

        public Recorder(RecorderParams Params)
        {
            this.Params = Params;

            writer = Params.CreateAviWriter();

            videoStream = Params.CreateVideoStream(writer);
            videoStream.Name = "Captura";

            screenThread = new Thread(RecordScreen)
            {
                Name = typeof(Recorder).Name + ".RecordScreen",
                IsBackground = true
            };

            screenThread.Start();
        }

        public void Dispose()
        {
            stopThread.Set();
            screenThread.Join();

            writer.Close();

            stopThread.Dispose();
        }

        void RecordScreen()
        {
            var frameInterval = TimeSpan.FromSeconds(1 / (double)writer.FramesPerSecond);
            var buffer = new byte[Params.Width * Params.Height * 4];
            Task videoWriteTask = null;
            var timeTillNextFrame = TimeSpan.Zero;

            while (!stopThread.WaitOne(timeTillNextFrame))
            {
                var timestamp = DateTime.Now;

                Screenshot(buffer);

                videoWriteTask?.Wait();

                videoWriteTask = videoStream.WriteFrameAsync(true, buffer, 0, buffer.Length);

                timeTillNextFrame = timestamp + frameInterval - DateTime.Now;
                if (timeTillNextFrame < TimeSpan.Zero)
                    timeTillNextFrame = TimeSpan.Zero;
            }

            videoWriteTask?.Wait();
        }

        public void Screenshot(byte[] Buffer)
        {
            using (var BMP = new Bitmap(Params.Width, Params.Height))
            {
                using (var g = Graphics.FromImage(BMP))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, new Size(Params.Width, Params.Height), CopyPixelOperation.SourceCopy);

                    g.Flush();

                    var bits = BMP.LockBits(new Rectangle(0, 0, Params.Width, Params.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
                    Marshal.Copy(bits.Scan0, Buffer, 0, Buffer.Length);
                    BMP.UnlockBits(bits);
                }
            }
        }
    }
}

