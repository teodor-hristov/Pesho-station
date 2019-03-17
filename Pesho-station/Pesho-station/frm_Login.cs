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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
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

        private void signupButton_Click(object sender, EventArgs e)
        {
            //Works but needs to be improved
            frm_Register registerForm = new frm_Register();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_Client clientForm = new frm_Client();
            this.Hide();
            clientForm.ShowDialog();
            this.Close();
        }
    }
}
