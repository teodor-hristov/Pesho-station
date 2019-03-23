using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesho_station
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            //Works but needs to be improved
            frm_Login loginForm = new frm_Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.159.21;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from register", con);
            var reader = cmd.ExecuteReader();
            reader.Read();
            string username = reader.GetString(2);
            if (username == txt_username.TextName)
            {
                MessageBox.Show("This username already exists");
            }
            else if (txt_username.TextName == "" && txt_fullName.TextName == "" && txt_phoneNumber.TextName == "" && txt_password.TextName == "")
            {
                MessageBox.Show("Fields cant be empty");
            }
            else
            {
                reader.Close();
                MySqlCommand cmd2 = new MySqlCommand("INSERT into register(fullname,username,phone,password) values('" + this.txt_fullName.TextName + "','" + this.txt_username.TextName + "','" + this.txt_phoneNumber.TextName + "','" + this.txt_password.TextName + "');", con);
                var reader2 = cmd2.ExecuteReader();
                MessageBox.Show("Register Succesfully");
            }
            con.Close();
        }
    }
}
