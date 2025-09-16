using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

using Eigenverft.AirGap.Extensions;

namespace Eigenverft.AirGap
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                var cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private readonly BackgroundWorker _worker;

        public MainForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoSize = false;

            _worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            _worker.DoWork += Worker_DoWork;
            _worker.ProgressChanged += Worker_ProgressChanged;
            _worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            MainPanel.EnableDrag(this.Handle);
            progressBarEx31.EnableDrag(this.Handle);
            transparentLabelExText.EnableDrag(this.Handle);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            progressBarEx31.CustomText = "Starting...";
            _worker.RunWorkerAsync(progressBarEx31.Maximum);
        }

        /// <summary>Performs the long-running work off the UI thread.</summary>
        /// <remarks>Cooperative cancellation is honored via <see cref="BackgroundWorker.CancellationPending"/>.</remarks>
        /// <param name="sender">The worker instance.</param>
        /// <param name="e">Argument holds the maximum value; sets <see cref="AsyncCompletedEventArgs.Cancelled"/> when aborted.</param>
        /// <example>
        /// <code>
        /// // Caller: _worker.RunWorkerAsync(progressBarEx31.Maximum);
        /// </code>
        /// </example>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var max = (int)e.Argument;
            var bw = (BackgroundWorker)sender;

            for (int i = 0; i <= max; i++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true; // mark as cancelled
                    return;          // stop work immediately
                }

                Thread.Sleep(20);   // simulate work
                bw.ReportProgress(i);
            }
        }

        /// <summary>Updates the progress bar on the UI thread.</summary>
        /// <param name="sender">The worker instance.</param>
        /// <param name="e">Progress percentage used as the bar value.</param>
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarEx31.Value = e.ProgressPercentage;
            progressBarEx31.CustomText = e.ProgressPercentage + "/" + progressBarEx31.Maximum;
        }

        /// <summary>Finalizes UI after background work completes, cancels, or errors.</summary>
        /// <param name="sender">The worker instance.</param>
        /// <param name="e">Completion args with <see cref="AsyncCompletedEventArgs.Error"/> and <see cref="AsyncCompletedEventArgs.Cancelled"/>.</param>
        /// <example>
        /// <code>
        /// // Decide whether to keep the window open on cancel:
        /// // if (e.Cancelled) return; else this.Close();
        /// </code>
        /// </example>
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                progressBarEx31.CustomText = "Error.";
                this.Close();
                return;
            }

            if (e.Cancelled)
            {
                progressBarEx31.CustomText = "Cancelled.";
                // Choose one behavior:
                // return;          // keep window open
                this.Close();       // or close it on cancel as well
                return;
            }

            this.Close(); // finished successfully
        }

        /// <summary>Requests cancellation from the UI.</summary>
        /// <remarks>Disables the control to prevent repeated clicks and updates UI text.</remarks>
        /// <param name="sender">The close/cancel label.</param>
        /// <param name="e">Event args.</param>
        /// <example>
        /// <code>
        /// // User clicks the "X" or cancel label.
        /// </code>
        /// </example>
        private void transparentLabelClose_Click(object sender, EventArgs e)
        {
            if (_worker.IsBusy && _worker.WorkerSupportsCancellation)
            {
                ((Control)sender).Enabled = false;
                progressBarEx31.CustomText = "Cancelling...";
                _worker.CancelAsync();
            }
            else
            {
                Thread.Sleep(1000);
                this.Close();
            }
        }
    }
}