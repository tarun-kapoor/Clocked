using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocked
{
    public partial class frmClock : Form
    {
        public frmClock()
        {
            InitializeComponent();
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 25, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        DateTime dtStart;
        TimeSpan tsDiff;
        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmClock_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();

            niClocked.ShowBalloonTip(1000);
        }

        private void tsStart_Click(object sender, EventArgs e)
        {
            dtStart = DateTime.Now;
            lblTime.ForeColor = Color.Black;

            tmrClocked.Enabled = true;
            ttClocked.SetToolTip(lblTime, $"Started at {dtStart}. Alarmed for {ConfigurationManager.AppSettings["TrackHours"] ?? "8"}");
        }

        private void tmrClocked_Tick(object sender, EventArgs e)
        {
            tsDiff = DateTime.Now - dtStart;
            lblTime.Text = $"{tsDiff.Hours}:{tsDiff.Minutes}:{tsDiff.Seconds}";

            if (tsDiff.Hours >= Convert.ToInt32(ConfigurationManager.AppSettings["TrackHours"] ?? "8"))
            {
                if (lblTime.ForeColor == Color.Black)
                    lblTime.ForeColor = Color.Red;
                else
                    lblTime.ForeColor = Color.Black;

                if (tsAlert.Checked)
                    System.Media.SystemSounds.Beep.Play();
            }
        }

        private void tsStop_Click(object sender, EventArgs e)
        {
            tmrClocked.Enabled = false;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmClocked_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmClocked_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmClocked_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }


        private void niClocked_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.Focus();
                this.BringToFront();
                this.Activate();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Tarun Kapoor for support!");
        }

    }
}
