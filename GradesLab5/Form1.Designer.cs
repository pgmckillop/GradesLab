namespace GradesLab5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTargetGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUCASPoints = new System.Windows.Forms.TextBox();
            this.txtCoursePoints = new System.Windows.Forms.TextBox();
            this.txtCourseUnits = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSendEmail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnitsLeft = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPointsEarned = new System.Windows.Forms.TextBox();
            this.txtDistinctionsHave = new System.Windows.Forms.TextBox();
            this.txtMeritsHave = new System.Windows.Forms.TextBox();
            this.txtPassesHave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCanMeetWith = new System.Windows.Forms.Label();
            this.lblWithGradeCounts = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPassNeeded = new System.Windows.Forms.TextBox();
            this.txtDistinctionNeeded = new System.Windows.Forms.TextBox();
            this.txtMeritNeeded = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxtAllProfiles = new System.Windows.Forms.RichTextBox();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStudRef = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCourse
            // 
            this.cboCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Items.AddRange(new object[] {
            "Certificate [3 units]",
            "Subsidiary Diploma [6 units]",
            "90 Credit Diploma [9 units]",
            "Diploma [12 units]",
            "Extended Diploma [18 units]"});
            this.cboCourse.Location = new System.Drawing.Point(12, 104);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(263, 24);
            this.cboCourse.TabIndex = 0;
            this.cboCourse.TabStop = false;
            this.cboCourse.Tag = "Course";
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "10 Credit units in course";
            // 
            // cboTargetGrade
            // 
            this.cboTargetGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTargetGrade.FormattingEnabled = true;
            this.cboTargetGrade.Location = new System.Drawing.Point(12, 184);
            this.cboTargetGrade.Name = "cboTargetGrade";
            this.cboTargetGrade.Size = new System.Drawing.Size(139, 24);
            this.cboTargetGrade.TabIndex = 1;
            this.cboTargetGrade.TabStop = false;
            this.cboTargetGrade.Tag = "Target grade";
            this.cboTargetGrade.SelectedIndexChanged += new System.EventHandler(this.cboTargetGrade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select your Target Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "UCAS Points through that grade";
            // 
            // txtUCASPoints
            // 
            this.txtUCASPoints.Enabled = false;
            this.txtUCASPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCASPoints.Location = new System.Drawing.Point(223, 217);
            this.txtUCASPoints.Name = "txtUCASPoints";
            this.txtUCASPoints.Size = new System.Drawing.Size(52, 20);
            this.txtUCASPoints.TabIndex = 8;
            this.txtUCASPoints.TabStop = false;
            this.txtUCASPoints.Text = "0";
            this.txtUCASPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCoursePoints
            // 
            this.txtCoursePoints.Enabled = false;
            this.txtCoursePoints.Location = new System.Drawing.Point(223, 184);
            this.txtCoursePoints.Name = "txtCoursePoints";
            this.txtCoursePoints.Size = new System.Drawing.Size(52, 20);
            this.txtCoursePoints.TabIndex = 9;
            this.txtCoursePoints.TabStop = false;
            this.txtCoursePoints.Text = "0";
            this.txtCoursePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCourseUnits
            // 
            this.txtCourseUnits.Enabled = false;
            this.txtCourseUnits.Location = new System.Drawing.Point(223, 136);
            this.txtCourseUnits.Name = "txtCourseUnits";
            this.txtCourseUnits.Size = new System.Drawing.Size(52, 20);
            this.txtCourseUnits.TabIndex = 10;
            this.txtCourseUnits.TabStop = false;
            this.txtCourseUnits.Text = "0";
            this.txtCourseUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDataToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearDataToolStripMenuItem.Text = "Clear data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpPageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpPageToolStripMenuItem
            // 
            this.helpPageToolStripMenuItem.Name = "helpPageToolStripMenuItem";
            this.helpPageToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.helpPageToolStripMenuItem.Text = "Help page";
            this.helpPageToolStripMenuItem.Click += new System.EventHandler(this.helpPageToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 78);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(571, 32);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(249, 20);
            this.txtEmailTo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email to";
            // 
            // cmdSendEmail
            // 
            this.cmdSendEmail.Location = new System.Drawing.Point(826, 30);
            this.cmdSendEmail.Name = "cmdSendEmail";
            this.cmdSendEmail.Size = new System.Drawing.Size(48, 21);
            this.cmdSendEmail.TabIndex = 7;
            this.cmdSendEmail.TabStop = false;
            this.cmdSendEmail.Text = "Send";
            this.cmdSendEmail.UseVisualStyleBackColor = true;
            this.cmdSendEmail.Click += new System.EventHandler(this.cmdSendEmail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtUnitsLeft);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPointsEarned);
            this.panel1.Controls.Add(this.txtDistinctionsHave);
            this.panel1.Controls.Add(this.txtMeritsHave);
            this.panel1.Controls.Add(this.txtPassesHave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 143);
            this.panel1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 7);
            this.label12.MaximumSize = new System.Drawing.Size(47, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 39);
            this.label12.TabIndex = 20;
            this.label12.Text = "Course Units Left";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitsLeft
            // 
            this.txtUnitsLeft.Enabled = false;
            this.txtUnitsLeft.Location = new System.Drawing.Point(207, 49);
            this.txtUnitsLeft.Name = "txtUnitsLeft";
            this.txtUnitsLeft.Size = new System.Drawing.Size(45, 20);
            this.txtUnitsLeft.TabIndex = 19;
            this.txtUnitsLeft.TabStop = false;
            this.txtUnitsLeft.Text = "0";
            this.txtUnitsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 72);
            this.label10.MaximumSize = new System.Drawing.Size(47, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 39);
            this.label10.TabIndex = 18;
            this.label10.Text = "Course Points Earned";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPointsEarned
            // 
            this.txtPointsEarned.Enabled = false;
            this.txtPointsEarned.Location = new System.Drawing.Point(207, 114);
            this.txtPointsEarned.Name = "txtPointsEarned";
            this.txtPointsEarned.Size = new System.Drawing.Size(45, 20);
            this.txtPointsEarned.TabIndex = 17;
            this.txtPointsEarned.TabStop = false;
            this.txtPointsEarned.Text = "0";
            this.txtPointsEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDistinctionsHave
            // 
            this.txtDistinctionsHave.Location = new System.Drawing.Point(104, 90);
            this.txtDistinctionsHave.Name = "txtDistinctionsHave";
            this.txtDistinctionsHave.Size = new System.Drawing.Size(46, 20);
            this.txtDistinctionsHave.TabIndex = 4;
            this.txtDistinctionsHave.Tag = "Current Distinction grades";
            this.txtDistinctionsHave.Text = "0";
            this.txtDistinctionsHave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDistinctionsHave.TextChanged += new System.EventHandler(this.txtDistinctionsHave_TextChanged);
            this.txtDistinctionsHave.Enter += new System.EventHandler(this.txtDistinctionsHave_Enter);
            // 
            // txtMeritsHave
            // 
            this.txtMeritsHave.Location = new System.Drawing.Point(104, 58);
            this.txtMeritsHave.Name = "txtMeritsHave";
            this.txtMeritsHave.Size = new System.Drawing.Size(46, 20);
            this.txtMeritsHave.TabIndex = 3;
            this.txtMeritsHave.Tag = "Current Merit grades";
            this.txtMeritsHave.Text = "0";
            this.txtMeritsHave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMeritsHave.TextChanged += new System.EventHandler(this.txtMeritsHave_TextChanged);
            this.txtMeritsHave.Enter += new System.EventHandler(this.txtMeritsHave_Enter);
            // 
            // txtPassesHave
            // 
            this.txtPassesHave.Location = new System.Drawing.Point(104, 26);
            this.txtPassesHave.Name = "txtPassesHave";
            this.txtPassesHave.Size = new System.Drawing.Size(46, 20);
            this.txtPassesHave.TabIndex = 2;
            this.txtPassesHave.Tag = "Current Pass grades";
            this.txtPassesHave.Text = "0";
            this.txtPassesHave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassesHave.TextChanged += new System.EventHandler(this.txtPassesHave_TextChanged);
            this.txtPassesHave.Enter += new System.EventHandler(this.txtPassesHave_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Merits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Distinctions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Passes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter your current grades";
            // 
            // lblCanMeetWith
            // 
            this.lblCanMeetWith.AutoSize = true;
            this.lblCanMeetWith.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCanMeetWith.Location = new System.Drawing.Point(300, 106);
            this.lblCanMeetWith.Name = "lblCanMeetWith";
            this.lblCanMeetWith.Size = new System.Drawing.Size(175, 13);
            this.lblCanMeetWith.TabIndex = 17;
            this.lblCanMeetWith.Text = "The Target Grade can be achieved";
            this.lblCanMeetWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCanMeetWith.UseWaitCursor = true;
            // 
            // lblWithGradeCounts
            // 
            this.lblWithGradeCounts.AutoSize = true;
            this.lblWithGradeCounts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblWithGradeCounts.Location = new System.Drawing.Point(327, 121);
            this.lblWithGradeCounts.Name = "lblWithGradeCounts";
            this.lblWithGradeCounts.Size = new System.Drawing.Size(120, 13);
            this.lblWithGradeCounts.TabIndex = 18;
            this.lblWithGradeCounts.Text = "with these grade counts";
            this.lblWithGradeCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(298, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "P:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(360, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "M:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(428, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "D:";
            // 
            // txtPassNeeded
            // 
            this.txtPassNeeded.Enabled = false;
            this.txtPassNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNeeded.Location = new System.Drawing.Point(320, 144);
            this.txtPassNeeded.Name = "txtPassNeeded";
            this.txtPassNeeded.Size = new System.Drawing.Size(30, 20);
            this.txtPassNeeded.TabIndex = 22;
            this.txtPassNeeded.TabStop = false;
            this.txtPassNeeded.Text = "0";
            this.txtPassNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDistinctionNeeded
            // 
            this.txtDistinctionNeeded.Enabled = false;
            this.txtDistinctionNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistinctionNeeded.Location = new System.Drawing.Point(451, 144);
            this.txtDistinctionNeeded.Name = "txtDistinctionNeeded";
            this.txtDistinctionNeeded.Size = new System.Drawing.Size(30, 20);
            this.txtDistinctionNeeded.TabIndex = 23;
            this.txtDistinctionNeeded.TabStop = false;
            this.txtDistinctionNeeded.Text = "0";
            this.txtDistinctionNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMeritNeeded
            // 
            this.txtMeritNeeded.Enabled = false;
            this.txtMeritNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeritNeeded.Location = new System.Drawing.Point(385, 144);
            this.txtMeritNeeded.Name = "txtMeritNeeded";
            this.txtMeritNeeded.Size = new System.Drawing.Size(30, 20);
            this.txtMeritNeeded.TabIndex = 24;
            this.txtMeritNeeded.TabStop = false;
            this.txtMeritNeeded.Text = "0";
            this.txtMeritNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(1, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 32);
            this.panel2.TabIndex = 26;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(288, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 49);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Location = new System.Drawing.Point(288, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 66);
            this.panel3.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Course points";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtxtAllProfiles
            // 
            this.rtxtAllProfiles.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rtxtAllProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtAllProfiles.Enabled = false;
            this.rtxtAllProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAllProfiles.Location = new System.Drawing.Point(288, 187);
            this.rtxtAllProfiles.Name = "rtxtAllProfiles";
            this.rtxtAllProfiles.Size = new System.Drawing.Size(200, 125);
            this.rtxtAllProfiles.TabIndex = 30;
            this.rtxtAllProfiles.Text = "Alternative profiles";
            this.rtxtAllProfiles.UseWaitCursor = true;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(537, 102);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(337, 200);
            this.rtxtNotes.TabIndex = 31;
            this.rtxtNotes.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(534, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Tutorial notes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(288, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Profile with the most Passes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Student No.";
            // 
            // txtStudRef
            // 
            this.txtStudRef.Location = new System.Drawing.Point(91, 32);
            this.txtStudRef.Name = "txtStudRef";
            this.txtStudRef.Size = new System.Drawing.Size(89, 20);
            this.txtStudRef.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(192, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Name";
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(237, 32);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(251, 20);
            this.txtStudName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 403);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.txtStudRef);
            this.Controls.Add(this.rtxtAllProfiles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmdSendEmail);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMeritNeeded);
            this.Controls.Add(this.txtDistinctionNeeded);
            this.Controls.Add(this.txtPassNeeded);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblWithGradeCounts);
            this.Controls.Add(this.lblCanMeetWith);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCourseUnits);
            this.Controls.Add(this.txtCoursePoints);
            this.Controls.Add(this.txtUCASPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTargetGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Pathways BTEC Level 3 QCF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTargetGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUCASPoints;
        private System.Windows.Forms.TextBox txtCoursePoints;
        private System.Windows.Forms.TextBox txtCourseUnits;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdSendEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPointsEarned;
        private System.Windows.Forms.TextBox txtDistinctionsHave;
        private System.Windows.Forms.TextBox txtMeritsHave;
        private System.Windows.Forms.TextBox txtPassesHave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCanMeetWith;
        private System.Windows.Forms.Label lblWithGradeCounts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPassNeeded;
        private System.Windows.Forms.TextBox txtDistinctionNeeded;
        private System.Windows.Forms.TextBox txtMeritNeeded;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnitsLeft;
        private System.Windows.Forms.RichTextBox rtxtAllProfiles;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtStudRef;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem helpPageToolStripMenuItem;
    }
}

