namespace Clocked
{
    partial class frmClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.lblTime = new System.Windows.Forms.Label();
            this.niClocked = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsClocked = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStop = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAlert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrClocked = new System.Windows.Forms.Timer(this.components);
            this.ttClocked = new System.Windows.Forms.ToolTip(this.components);
            this.cmsClocked.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // niClocked
            // 
            this.niClocked.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niClocked.BalloonTipText = "Clocked Hours";
            this.niClocked.ContextMenuStrip = this.cmsClocked;
            this.niClocked.Icon = ((System.Drawing.Icon)(resources.GetObject("niClocked.Icon")));
            this.niClocked.Text = "Clocked";
            this.niClocked.Visible = true;
            this.niClocked.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niClocked_MouseClick);
            // 
            // cmsClocked
            // 
            this.cmsClocked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStart,
            this.tsStop,
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem,
            this.tsAlert,
            this.tsExit,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.cmsClocked.Name = "cmsClocked";
            this.cmsClocked.Size = new System.Drawing.Size(153, 186);
            // 
            // tsStart
            // 
            this.tsStart.Name = "tsStart";
            this.tsStart.Size = new System.Drawing.Size(152, 22);
            this.tsStart.Text = "Start";
            this.tsStart.Click += new System.EventHandler(this.tsStart_Click);
            // 
            // tsStop
            // 
            this.tsStop.Name = "tsStop";
            this.tsStop.Size = new System.Drawing.Size(152, 22);
            this.tsStop.Text = "Stop";
            this.tsStop.Click += new System.EventHandler(this.tsStop_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // tsAlert
            // 
            this.tsAlert.CheckOnClick = true;
            this.tsAlert.Name = "tsAlert";
            this.tsAlert.Size = new System.Drawing.Size(152, 22);
            this.tsAlert.Text = "Alert in 8H";
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(152, 22);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tmrClocked
            // 
            this.tmrClocked.Interval = 1000;
            this.tmrClocked.Tick += new System.EventHandler(this.tmrClocked_Tick);
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(113, 37);
            this.ContextMenuStrip = this.cmsClocked;
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClock";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Clocked";
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmClocked_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClocked_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmClocked_MouseUp);
            this.cmsClocked.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NotifyIcon niClocked;
        private System.Windows.Forms.ContextMenuStrip cmsClocked;
        private System.Windows.Forms.ToolStripMenuItem tsStart;
        private System.Windows.Forms.ToolStripMenuItem tsStop;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Timer tmrClocked;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttClocked;
        private System.Windows.Forms.ToolStripMenuItem tsAlert;
    }
}

