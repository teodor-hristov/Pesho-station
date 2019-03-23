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

        private void SignIn()
        {
            //Works but needs to be improved
            frm_Login loginForm = new frm_Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void CheckForExistingUsername()
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.159.21;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from register", con);
            var reader = cmd.ExecuteReader();
            reader.Read();
            string username = reader.GetString(2);
            if (username == txt_username.TextName)
            {
                lbl_errorMsg.Text = "This username already exists";
            }
            else
            {
                lbl_errorMsg.Text = "";
            }
            con.Close();
            
        }

        private void CheckForEmptyFields()
        {
            if (txt_username.TextName == "" || txt_fullName.TextName == "" || txt_phoneNumber.TextName == "" || txt_password.TextName == "")
            {
                lbl_errorMsg.Text = "Fields cannot be empty";
            }
            else
            {
                lbl_errorMsg.Text = "";
            }
        }

        private void SuccessfullRegister()
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.159.21;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT into register(fullname,username,phone,password) values('" + this.txt_fullName.TextName + "','" + this.txt_username.TextName + "','" + this.txt_phoneNumber.TextName + "','" + this.txt_password.TextName + "');", con);
            var reader = cmd.ExecuteReader();
            reader.Read();
            MessageBox.Show("Register Successfully");
            con.Close();
            SignIn();
        }

        private void btn_submit_Click(object sender, EventArgs e) //TODO: needs to check if username already exists
        {

            if (lbl_wrongPhoneNumber.Text != "" && lbl_errorMsg.Text != "") //checks if there are any errors like wrong phone number or empty fields
            {
                CheckForEmptyFields();
                CheckForExistingUsername();
            }
            else
            {
                SuccessfullRegister();
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            txt_password.IsPassword = true;
        }

        private void txt_phoneNumber_Leave(object sender, EventArgs e)
        {
            if(!txt_phoneNumber.TextName.All(c => c >= '0' && c <= '9'))
            {
                lbl_wrongPhoneNumber.Text = "Incorrect phone number";
                txt_phoneNumber.TextName = "";
            }
            else
            {
                lbl_wrongPhoneNumber.Text = "";
            }
        }
    }
}
