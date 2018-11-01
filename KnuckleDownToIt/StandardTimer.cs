using System;
using System.Media;
using System.Windows.Forms;
using System.Threading;

namespace KnuckleDownToIt
{
    class StandardTimer
    {
        int numberCountDownSeconds;
        private SoundPlayer soundPlr;
        private readonly Button btnStart;
        private readonly Label timeViewLabel;
        private readonly TheForm form;

        private readonly System.Windows.Forms.Timer timerCountdown;

        public StandardTimer(Button button, Label label, TheForm form1)
        {
            timerCountdown = new System.Windows.Forms.Timer();
            timerCountdown.Tick += DoOnStandardTimerTick;
            timerCountdown.Interval = 1000;

            btnStart = button;
            timeViewLabel = label;
            form = form1;
        }

        public void StartTimer(string message, int nudHours, int nudMinutes, int nudSeconds)
        {
                numberCountDownSeconds = nudHours * 3600 +
                                    nudMinutes * 60 + nudSeconds;
            
                timerCountdown.Start();
                btnStart.Hide();            
        }

        public void StopTimer()
        {
            btnStart.Visible = true;
            timerCountdown.Stop();
        }

        public void DoOnStandardTimerTick(object sender, EventArgs e)
        {
            int numberHours, numberMinutes, numberSeconds, numberToWorkWith;
            string strHours, strMinutes, strSeconds, strDisplay;           

            numberHours = numberCountDownSeconds / 3600;
            numberToWorkWith = numberCountDownSeconds - (numberHours * 3600);

            numberMinutes = numberToWorkWith / 60;
            numberToWorkWith -= (numberMinutes * 60);

            numberSeconds = numberToWorkWith;
            strHours = numberHours.ToString("00");
            strMinutes = numberMinutes.ToString("00");
            strSeconds = numberSeconds.ToString("00");

            strDisplay = strHours + " : " + strMinutes + " : " +
                         strSeconds;
            timeViewLabel.Text = strDisplay;
            form.Text = strDisplay;

            numberCountDownSeconds--;
            if (numberCountDownSeconds <= -1)
            {
                timerCountdown.Stop();
           
                form.WindowState = FormWindowState.Normal;
              
                new Thread(new ThreadStart(delegate {
                    MessageBox.Show("Have a break");
                    soundPlr.Stop();
                }))
                    .Start();    
                
                soundPlr = new SoundPlayer(@"Resources\Alarm.wav");
                soundPlr.Play();
                btnStart.Visible = true;
                btnStart.Text = "Start";
            }
        }        
    }
}
