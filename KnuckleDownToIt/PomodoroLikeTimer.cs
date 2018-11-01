using System;
using System.Media;
using System.Windows.Forms;
using System.Threading;

namespace KnuckleDownToIt
{
    class PomodoroLikeTimer
    {
        int timeToRest = 27;
        int timeToWork = 52;

        private SoundPlayer soundPlr;
        private readonly Button btnStart;
        private readonly System.Windows.Forms.Timer pomodoroTimerCountdown;

        public PomodoroLikeTimer(Button button)
        {
            pomodoroTimerCountdown = new System.Windows.Forms.Timer();
            pomodoroTimerCountdown.Tick += DoOnPomodoroTick;
            pomodoroTimerCountdown.Interval = 60000;

            btnStart = button;
        }

        public void StartTimer(string message)
        {
            MessageBox.Show("Now work for 52 minutes!", "Wait for the signal to stop working!");
            pomodoroTimerCountdown.Start();
            btnStart.Hide();
        }

        public void StopTimer()
        {
            btnStart.Visible = true;
            pomodoroTimerCountdown.Stop();
        }

        public void DoOnPomodoroTick(object sender, EventArgs e)
        {
            if (timeToWork > 0)
            {
                timeToWork--;
            }
            else if (timeToWork == 0)
            {
                timeToWork--;
                new Thread(new ThreadStart(delegate
                {
                    MessageBox.Show("Time to rest");
                    soundPlr.Stop();
                }))
                .Start();
            }

            if (timeToWork == -1 && timeToRest > 0)
            {
                timeToRest--;
            }
            else if (timeToWork == -1 && timeToRest == 0)
            {
                new Thread(new ThreadStart(delegate
                {
                    MessageBox.Show("The rest's over");
                    soundPlr.Stop();

                }))
                .Start();

                soundPlr = new SoundPlayer(@"Resources\Alarm.wav");
                soundPlr.Play();
                btnStart.Visible = true;
                pomodoroTimerCountdown.Stop();
            }
        }

    }
}
