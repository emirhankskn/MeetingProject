namespace meetingProject
{
    partial class meetingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meetingForm));
            this.exitTopRight = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnMeetingAnalysis = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOldRecords = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSpeechToText = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTranslateFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowSpeakers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitTopRight)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitTopRight
            // 
            this.exitTopRight.Image = ((System.Drawing.Image)(resources.GetObject("exitTopRight.Image")));
            this.exitTopRight.Location = new System.Drawing.Point(838, 2);
            this.exitTopRight.Name = "exitTopRight";
            this.exitTopRight.Size = new System.Drawing.Size(38, 38);
            this.exitTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitTopRight.TabIndex = 3;
            this.exitTopRight.TabStop = false;
            this.exitTopRight.Click += new System.EventHandler(this.exitTopRight_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMain.Controls.Add(this.btnShowSpeakers);
            this.panelMain.Controls.Add(this.progressBar1);
            this.panelMain.Controls.Add(this.btnStop);
            this.panelMain.Controls.Add(this.btnRecord);
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.panelNavBar);
            this.panelMain.Controls.Add(this.panel6);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1128, 721);
            this.panelMain.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(250, 711);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(879, 10);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Maroon;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(436, 478);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 49);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecord.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecord.Location = new System.Drawing.Point(298, 478);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(119, 49);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 394);
            this.dataGridView1.TabIndex = 5;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelNavBar.Controls.Add(this.btnMeetingAnalysis);
            this.panelNavBar.Controls.Add(this.panel5);
            this.panelNavBar.Controls.Add(this.btnOldRecords);
            this.panelNavBar.Controls.Add(this.panel4);
            this.panelNavBar.Controls.Add(this.btnSpeechToText);
            this.panelNavBar.Controls.Add(this.panel3);
            this.panelNavBar.Controls.Add(this.btnBack);
            this.panelNavBar.Controls.Add(this.btnTranslateFile);
            this.panelNavBar.Controls.Add(this.panel2);
            this.panelNavBar.Controls.Add(this.btnMeeting);
            this.panelNavBar.Controls.Add(this.panel1);
            this.panelNavBar.Controls.Add(this.pictureBox1);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(250, 721);
            this.panelNavBar.TabIndex = 0;
            // 
            // btnMeetingAnalysis
            // 
            this.btnMeetingAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeetingAnalysis.FlatAppearance.BorderSize = 0;
            this.btnMeetingAnalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMeetingAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeetingAnalysis.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMeetingAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnMeetingAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnMeetingAnalysis.Image")));
            this.btnMeetingAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeetingAnalysis.Location = new System.Drawing.Point(0, 555);
            this.btnMeetingAnalysis.Name = "btnMeetingAnalysis";
            this.btnMeetingAnalysis.Size = new System.Drawing.Size(250, 94);
            this.btnMeetingAnalysis.TabIndex = 12;
            this.btnMeetingAnalysis.Text = "Meeting Analysis";
            this.btnMeetingAnalysis.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 545);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 10);
            this.panel5.TabIndex = 11;
            // 
            // btnOldRecords
            // 
            this.btnOldRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOldRecords.FlatAppearance.BorderSize = 0;
            this.btnOldRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnOldRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOldRecords.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOldRecords.ForeColor = System.Drawing.Color.White;
            this.btnOldRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnOldRecords.Image")));
            this.btnOldRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOldRecords.Location = new System.Drawing.Point(0, 451);
            this.btnOldRecords.Name = "btnOldRecords";
            this.btnOldRecords.Size = new System.Drawing.Size(250, 94);
            this.btnOldRecords.TabIndex = 10;
            this.btnOldRecords.Text = "Old Records";
            this.btnOldRecords.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 441);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 10);
            this.panel4.TabIndex = 9;
            // 
            // btnSpeechToText
            // 
            this.btnSpeechToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpeechToText.FlatAppearance.BorderSize = 0;
            this.btnSpeechToText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSpeechToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeechToText.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpeechToText.ForeColor = System.Drawing.Color.White;
            this.btnSpeechToText.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeechToText.Image")));
            this.btnSpeechToText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeechToText.Location = new System.Drawing.Point(0, 347);
            this.btnSpeechToText.Name = "btnSpeechToText";
            this.btnSpeechToText.Size = new System.Drawing.Size(250, 94);
            this.btnSpeechToText.TabIndex = 8;
            this.btnSpeechToText.Text = "Speech To Text";
            this.btnSpeechToText.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 10);
            this.panel3.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 655);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 66);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTranslateFile
            // 
            this.btnTranslateFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTranslateFile.FlatAppearance.BorderSize = 0;
            this.btnTranslateFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnTranslateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslateFile.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTranslateFile.ForeColor = System.Drawing.Color.White;
            this.btnTranslateFile.Image = ((System.Drawing.Image)(resources.GetObject("btnTranslateFile.Image")));
            this.btnTranslateFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranslateFile.Location = new System.Drawing.Point(0, 243);
            this.btnTranslateFile.Name = "btnTranslateFile";
            this.btnTranslateFile.Size = new System.Drawing.Size(250, 94);
            this.btnTranslateFile.TabIndex = 5;
            this.btnTranslateFile.Text = "Translate File";
            this.btnTranslateFile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 10);
            this.panel2.TabIndex = 4;
            // 
            // btnMeeting
            // 
            this.btnMeeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeeting.FlatAppearance.BorderSize = 0;
            this.btnMeeting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeeting.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMeeting.ForeColor = System.Drawing.Color.White;
            this.btnMeeting.Image = ((System.Drawing.Image)(resources.GetObject("btnMeeting.Image")));
            this.btnMeeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeeting.Location = new System.Drawing.Point(0, 139);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(250, 94);
            this.btnMeeting.TabIndex = 2;
            this.btnMeeting.Text = "Meeting";
            this.btnMeeting.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 10);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel6.Controls.Add(this.exitTopRight);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(250, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(879, 43);
            this.panel6.TabIndex = 4;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speech To Text App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowSpeakers
            // 
            this.btnShowSpeakers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowSpeakers.FlatAppearance.BorderSize = 0;
            this.btnShowSpeakers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowSpeakers.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowSpeakers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowSpeakers.Location = new System.Drawing.Point(985, 640);
            this.btnShowSpeakers.Name = "btnShowSpeakers";
            this.btnShowSpeakers.Size = new System.Drawing.Size(119, 49);
            this.btnShowSpeakers.TabIndex = 9;
            this.btnShowSpeakers.Text = "Manage Speakers";
            this.btnShowSpeakers.UseVisualStyleBackColor = false;
            // 
            // meetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 721);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "meetingForm";
            this.Text = "meetingForm";
            ((System.ComponentModel.ISupportInitialize)(this.exitTopRight)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitTopRight;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button btnMeetingAnalysis;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnOldRecords;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSpeechToText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTranslateFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnShowSpeakers;
    }
}