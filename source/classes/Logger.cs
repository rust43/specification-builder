using System;

namespace SpecificationBuilder
{
    public enum LogLevel
    {
        Error,
        Attention,
        Usual,
        Good
    }

    public class Logger
    {
        private System.Windows.Forms.ListView journal;

        public Logger(System.Windows.Forms.ListView journal)
        {
            this.journal = journal;
            journal.Resize += Journal_Resize;
        }

        private void Journal_Resize(object sender, EventArgs e)
        {
            journal.Columns[0].Width = journal.Width - 21;
        }

        public void AppendToLog(string text, LogLevel level = LogLevel.Usual)
        {
            if (journal.InvokeRequired)
            {
                journal.Invoke(new Action<string, LogLevel>(AppendToLog), new object[] { text, level });
                return;
            }
            else
            {
                journal.BeginUpdate();

                var item = new System.Windows.Forms.ListViewItem()
                {
                    Text = DateTime.Now.ToString("HH:mm:ss - ") + text + "\r\n"
                };
                if (level == LogLevel.Error)
                    item.BackColor = System.Drawing.Color.LightCoral;
                if (level == LogLevel.Good)
                    item.BackColor = System.Drawing.Color.LightGreen;
                if (level == LogLevel.Attention)
                    item.BackColor = System.Drawing.Color.Yellow;
                if (level == LogLevel.Usual)
                    item.BackColor = System.Drawing.Color.White;
                journal.Items.Add(item);

                journal.Items[journal.Items.Count - 1].EnsureVisible();
                journal.EndUpdate();
            }
        }
    }
}
