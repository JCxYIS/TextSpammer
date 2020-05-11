using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TextSpammer
{
    public partial class JCspammer : Form
    {
        public JCspammer()
        {
            InitializeComponent();
            this.TopMost = true;
            StartButton.Enabled = true;
            StopButton.Enabled = false;
        }

        //------------------------------------------------------------
        Task spammingTask = null;
        CancellationTokenSource cancelSource;
        CancellationToken cancelToken;

        private void StartButton_Click(object sender, EventArgs e)
        {
            // handle ints
            float cd = 1;
            int maxCount = 1;
            if (!float.TryParse(CdInputField.Text, out cd))
                return;
            if (!int.TryParse(spamTimesInput.Text, out maxCount))
                return;

            // get 
            string text = mainTextBox.Text;

            // start task
            if (spammingTask == null)
            {
                // cancellation stuffs
                cancelSource = new CancellationTokenSource();
                cancelToken = cancelSource.Token;
                spammingTask = Task.Run(() => Spamming(cd, maxCount, text, cancelToken));
                Console.WriteLine($"Start Spamming! CD={cd} | text={text}");
            }
            else
            {
                Console.WriteLine("Already existed a spamming task");
            }

            // UI
            StartButton.Enabled = false;
            StopButton.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            cancelSource.Cancel();
            spammingTask = null;
            StartButton.Enabled = true;
            StopButton.Enabled = false;
        }

        int count = 0;
        private async Task Spamming(float cd, int maxCount, string text, CancellationToken cancelToken)
        {
            await Task.Delay(3000);
            while (count < maxCount)
            {
                if(cancelToken.IsCancellationRequested)
                {
                    cancelToken.ThrowIfCancellationRequested();
                }
                
                try
                {
                    SendKeys.SendWait(text);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }               
                count++;                         
                Console.WriteLine($"{count}/{maxCount}");
                spamCount.Text = count.ToString("0");

                await Task.Delay( (int)(cd*1000f) );
            }
            StopButton_Click(null, null);
        }
    }
}
