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
    public partial class frm_Client : Form
    {
        Map map = new Map();
        frm_callTaxi callTaxiForm = new frm_callTaxi();
        public frm_Client()
        {
            InitializeComponent();
            pnl_main.Controls.Add(map);
            map.Width = 1054;
            map.Show();
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
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
            if(pnl_left.Width == 245) //when menu is extended
            {
                pnl_left.Width = 75;  //makes it shrinked
                map.Width = 1220;
                pnl_main.Width = 1220;
                pnl_main.Location = new Point(82, 31);
                pnl_rightBorder.Location = new Point(81, 9);
                pnl_leftYellow.BackColor = Color.FromArgb(234, 157, 30);
            }
            else
            {
                map.Width = 1054; //extends it
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
            map.Visible = false; //so it doesn't need to reload the map every time
        }

        private void btn_phone_Enter(object sender, EventArgs e)
        {
            lbl_phone.ForeColor = Color.FromArgb(234, 157, 30);
            pnl_leftYellow.Location = new Point(1, 265);
            map.Hide();
            pnl_main.Controls.Add(callTaxiForm);
            callTaxiForm.Show();
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

        
    }
}
