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
using System.IO;

namespace Pesho_station
{
    public partial class frm_callTaxi : Form
    {
        string selectedVehicle = "Normal";
        double dayRatePerKm = 0.00;
        double nightRatePerKm = 0.00;
        int noteHeight = 24;
        int noteWidth = 229;
        int noteTotalChars = 0;
        int noteMaxCharsOnLine = 37; //the char number to add a new line to the cmb
        private string docFile = Path.Combine(Application.StartupPath, "..\\..\\map.html");
        ChangeParametersInMap change = new ChangeParametersInMap();

        //cmb max chars = 296
        bool taxiRequested = false;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        private string driverName;

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }


        public frm_callTaxi()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            cmb_vehicleType.Text = selectedVehicle;
            cmb_pickupTime.Text = "00";
        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void btn_requestTaxi_MouseHover(object sender, EventArgs e)
        {
            btn_requestTaxi.ForeColor = Color.FromArgb(234, 211, 11);
        }

        private void btn_requestTaxi_MouseLeave(object sender, EventArgs e)
        {
            btn_requestTaxi.ForeColor = Color.FromArgb(180, 180, 180);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbl_scrollValuePass.Text = trackBar1.Value.ToString();
            int scrollValue = int.Parse(lbl_scrollValuePass.Text);
            if (scrollValue > 4)
            {
                cmb_vehicleType.Text = "XL";
            }
            else
            {
                cmb_vehicleType.Text = selectedVehicle;
            }
        }

        private void cmb_vehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVehicle = cmb_vehicleType.Text;
            ActiveControl = lbl_note; //removes the selection of the combobox
            if(selectedVehicle == "Normal")
            {
                lbl_dayRate.Text = "Day rate per km: 0.79lv";
                lbl_nightRate.Text = "Night rate per km: 0.89lv";
                dayRatePerKm = 0.79;
                nightRatePerKm = 0.89;
            }
            else if(selectedVehicle == "XL" || selectedVehicle == "SUV")
            {
                lbl_dayRate.Text = "Day rate per km: 0.89lv";
                lbl_nightRate.Text = "Night rate per km: 0.99lv";
                dayRatePerKm = 0.89;
                nightRatePerKm = 0.99;
            }
            else
            {
                lbl_dayRate.Text = "Day rate per km: 5.99lv";
                lbl_nightRate.Text = "Night rate per km: 6.99lv";
                dayRatePerKm = 5.99;
                nightRatePerKm = 6.99;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //every 37 chars it makes a new line
            noteTotalChars++;
            if (richTextBox1.Text.Length > noteMaxCharsOnLine)
            {
                noteMaxCharsOnLine += 37;
                noteHeight += 20;
                richTextBox1.Size = new Size(noteWidth, noteHeight);
            }
        }

        private void cmb_pickuptime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = lbl_pickupAddress;
        }

        private void RequestTaxi()
        {
            if(txt_pickupAddress.TextName!="" && txt_dropoffAddress.TextName != "")
            {
                MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
                con.Open();
                string cmdString2 = "select * from register where username=@username";
                MySqlCommand cmd2 = new MySqlCommand(cmdString2, con);
                cmd2.Parameters.AddWithValue("@username", username);
                var readUsernames = cmd2.ExecuteReader();
                readUsernames.Read();
                string cmdString = "insert into taxi(passengers,type,pickupTime,pickUpAdress,dropUpAdress,driverNote,callerPhone,callerFullname) values('" + this.trackBar1.Value + "', '" + this.cmb_vehicleType.Text + "', '" + this.cmb_pickupTime.Text + "', '" + this.txt_pickupAddress.TextName + "', '" + this.txt_dropoffAddress.TextName + "', '" + this.richTextBox1.Text + "', '" + readUsernames.GetString(3) + "', '" + readUsernames.GetString(1) + "'); ";
                readUsernames.Close();
                MySqlCommand cmd = new MySqlCommand(cmdString, con);
                var inserter = cmd.ExecuteReader();
                inserter.Read();

                MessageBox.Show("You requsted a taxi");
                lbl_status.Visible = true;
            }
            else
            {
                MessageBox.Show("Please make sure you have entered pickup and dropoff address!");
            }
        }

        //public string GetFullNameOfCaller()
        //{
        //    MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
        //    con.Open();
        //    string cmdString2 = "select * from taxi where callerFullName=@FullName";
        //    MySqlCommand cmd2 = new MySqlCommand(cmdString2, con);
        //    cmd2.Parameters.AddWithValue("@FullName", FullName);
        //    MessageBox.Show(DriverName);
        //    var getFullNameOfCaller = cmd2.ExecuteReader();
        //    getFullNameOfCaller.Read();
            
        //    return getFullNameOfCaller.GetString(3);
        //}

        private void CheckForRequest()
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            string cmdString3 = "select phone_caller_taxi from call_driver where phone_caller_taxi=@phone";
            MySqlCommand cmd = new MySqlCommand(cmdString3, con);
            cmd.Parameters.AddWithValue("@phone", Phone);
            var checker = cmd.ExecuteReader();
            checker.Read();
            if (checker.HasRows)
            {
                lbl_status.Visible = true;
                lbl_status.Text = "Accepted";
            }
        }

        private void statusRefresh()
        {
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.147.111;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            string cmdString2 = "select callerPhone from taxi where callerPhone=@phone ";
            MySqlCommand cmd2 = new MySqlCommand(cmdString2, con);
//<<<<<<< HEAD
            cmd2.Parameters.AddWithValue("@phone", Phone);
            MessageBox.Show(phone);
            var reader = cmd2.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {

                lbl_status.Visible = true;
                lbl_status.Text = "Pending";
            }
            else
            {
                CheckForRequest();
            }
//=======
//            cmd2.Parameters.AddWithValue("@username", username);
//            var readUsernames = cmd2.ExecuteReader();
//            readUsernames.Read();
//            string cmdString = "insert into taxi(passengers,type,pickupTime,pickUpAdress,dropUpAdress,driverNote,callerPhone,callerFullname) values('" + this.trackBar1.Value + "', '" + this.cmb_vehicleType.Text + "', '" + this.cmb_pickupTime.Text + "', '" + this.txt_pickupAddress.TextName + "', '" + this.txt_dropoffAddress.TextName + "', '" +this.richTextBox1.Text + "', '" + readUsernames.GetString(3)+ "', '" +readUsernames.GetString(1) + "'); ";
//            readUsernames.Close();
//            MySqlCommand cmd = new MySqlCommand(cmdString, con);
//            var inserter = cmd.ExecuteReader();
//            inserter.Read();
//            change.ChangeDestinationPins(docFile,change.MAP_DROPOFFDEST_CONSTANT, this.txt_dropoffAddress.TextName);
//            MessageBox.Show("You requsted a taxi");
//            lbl_status.Visible = true;
//            Map map = new Map();
//            map.Show();
//            change.ChangeDestinationPins(docFile, this.txt_dropoffAddress.TextName, change.MAP_DROPOFFDEST_CONSTANT);
//>>>>>>> e99dd0b2de07262af88231667123d715dc85d3c2

        }


        private void btn_requestTaxi_Enter(object sender, EventArgs e)
        {
            taxiRequested = true;
            RequestTaxi();
        }

        private void btn_phone_Enter(object sender, EventArgs e)
        {
            RequestTaxi();
        }

        private void btn_requestTaxi_Click(object sender, EventArgs e)
        {
            taxiRequested = true;
            RequestTaxi();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            statusRefresh();
        }
    }
}
