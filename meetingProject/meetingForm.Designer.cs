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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meetingForm));
            this.exitTopRight = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.rTxtMeetingSubject = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeetingTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblErrorSelectFolder = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.browseFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnShowSpeakers = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.exitTopRight)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.pnlAdd.SuspendLayout();
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
            this.panelMain.Controls.Add(this.pnlAdd);
            this.panelMain.Controls.Add(this.lblTimer);
            this.panelMain.Controls.Add(this.lblErrorSelectFolder);
            this.panelMain.Controls.Add(this.txtOutputFolder);
            this.panelMain.Controls.Add(this.browseFolder);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.btnStop);
            this.panelMain.Controls.Add(this.btnRecord);
            this.panelMain.Controls.Add(this.btnShowSpeakers);
            this.panelMain.Controls.Add(this.progressBar1);
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.panelNavBar);
            this.panelMain.Controls.Add(this.panel6);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1128, 721);
            this.panelMain.TabIndex = 2;
            // 
            // rTxtMeetingSubject
            // 
            this.rTxtMeetingSubject.Location = new System.Drawing.Point(79, 49);
            this.rTxtMeetingSubject.Name = "rTxtMeetingSubject";
            this.rTxtMeetingSubject.Size = new System.Drawing.Size(296, 45);
            this.rTxtMeetingSubject.TabIndex = 18;
            this.rTxtMeetingSubject.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Subject :";
            // 
            // txtMeetingTitle
            // 
            this.txtMeetingTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMeetingTitle.Location = new System.Drawing.Point(79, 14);
            this.txtMeetingTitle.Name = "txtMeetingTitle";
            this.txtMeetingTitle.Size = new System.Drawing.Size(296, 23);
            this.txtMeetingTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Title :";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(530, 628);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(21, 25);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "0";
            this.lblTimer.Visible = false;
            // 
            // lblErrorSelectFolder
            // 
            this.lblErrorSelectFolder.AutoSize = true;
            this.lblErrorSelectFolder.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErrorSelectFolder.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorSelectFolder.Location = new System.Drawing.Point(312, 670);
            this.lblErrorSelectFolder.Name = "lblErrorSelectFolder";
            this.lblErrorSelectFolder.Size = new System.Drawing.Size(182, 19);
            this.lblErrorSelectFolder.TabIndex = 13;
            this.lblErrorSelectFolder.Text = "Please select output folder first !";
            this.lblErrorSelectFolder.Visible = false;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutputFolder.Location = new System.Drawing.Point(280, 579);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(244, 23);
            this.txtOutputFolder.TabIndex = 12;
            // 
            // browseFolder
            // 
            this.browseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browseFolder.FlatAppearance.BorderSize = 0;
            this.browseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseFolder.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.browseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.browseFolder.Location = new System.Drawing.Point(434, 530);
            this.browseFolder.Name = "browseFolder";
            this.browseFolder.Size = new System.Drawing.Size(70, 31);
            this.browseFolder.TabIndex = 11;
            this.browseFolder.Text = "Browse";
            this.browseFolder.UseVisualStyleBackColor = false;
            this.browseFolder.Click += new System.EventHandler(this.browseFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(288, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Output Folder : ";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Maroon;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(407, 618);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 49);
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
            this.btnRecord.Location = new System.Drawing.Point(280, 618);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(121, 49);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnShowSpeakers
            // 
            this.btnShowSpeakers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowSpeakers.FlatAppearance.BorderSize = 0;
            this.btnShowSpeakers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowSpeakers.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowSpeakers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowSpeakers.Location = new System.Drawing.Point(1035, 655);
            this.btnShowSpeakers.Name = "btnShowSpeakers";
            this.btnShowSpeakers.Size = new System.Drawing.Size(81, 49);
            this.btnShowSpeakers.TabIndex = 9;
            this.btnShowSpeakers.Text = "Manage Speakers";
            this.btnShowSpeakers.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(250, 711);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(879, 10);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnTitle,
            this.columnSubject,
            this.columnDuration,
            this.columnDate});
            this.dataGridView1.Location = new System.Drawing.Point(263, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 428);
            this.dataGridView1.TabIndex = 5;
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.Width = 43;
            // 
            // columnTitle
            // 
            this.columnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTitle.HeaderText = "Meeting Title";
            this.columnTitle.Name = "columnTitle";
            // 
            // columnSubject
            // 
            this.columnSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSubject.HeaderText = "Meeting Subject";
            this.columnSubject.Name = "columnSubject";
            // 
            // columnDuration
            // 
            this.columnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDuration.HeaderText = "Duration";
            this.columnDuration.Name = "columnDuration";
            // 
            // columnDate
            // 
            this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDate.HeaderText = "Recorded Date";
            this.columnDate.Name = "columnDate";
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
            this.panel6.Controls.Add(this.btnSettings);
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
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(794, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(38, 38);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 4;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(23, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(338, 33);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.rTxtMeetingSubject);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.txtMeetingTitle);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Location = new System.Drawing.Point(637, 530);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(392, 137);
            this.pnlAdd.TabIndex = 19;
            this.pnlAdd.Visible = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.meetingForm_FormClosing_1);
            this.Load += new System.EventHandler(this.meetingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitTopRight)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
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
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button browseFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblErrorSelectFolder;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeetingTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTxtMeetingSubject;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnAdd;
    }
}