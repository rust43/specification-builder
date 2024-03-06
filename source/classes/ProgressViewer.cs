using System;
using System.Diagnostics;

namespace SpecificationBuilder
{
    public class ProgressViewer
    {
        private double step;
        private int progressBarWidth;
        private int totalProgressValue;
        private double currentProgressValue;

        private System.Timers.Timer progressTimer;
        private Stopwatch progressStopwatch;
        private System.Windows.Forms.Panel pnlForProgress;

        public ProgressViewer(int totalProgressValue, System.Windows.Forms.Panel panel)
        {
            currentProgressValue = 0;

            progressBarWidth = panel.Width;
            this.totalProgressValue = totalProgressValue;
            pnlForProgress = panel;

            step = (double)progressBarWidth / (double)totalProgressValue;
            SetProgress(0);
        }

        public void StartProgress()
        {
            ShowProgressPanel();

            progressStopwatch = new Stopwatch();
            progressStopwatch.Start();

            progressTimer = new System.Timers.Timer(10);
            progressTimer.Enabled = true;
            progressTimer.Elapsed += new System.Timers.ElapsedEventHandler(ProgressTimer_Tick);
            progressTimer.Start();
        }

        public void StopProgress()
        {
            HideProgressPanel();
            progressTimer.Stop();
            progressStopwatch.Stop();
            SetProgress(progressBarWidth);
        }

        private void SetProgress(int value)
        {
            System.Windows.Forms.Panel pnlProgress = (System.Windows.Forms.Panel)pnlForProgress.Controls[0];
            if (pnlProgress.InvokeRequired)
                pnlProgress.Invoke(new Action<int>(SetProgress), new object[] { value });
            else
                pnlProgress.Width = value;
        }

        private void ProgressTimer_Tick(object sender, System.EventArgs e)
        {
            int progress = (int)(currentProgressValue * totalProgressValue / progressBarWidth);
            SetProgress((int)(currentProgressValue));
        }

        public void MakeProgress()
        {
            currentProgressValue += step;
        }

        public string Finish()
        {
            string elapsedSeconds = progressStopwatch.Elapsed.TotalSeconds.ToString("0.00");

            if (progressTimer != null)
                progressTimer = null;
            if (progressStopwatch != null)
                progressStopwatch = null;

            return elapsedSeconds;
        }

        private void ShowProgressPanel()
        {
            if (pnlForProgress.InvokeRequired)
                pnlForProgress.Invoke(new Action(ShowProgressPanel), new object[] { });
            else pnlForProgress.Height = 15;
        }

        private void HideProgressPanel()
        {
            if (pnlForProgress.InvokeRequired)
                pnlForProgress.Invoke(new Action(HideProgressPanel), new object[] { });
            else pnlForProgress.Height = 0;
        }

        public void ProgressBarResized()
        {
            double currentProgress = currentProgressValue / step;

            progressBarWidth = pnlForProgress.Width;
            step = progressBarWidth / totalProgressValue;
            currentProgressValue = currentProgress * step;
        }

        //public string ProgressResult { get { return currentProgressValue.ToString(); } }

        //public string ElapsedSeconds { get { return progressStopwatch.Elapsed.TotalSeconds.ToString("0.00"); } }
    }
}
