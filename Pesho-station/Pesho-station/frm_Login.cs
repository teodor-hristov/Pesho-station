using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data;
using MySql.Data.MySqlClient;
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
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.159.21;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from register", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (txt_usernameLogin.TextName == reader.GetString(2) && txt_passwordLogin.TextName == reader.GetString(4).ToString())
                {
                    //MessageBox.Show("Login Succesfull");
                    frm_Client clientForm = new frm_Client();
                    this.Hide();
                    clientForm.ShowDialog();
                    this.Close();
                }
            }
            con.Close();
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_usernameLogin_Enter(object sender, EventArgs e)
        {
            txt_usernameLogin.TextName = "";
        }

        private void txt_usernameLogin_Leave(object sender, EventArgs e)
        {
            if(txt_usernameLogin.TextName == "")
            {
                txt_usernameLogin.TextName = "Username";
            }
        }

        private void txt_passwordLogin_Enter(object sender, EventArgs e)
        {
            txt_passwordLogin.TextName = "";
        }

        private void txt_passwordLogin_Leave(object sender, EventArgs e)
        {
            if(txt_passwordLogin.TextName == "")
            {
                txt_passwordLogin.TextName = "password";
                txt_passwordLogin.IsPassword = true;
            }
        }
    }
}
