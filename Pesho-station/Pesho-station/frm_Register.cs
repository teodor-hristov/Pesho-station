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

        //hides the registration form and opens login form
        private void SignIn()
        {
            frm_Login loginForm = new frm_Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        //checks for existence of the username and appends the error label
        private void CheckForExistingUsername()
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            string cmdString = "select * from register where username= @username";

            MySqlCommand cmd2 = new MySqlCommand(cmdString, con);
            cmd2.Parameters.AddWithValue("@username", txt_username.TextName);
            var reader = cmd2.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                lbl_usernameExists.Text = "The username already exists";
            }
            else
            {
                lbl_usernameExists.Text = "";

            }   
        }

        //appends the label with errors when there are empty fields
        private void CheckForEmptyFields()
        {
            if (txt_username.TextName == "" || txt_fullName.TextName == "" || txt_phoneNumber.TextName == "" || txt_password.TextName == "")
            {
                lbl_EmptyFields.Text = "Fields cannot be empty";
            }
            else
            {
                lbl_EmptyFields.Text = "";
            }
        }

        //registering the user by adding it to the database
        private void Register()
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT into register(fullname,username,phone,password) values('" + this.txt_fullName.TextName + "','" + this.txt_username.TextName + "','" + this.txt_phoneNumber.TextName + "','" + this.txt_password.TextName + "');", con);
            var reader = cmd.ExecuteReader();
            reader.Read();
            MessageBox.Show("Register Successfully");
            con.Close();
            SignIn();
        }

        //checks if there are any errors in the error labels
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (lbl_wrongPhoneNumber.Text != "")
            {
                txt_phoneNumber.TextName = "";
                
            }
            else if(lbl_EmptyFields.Text != "")
            {
                CheckForEmptyFields();
            }
            else if(lbl_usernameExists.Text != "")
            {
                CheckForExistingUsername();
            }
            else
            {
                Register();
            }
        }

        //makes the txt to a password when leaving it so it does not show the password
        private void txt_password_Leave(object sender, EventArgs e)
        {
            txt_password.IsPassword = true;
            CheckForEmptyFields();
        }

        //checks for incorrect phone number
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
            CheckForEmptyFields();
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            CheckForExistingUsername();
            CheckForEmptyFields();
        }

        private void txt_fullName_Leave(object sender, EventArgs e)
        {
            CheckForEmptyFields();
        }
        
    }
}
