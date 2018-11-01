namespace KnuckleDownToIt
{
    partial class TheForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tabPageTimer = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timeViewLabel = new System.Windows.Forms.Label();
            this.checkBoxPomoTimer = new System.Windows.Forms.CheckBox();
            this.groupBoxSeconds = new System.Windows.Forms.GroupBox();
            this.radBtn_10sec = new System.Windows.Forms.RadioButton();
            this.radBtn_1sec = new System.Windows.Forms.RadioButton();
            this.numUpDSeconds = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMinutes = new System.Windows.Forms.GroupBox();
            this.radBtn_10min = new System.Windows.Forms.RadioButton();
            this.radBtn_1min = new System.Windows.Forms.RadioButton();
            this.numUpDMinutes = new System.Windows.Forms.NumericUpDown();
            this.groupBoxHours = new System.Windows.Forms.GroupBox();
            this.numUpDHours = new System.Windows.Forms.NumericUpDown();
            this.radBtn_1hour = new System.Windows.Forms.RadioButton();
            this.radBtn_5hours = new System.Windows.Forms.RadioButton();
            this.tabPageWebBlock = new System.Windows.Forms.TabPage();
            this.btnCreateBlackList = new System.Windows.Forms.Button();
            this.btnLoadBlackList = new System.Windows.Forms.Button();
            this.btnAddToBlackList = new System.Windows.Forms.Button();
            this.textBoxURLtoBlock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartSafeBrowser = new System.Windows.Forms.Button();
            this.listBoxBlackList = new System.Windows.Forms.ListBox();
            this.btnDeleteFromBlackList = new System.Windows.Forms.Button();
            this.tabPageEaglesTails = new System.Windows.Forms.TabPage();
            this.labelEagleTails = new System.Windows.Forms.Label();
            this.btnEagleTails = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tabPageTimer.SuspendLayout();
            this.groupBoxSeconds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSeconds)).BeginInit();
            this.groupBoxMinutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutes)).BeginInit();
            this.groupBoxHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHours)).BeginInit();
            this.tabPageWebBlock.SuspendLayout();
            this.tabPageEaglesTails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Controls.Add(this.tabPageTimer);
            this.tabControl.Controls.Add(this.tabPageWebBlock);
            this.tabControl.Controls.Add(this.tabPageEaglesTails);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 339);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.textBox1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(488, 313);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tabPageTimer
            // 
            this.tabPageTimer.Controls.Add(this.btnStop);
            this.tabPageTimer.Controls.Add(this.btnStart);
            this.tabPageTimer.Controls.Add(this.timeViewLabel);
            this.tabPageTimer.Controls.Add(this.checkBoxPomoTimer);
            this.tabPageTimer.Controls.Add(this.groupBoxSeconds);
            this.tabPageTimer.Controls.Add(this.groupBoxMinutes);
            this.tabPageTimer.Controls.Add(this.groupBoxHours);
            this.tabPageTimer.Location = new System.Drawing.Point(4, 22);
            this.tabPageTimer.Name = "tabPageTimer";
            this.tabPageTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimer.Size = new System.Drawing.Size(488, 313);
            this.tabPageTimer.TabIndex = 1;
            this.tabPageTimer.Text = "Timer";
            this.tabPageTimer.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Tele-Marines", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(253, 245);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(192, 46);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Tele-Marines", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(40, 245);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(192, 46);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timeViewLabel
            // 
            this.timeViewLabel.Font = new System.Drawing.Font("Tele-Marines", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeViewLabel.Location = new System.Drawing.Point(115, 205);
            this.timeViewLabel.Name = "timeViewLabel";
            this.timeViewLabel.Size = new System.Drawing.Size(262, 27);
            this.timeViewLabel.TabIndex = 8;
            this.timeViewLabel.Text = "00 : 00 : 00";
            this.timeViewLabel.UseWaitCursor = true;
            // 
            // checkBoxPomoTimer
            // 
            this.checkBoxPomoTimer.AutoSize = true;
            this.checkBoxPomoTimer.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBoxPomoTimer.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPomoTimer.Location = new System.Drawing.Point(109, 162);
            this.checkBoxPomoTimer.Name = "checkBoxPomoTimer";
            this.checkBoxPomoTimer.Size = new System.Drawing.Size(258, 23);
            this.checkBoxPomoTimer.TabIndex = 11;
            this.checkBoxPomoTimer.Text = "52 / 27 timer";
            this.checkBoxPomoTimer.UseVisualStyleBackColor = true;
            // 
            // groupBoxSeconds
            // 
            this.groupBoxSeconds.Controls.Add(this.radBtn_10sec);
            this.groupBoxSeconds.Controls.Add(this.radBtn_1sec);
            this.groupBoxSeconds.Controls.Add(this.numUpDSeconds);
            this.groupBoxSeconds.Location = new System.Drawing.Point(318, 6);
            this.groupBoxSeconds.Name = "groupBoxSeconds";
            this.groupBoxSeconds.Size = new System.Drawing.Size(150, 125);
            this.groupBoxSeconds.TabIndex = 10;
            this.groupBoxSeconds.TabStop = false;
            this.groupBoxSeconds.Text = "seconds";
            // 
            // radBtn_10sec
            // 
            this.radBtn_10sec.AutoSize = true;
            this.radBtn_10sec.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_10sec.Location = new System.Drawing.Point(82, 82);
            this.radBtn_10sec.Name = "radBtn_10sec";
            this.radBtn_10sec.Size = new System.Drawing.Size(53, 23);
            this.radBtn_10sec.TabIndex = 2;
            this.radBtn_10sec.TabStop = true;
            this.radBtn_10sec.Text = "10";
            this.radBtn_10sec.UseVisualStyleBackColor = true;
            this.radBtn_10sec.CheckedChanged += new System.EventHandler(this.radBtn_10sec_CheckedChanged);
            // 
            // radBtn_1sec
            // 
            this.radBtn_1sec.AutoSize = true;
            this.radBtn_1sec.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_1sec.Location = new System.Drawing.Point(16, 82);
            this.radBtn_1sec.Name = "radBtn_1sec";
            this.radBtn_1sec.Size = new System.Drawing.Size(32, 23);
            this.radBtn_1sec.TabIndex = 1;
            this.radBtn_1sec.TabStop = true;
            this.radBtn_1sec.Text = "1";
            this.radBtn_1sec.UseVisualStyleBackColor = true;
            this.radBtn_1sec.CheckedChanged += new System.EventHandler(this.radBtn_1sec_CheckedChanged);
            // 
            // numUpDSeconds
            // 
            this.numUpDSeconds.Font = new System.Drawing.Font("Tele-Marines", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDSeconds.Location = new System.Drawing.Point(24, 19);
            this.numUpDSeconds.Name = "numUpDSeconds";
            this.numUpDSeconds.Size = new System.Drawing.Size(79, 32);
            this.numUpDSeconds.TabIndex = 0;
            // 
            // groupBoxMinutes
            // 
            this.groupBoxMinutes.Controls.Add(this.radBtn_10min);
            this.groupBoxMinutes.Controls.Add(this.radBtn_1min);
            this.groupBoxMinutes.Controls.Add(this.numUpDMinutes);
            this.groupBoxMinutes.Location = new System.Drawing.Point(162, 6);
            this.groupBoxMinutes.Name = "groupBoxMinutes";
            this.groupBoxMinutes.Size = new System.Drawing.Size(150, 125);
            this.groupBoxMinutes.TabIndex = 0;
            this.groupBoxMinutes.TabStop = false;
            this.groupBoxMinutes.Text = "minutes";
            // 
            // radBtn_10min
            // 
            this.radBtn_10min.AutoSize = true;
            this.radBtn_10min.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_10min.Location = new System.Drawing.Point(91, 82);
            this.radBtn_10min.Name = "radBtn_10min";
            this.radBtn_10min.Size = new System.Drawing.Size(53, 23);
            this.radBtn_10min.TabIndex = 2;
            this.radBtn_10min.TabStop = true;
            this.radBtn_10min.Text = "10";
            this.radBtn_10min.UseVisualStyleBackColor = true;
            this.radBtn_10min.CheckedChanged += new System.EventHandler(this.radBtn_10min_CheckedChanged);
            // 
            // radBtn_1min
            // 
            this.radBtn_1min.AutoSize = true;
            this.radBtn_1min.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_1min.Location = new System.Drawing.Point(17, 82);
            this.radBtn_1min.Name = "radBtn_1min";
            this.radBtn_1min.Size = new System.Drawing.Size(32, 23);
            this.radBtn_1min.TabIndex = 1;
            this.radBtn_1min.TabStop = true;
            this.radBtn_1min.Text = "1";
            this.radBtn_1min.UseVisualStyleBackColor = true;
            this.radBtn_1min.CheckedChanged += new System.EventHandler(this.radBtn_1min_CheckedChanged);
            // 
            // numUpDMinutes
            // 
            this.numUpDMinutes.Font = new System.Drawing.Font("Tele-Marines", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDMinutes.Location = new System.Drawing.Point(17, 19);
            this.numUpDMinutes.Name = "numUpDMinutes";
            this.numUpDMinutes.Size = new System.Drawing.Size(78, 32);
            this.numUpDMinutes.TabIndex = 0;
            // 
            // groupBoxHours
            // 
            this.groupBoxHours.Controls.Add(this.numUpDHours);
            this.groupBoxHours.Controls.Add(this.radBtn_1hour);
            this.groupBoxHours.Controls.Add(this.radBtn_5hours);
            this.groupBoxHours.Location = new System.Drawing.Point(6, 6);
            this.groupBoxHours.Name = "groupBoxHours";
            this.groupBoxHours.Size = new System.Drawing.Size(150, 125);
            this.groupBoxHours.TabIndex = 9;
            this.groupBoxHours.TabStop = false;
            this.groupBoxHours.Text = "hours";
            // 
            // numUpDHours
            // 
            this.numUpDHours.Font = new System.Drawing.Font("Tele-Marines", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDHours.Location = new System.Drawing.Point(19, 22);
            this.numUpDHours.Name = "numUpDHours";
            this.numUpDHours.Size = new System.Drawing.Size(80, 32);
            this.numUpDHours.TabIndex = 4;
            // 
            // radBtn_1hour
            // 
            this.radBtn_1hour.AutoSize = true;
            this.radBtn_1hour.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_1hour.Location = new System.Drawing.Point(19, 82);
            this.radBtn_1hour.Name = "radBtn_1hour";
            this.radBtn_1hour.Size = new System.Drawing.Size(32, 23);
            this.radBtn_1hour.TabIndex = 5;
            this.radBtn_1hour.TabStop = true;
            this.radBtn_1hour.Text = "1";
            this.radBtn_1hour.UseVisualStyleBackColor = true;
            this.radBtn_1hour.CheckedChanged += new System.EventHandler(this.radBtn_1hour_CheckedChanged);
            // 
            // radBtn_5hours
            // 
            this.radBtn_5hours.AutoSize = true;
            this.radBtn_5hours.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_5hours.Location = new System.Drawing.Point(85, 82);
            this.radBtn_5hours.Name = "radBtn_5hours";
            this.radBtn_5hours.Size = new System.Drawing.Size(48, 23);
            this.radBtn_5hours.TabIndex = 6;
            this.radBtn_5hours.TabStop = true;
            this.radBtn_5hours.Text = "5";
            this.radBtn_5hours.UseVisualStyleBackColor = true;
            this.radBtn_5hours.CheckedChanged += new System.EventHandler(this.radBtn_5hours_CheckedChanged);
            // 
            // tabPageWebBlock
            // 
            this.tabPageWebBlock.Controls.Add(this.btnCreateBlackList);
            this.tabPageWebBlock.Controls.Add(this.btnLoadBlackList);
            this.tabPageWebBlock.Controls.Add(this.btnAddToBlackList);
            this.tabPageWebBlock.Controls.Add(this.textBoxURLtoBlock);
            this.tabPageWebBlock.Controls.Add(this.label2);
            this.tabPageWebBlock.Controls.Add(this.label1);
            this.tabPageWebBlock.Controls.Add(this.btnStartSafeBrowser);
            this.tabPageWebBlock.Controls.Add(this.listBoxBlackList);
            this.tabPageWebBlock.Controls.Add(this.btnDeleteFromBlackList);
            this.tabPageWebBlock.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebBlock.Name = "tabPageWebBlock";
            this.tabPageWebBlock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebBlock.Size = new System.Drawing.Size(488, 313);
            this.tabPageWebBlock.TabIndex = 2;
            this.tabPageWebBlock.Text = "Web Block";
            this.tabPageWebBlock.UseVisualStyleBackColor = true;
            // 
            // btnCreateBlackList
            // 
            this.btnCreateBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateBlackList.Location = new System.Drawing.Point(161, 100);
            this.btnCreateBlackList.Name = "btnCreateBlackList";
            this.btnCreateBlackList.Size = new System.Drawing.Size(75, 39);
            this.btnCreateBlackList.TabIndex = 10;
            this.btnCreateBlackList.Text = "Create new list";
            this.btnCreateBlackList.UseVisualStyleBackColor = true;
            this.btnCreateBlackList.Click += new System.EventHandler(this.btnCreateBlackList_Click);
            // 
            // btnLoadBlackList
            // 
            this.btnLoadBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadBlackList.Location = new System.Drawing.Point(161, 145);
            this.btnLoadBlackList.Name = "btnLoadBlackList";
            this.btnLoadBlackList.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBlackList.TabIndex = 9;
            this.btnLoadBlackList.Text = "Load list";
            this.btnLoadBlackList.UseVisualStyleBackColor = true;
            this.btnLoadBlackList.Click += new System.EventHandler(this.btnLoadBlackList_Click);
            // 
            // btnAddToBlackList
            // 
            this.btnAddToBlackList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToBlackList.Location = new System.Drawing.Point(10, 52);
            this.btnAddToBlackList.Name = "btnAddToBlackList";
            this.btnAddToBlackList.Size = new System.Drawing.Size(133, 23);
            this.btnAddToBlackList.TabIndex = 8;
            this.btnAddToBlackList.Text = "Add to Blacklist";
            this.btnAddToBlackList.UseVisualStyleBackColor = true;
            this.btnAddToBlackList.Click += new System.EventHandler(this.btnAddToBlackList_Click);
            // 
            // textBoxURLtoBlock
            // 
            this.textBoxURLtoBlock.Location = new System.Drawing.Point(6, 26);
            this.textBoxURLtoBlock.Name = "textBoxURLtoBlock";
            this.textBoxURLtoBlock.Size = new System.Drawing.Size(216, 20);
            this.textBoxURLtoBlock.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Black list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL to block:";
            // 
            // btnStartSafeBrowser
            // 
            this.btnStartSafeBrowser.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnStartSafeBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartSafeBrowser.Location = new System.Drawing.Point(10, 238);
            this.btnStartSafeBrowser.Name = "btnStartSafeBrowser";
            this.btnStartSafeBrowser.Size = new System.Drawing.Size(113, 61);
            this.btnStartSafeBrowser.TabIndex = 4;
            this.btnStartSafeBrowser.Text = "Start browser";
            this.btnStartSafeBrowser.UseVisualStyleBackColor = true;
            this.btnStartSafeBrowser.Click += new System.EventHandler(this.btnStartSafeBrowser_Click);
            // 
            // listBoxBlackList
            // 
            this.listBoxBlackList.FormattingEnabled = true;
            this.listBoxBlackList.Location = new System.Drawing.Point(242, 22);
            this.listBoxBlackList.Name = "listBoxBlackList";
            this.listBoxBlackList.Size = new System.Drawing.Size(238, 277);
            this.listBoxBlackList.TabIndex = 2;
            // 
            // btnDeleteFromBlackList
            // 
            this.btnDeleteFromBlackList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFromBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteFromBlackList.Location = new System.Drawing.Point(164, 190);
            this.btnDeleteFromBlackList.Name = "btnDeleteFromBlackList";
            this.btnDeleteFromBlackList.Size = new System.Drawing.Size(72, 26);
            this.btnDeleteFromBlackList.TabIndex = 1;
            this.btnDeleteFromBlackList.Text = "Delete URL";
            this.btnDeleteFromBlackList.UseVisualStyleBackColor = true;
            this.btnDeleteFromBlackList.Click += new System.EventHandler(this.btnDeleteFromBlackList_Click);
            // 
            // tabPageEaglesTails
            // 
            this.tabPageEaglesTails.Controls.Add(this.labelEagleTails);
            this.tabPageEaglesTails.Controls.Add(this.btnEagleTails);
            this.tabPageEaglesTails.Location = new System.Drawing.Point(4, 22);
            this.tabPageEaglesTails.Name = "tabPageEaglesTails";
            this.tabPageEaglesTails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEaglesTails.Size = new System.Drawing.Size(488, 313);
            this.tabPageEaglesTails.TabIndex = 3;
            this.tabPageEaglesTails.Text = "Eagles/Tails";
            this.tabPageEaglesTails.UseVisualStyleBackColor = true;
            // 
            // labelEagleTails
            // 
            this.labelEagleTails.AutoSize = true;
            this.labelEagleTails.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEagleTails.Location = new System.Drawing.Point(113, 43);
            this.labelEagleTails.Name = "labelEagleTails";
            this.labelEagleTails.Size = new System.Drawing.Size(393, 115);
            this.labelEagleTails.TabIndex = 1;
            this.labelEagleTails.Text = "Eagle/Tails";
            // 
            // btnEagleTails
            // 
            this.btnEagleTails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEagleTails.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEagleTails.Location = new System.Drawing.Point(159, 181);
            this.btnEagleTails.Name = "btnEagleTails";
            this.btnEagleTails.Size = new System.Drawing.Size(158, 93);
            this.btnEagleTails.TabIndex = 0;
            this.btnEagleTails.Text = "Get my decision";
            this.btnEagleTails.UseVisualStyleBackColor = true;
            this.btnEagleTails.Click += new System.EventHandler(this.btnEagleTails_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 301);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 359);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TheForm";
            this.Text = "Knuckle down to it!";
            this.tabControl.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.tabPageTimer.ResumeLayout(false);
            this.tabPageTimer.PerformLayout();
            this.groupBoxSeconds.ResumeLayout(false);
            this.groupBoxSeconds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDSeconds)).EndInit();
            this.groupBoxMinutes.ResumeLayout(false);
            this.groupBoxMinutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinutes)).EndInit();
            this.groupBoxHours.ResumeLayout(false);
            this.groupBoxHours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHours)).EndInit();
            this.tabPageWebBlock.ResumeLayout(false);
            this.tabPageWebBlock.PerformLayout();
            this.tabPageEaglesTails.ResumeLayout(false);
            this.tabPageEaglesTails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TabPage tabPageTimer;
        private System.Windows.Forms.TabPage tabPageWebBlock;
        private System.Windows.Forms.TabPage tabPageEaglesTails;
        private System.Windows.Forms.Label labelEagleTails;
        private System.Windows.Forms.Button btnEagleTails;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label timeViewLabel;
        private System.Windows.Forms.CheckBox checkBoxPomoTimer;
        private System.Windows.Forms.GroupBox groupBoxSeconds;
        private System.Windows.Forms.RadioButton radBtn_10sec;
        private System.Windows.Forms.RadioButton radBtn_1sec;
        private System.Windows.Forms.NumericUpDown numUpDSeconds;
        private System.Windows.Forms.GroupBox groupBoxMinutes;
        private System.Windows.Forms.RadioButton radBtn_10min;
        private System.Windows.Forms.RadioButton radBtn_1min;
        private System.Windows.Forms.NumericUpDown numUpDMinutes;
        private System.Windows.Forms.GroupBox groupBoxHours;
        private System.Windows.Forms.NumericUpDown numUpDHours;
        private System.Windows.Forms.RadioButton radBtn_1hour;
        private System.Windows.Forms.RadioButton radBtn_5hours;
        private System.Windows.Forms.ListBox listBoxBlackList;
        private System.Windows.Forms.Button btnDeleteFromBlackList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartSafeBrowser;
        private System.Windows.Forms.Button btnAddToBlackList;
        private System.Windows.Forms.TextBox textBoxURLtoBlock;
        private System.Windows.Forms.Button btnCreateBlackList;
        private System.Windows.Forms.Button btnLoadBlackList;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox1;
    }
}

