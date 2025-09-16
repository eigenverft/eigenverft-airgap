using Eigenverft.AirGap.Controls;

namespace Eigenverft.AirGap
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.transparentLabelEx31 = new Eigenverft.AirGap.Controls.TransparentLabelEx3();
            this.progressBarEx31 = new Eigenverft.AirGap.Controls.ProgressBarEx3();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::Eigenverft.AirGap.Properties.Resources.eigenverft_background_part_logo;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.transparentLabelEx31);
            this.MainPanel.Controls.Add(this.progressBarEx31);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 320);
            this.MainPanel.TabIndex = 0;
            // 
            // transparentLabelEx31
            // 
            this.transparentLabelEx31.AutoSize = true;
            this.transparentLabelEx31.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabelEx31.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(26)))));
            this.transparentLabelEx31.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.transparentLabelEx31.ForeColor = System.Drawing.Color.Black;
            this.transparentLabelEx31.FullShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transparentLabelEx31.FullShadowDepth = 2;
            this.transparentLabelEx31.FullShadowEnabled = false;
            this.transparentLabelEx31.GradientAngle = 45F;
            this.transparentLabelEx31.Location = new System.Drawing.Point(12, 266);
            this.transparentLabelEx31.Name = "transparentLabelEx31";
            this.transparentLabelEx31.ShadowColor = System.Drawing.Color.DarkGray;
            this.transparentLabelEx31.ShadowEnabled = true;
            this.transparentLabelEx31.ShadowOffset = new System.Drawing.Point(1, 0);
            this.transparentLabelEx31.Size = new System.Drawing.Size(170, 17);
            this.transparentLabelEx31.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.transparentLabelEx31.TabIndex = 3;
            this.transparentLabelEx31.Text = "Downloading required files";
            // 
            // progressBarEx31
            // 
            this.progressBarEx31.BackgroundTransparencyPercent = 50;
            this.progressBarEx31.BarBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(26)))));
            this.progressBarEx31.BorderStyle = Eigenverft.AirGap.Controls.ProgressBarEx3.BorderStyleEnum.None;
            this.progressBarEx31.CustomText = "Starting...";
            this.progressBarEx31.CustomTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.progressBarEx31.CustomTextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarEx31.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(26)))));
            this.progressBarEx31.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.progressBarEx31.Location = new System.Drawing.Point(8, 286);
            this.progressBarEx31.Maximum = 1000;
            this.progressBarEx31.Name = "progressBarEx31";
            this.progressBarEx31.Size = new System.Drawing.Size(485, 28);
            this.progressBarEx31.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private ProgressBarEx3 progressBarEx31;
        private TransparentLabelEx3 transparentLabelEx31;
    }
}
