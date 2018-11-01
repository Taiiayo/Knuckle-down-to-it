using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnuckleDownToIt
{
    public partial class TheForm : Form
    {
        readonly Random random = new Random();
        readonly StandardTimer standardTimer;
        readonly PomodoroLikeTimer pomodoroLikeTimer;
        private readonly BlacklistManager blacklistManager;

        public TheForm()
        { 
            InitializeComponent();
            standardTimer = new StandardTimer(btnStart, timeViewLabel, this);
            pomodoroLikeTimer = new PomodoroLikeTimer(btnStart);
            blacklistManager = new BlacklistManager(textBoxURLtoBlock, listBoxBlackList);
        }

        private void radBtn_1hour_CheckedChanged(object sender, EventArgs e)
        {
            numUpDHours.Increment = 1;
        }

        private void radBtn_5hours_CheckedChanged(object sender, EventArgs e)
        {
            numUpDHours.Increment = 5;
        }

        private void radBtn_1min_CheckedChanged(object sender, EventArgs e)
        {
            numUpDMinutes.Increment = 1; 
        }

        private void radBtn_10min_CheckedChanged(object sender, EventArgs e)
        {
            numUpDMinutes.Increment = 10;
        }

        private void radBtn_1sec_CheckedChanged(object sender, EventArgs e)
        {
            numUpDSeconds.Increment = 1;
        }

        private void radBtn_10sec_CheckedChanged(object sender, EventArgs e)
        {
            numUpDSeconds.Increment = 10;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            numUpDHours.Enabled = false;
            numUpDMinutes.Enabled = false;
            numUpDSeconds.Enabled = false;
            radBtn_1sec.Enabled = false;
            radBtn_10sec.Enabled = false;
            radBtn_1min.Enabled = false;
            radBtn_10min.Enabled = false;
            radBtn_1hour.Enabled = false;
            radBtn_5hours.Enabled = false;
            checkBoxPomoTimer.Enabled = false;

            if (checkBoxPomoTimer.Checked)
            {
                timeViewLabel.Enabled = false;
                pomodoroLikeTimer.StartTimer(btnStart.Text);
            }
            else
            {
                standardTimer.StartTimer(btnStart.Text, (int)numUpDHours.Value, (int)numUpDMinutes.Value, (int)numUpDSeconds.Value);                
            }
                                    
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            numUpDHours.Enabled = true;
            numUpDMinutes.Enabled = true;
            numUpDSeconds.Enabled = true;
            radBtn_1sec.Enabled = true;
            radBtn_10sec.Enabled = true;
            radBtn_1min.Enabled = true;
            radBtn_10min.Enabled = true;
            radBtn_1hour.Enabled = true;
            radBtn_5hours.Enabled = true;
            checkBoxPomoTimer.Enabled = true;

            if (checkBoxPomoTimer.Checked)
            {
                timeViewLabel.Enabled = true;
                pomodoroLikeTimer.StopTimer();
            }
            else
            {
                standardTimer.StopTimer();                
            }
        }

        // - Eagle/Tails

        private void btnEagleTails_Click(object sender, EventArgs e)
        {

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                int number = random.Next(1, 3);
                string eagleOrTails = number == 1 ? "Eagle" : "Tails";
                labelEagleTails.BeginInvoke(new Action(() => { labelEagleTails.Text = eagleOrTails; }));
            });
        }

        // - WebBlock

        private void btnStartSafeBrowser_Click(object sender, EventArgs e)
        {
            blacklistManager.StartSafeChrome();
        }

        private void btnDeleteFromBlackList_Click(object sender, EventArgs e)
        {
            blacklistManager.DeleteFromList();
        }

        private void btnAddToBlackList_Click(object sender, EventArgs e)
        {
            blacklistManager.AddToList();
        }

        private void btnCreateBlackList_Click(object sender, EventArgs e)
        {
            blacklistManager.SaveTheBlacklist();
        }

        private void btnLoadBlackList_Click(object sender, EventArgs e)
        {
            blacklistManager.LoadTheBlackList();
        }

        
    }
}
