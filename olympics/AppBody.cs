using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace olympics
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_timer.Start();

        }

        private void login_timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                login_timer.Stop();
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoff_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

     

     

        private void athlete_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Athlete_UserControl1.Instance))
            {
                contentpanel.Controls.Add(Athlete_UserControl1.Instance);
                Athlete_UserControl1.Instance.Dock = DockStyle.Fill;
                Athlete_UserControl1.Instance.BringToFront();
            }
            else
            {
                Athlete_UserControl1.Instance.BringToFront();
            }
        }

        private void Event_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Event_UserControl1.Instance))
            {
                contentpanel.Controls.Add(Event_UserControl1.Instance);
                Event_UserControl1.Instance.Dock = DockStyle.Fill;
                Event_UserControl1.Instance.BringToFront();
            }
            else
            {
                Event_UserControl1.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Site_UserControl1.Instance))
            {
                contentpanel.Controls.Add(Site_UserControl1.Instance);
                Site_UserControl1.Instance.Dock = DockStyle.Fill;
                Site_UserControl1.Instance.BringToFront();
            }
            else
            {
                Site_UserControl1.Instance.BringToFront();
            }
        }

        private void Schedule_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Schedule_UserControl1.Instance))
            {
                contentpanel.Controls.Add(Schedule_UserControl1.Instance);
                Schedule_UserControl1.Instance.Dock = DockStyle.Fill;
                Schedule_UserControl1.Instance.BringToFront();
            }
            else
            {
                Schedule_UserControl1.Instance.BringToFront();
            }
        }

        private void up_res_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Res_update_UserControl1.Instance))
            {
                contentpanel.Controls.Add(Res_update_UserControl1.Instance);
                Res_update_UserControl1.Instance.Dock = DockStyle.Fill;
                Res_update_UserControl1.Instance.BringToFront();
            }
            else
            {
                Res_update_UserControl1.Instance.BringToFront();
            }
        }

        private void Add_res_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Add_Res_UserControl1.Instance))
            {
                contentpanel.Controls.Add(Add_Res_UserControl1.Instance);
                Add_Res_UserControl1.Instance.Dock = DockStyle.Fill;
                Add_Res_UserControl1.Instance.BringToFront();
            }
            else
            {
                Add_Res_UserControl1.Instance.BringToFront();
            }
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(About_UserControl1.Instance))
            {
                contentpanel.Controls.Add(About_UserControl1.Instance);
                About_UserControl1.Instance.Dock = DockStyle.Fill;
                About_UserControl1.Instance.BringToFront();
            }
            else
            {
                About_UserControl1.Instance.BringToFront();
            }
        }
    }
}
