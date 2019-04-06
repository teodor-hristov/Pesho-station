using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesho_station
{
    public partial class frm_TaxiDriver : Form
    {
        Map map = new Map();
        frm_ManageRequests manageRequestsForm = new frm_ManageRequests();
        public frm_TaxiDriver()
        {
            InitializeComponent();
            manageRequestsForm.DriverName = DriverNameLogin;
            pnl_main.Controls.Add(map);
            map.Width = 1054;
            map.Show();
        }


        private string driverName;

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }


        private string driverNameLogin;

        public string DriverNameLogin
        {
            get { return driverNameLogin; }
            set { driverNameLogin = value; }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Draggable topPanel
        bool moving;
        Point offset;
        Point original;

        void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            pnl_top.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            pnl_top.Capture = false;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(pnl_left.Width == 245) //shrinks the panel
            {
                pnl_left.Width = 75;
                map.Width = 1220;
                pnl_main.Width = 1220;
                pnl_main.Location = new Point(82, 31);
                pnl_rightBorder.Location = new Point(81, 9);
                pnl_leftYellow.BackColor = Color.FromArgb(234, 157, 30);
            }
            else //unshrinks the panel
            {
                map.Width = 1054;
                pnl_main.Width = 1054;
                pnl_main.Location = new Point(241, 31);
                pnl_rightBorder.Location = new Point(241, 9);
                pnl_left.Width = 245;
                pnl_leftYellow.BackColor = Color.FromArgb(26, 26, 26);
            }
        }

        private void btn_home_Enter(object sender, EventArgs e)
        {
            lbl_home.ForeColor = Color.FromArgb(234, 157, 30);
            pnl_leftYellow.Location = new Point(1, 179);
            map.Visible = true;
        }

        private void btn_home_Leave(object sender, EventArgs e)
        {
            lbl_home.ForeColor = Color.FromArgb(180, 180, 180);
            map.Visible = false;
        }

        private void btn_phone_Enter(object sender, EventArgs e)
        {
            lbl_phone.ForeColor = Color.FromArgb(234, 157, 30);
            pnl_leftYellow.Location = new Point(1, 265);
            map.Visible = false;
            map.Hide();
            pnl_main.Controls.Add(manageRequestsForm);
            manageRequestsForm.Show();
        }

        private void btn_phone_Leave(object sender, EventArgs e)
        {
            lbl_phone.ForeColor = Color.FromArgb(180, 180, 180);
        }

        private void btn_time_Enter(object sender, EventArgs e)
        {
            lbl_time.ForeColor = Color.FromArgb(234, 157, 30);
            pnl_leftYellow.Location = new Point(1, 351);
        }

        private void btn_time_Leave(object sender, EventArgs e)
        {
            lbl_time.ForeColor = Color.FromArgb(180, 180, 180);
        }

        private void btn_settings_Enter(object sender, EventArgs e)
        {
            lbl_settings.ForeColor = Color.FromArgb(234, 157, 30);
            pnl_leftYellow.Location = new Point(1, 440);
        }

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            lbl_settings.ForeColor = Color.FromArgb(180, 180, 180);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm)); //creating a new thread with a login form
            this.Dispose();
            manageRequestsForm.Dispose();
            this.Close();
            t.Start();
        }

        public static void OpenLoginForm()
        {
            Application.Run(new frm_Login());
        }

        private void frm_TaxiDriver_Load_1(object sender, EventArgs e)
        {
            manageRequestsForm.DriverName = DriverNameLogin;
        }
    }
}
