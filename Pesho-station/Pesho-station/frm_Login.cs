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
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            string cmdString = "select * from register where password=@password and username=@username";
            MySqlCommand cmd = new MySqlCommand(cmdString, con);
            cmd.Parameters.AddWithValue("@password", txt_passwordLogin.TextName);
            cmd.Parameters.AddWithValue("@username", txt_usernameLogin.TextName);



            var reader = cmd.ExecuteReader();
            reader.Read();

            string cmdString2 = "select * from drivers where driver_password=@driver_password and driver_name=@driver_name";
            MySqlCommand cmd2 = new MySqlCommand(cmdString2, con);
            cmd2.Parameters.AddWithValue("@driver_password", txt_passwordLogin.TextName);
            cmd2.Parameters.AddWithValue("@driver_name", txt_usernameLogin.TextName);


            if (reader.HasRows)
            {
                frm_Client clientForm = new frm_Client();
                clientForm.Username = txt_usernameLogin.TextName;
                clientForm.Phone = reader.GetString(3);
                this.Hide();
                clientForm.ShowDialog();
                this.Close();
                reader.Close();
            }
            reader.Close();
            var drivers = cmd2.ExecuteReader();
            drivers.Read();
            if (drivers.HasRows)
            {
                frm_TaxiDriver taxiDriverForm = new frm_TaxiDriver();
                taxiDriverForm.DriverNameLogin = txt_usernameLogin.TextName;
                this.Hide();
                taxiDriverForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Client clientForm = new frm_Client();
            this.Hide();
            clientForm.ShowDialog();
            this.Close();
        }
    }
}
