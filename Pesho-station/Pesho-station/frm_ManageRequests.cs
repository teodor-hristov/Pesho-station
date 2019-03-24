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
    public partial class frm_ManageRequests : Form
    {
        DataTable dTable = new DataTable();

        public frm_ManageRequests()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.pnl_main.AutoScroll = true;
        }

        private int selectedId;

        public int SelectedId
        {
            get { return selectedId; }
            set { selectedId = value; }
        }


        private void frm_ManageRequests_Load(object sender, EventArgs e)
        {
            LoadDataSet();
        }

        private void DeleteSelectedRow()
        {
            //TODO:.. Sasho ti si
        }

        private void LoadDataSet()
        {
            dTable.Rows.Clear();
            MySqlConnection con = new MySqlConnection("user id=peshoStation;server=212.233.159.21;database=test;password=123123;persistsecurityinfo=True");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from taxi", con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = cmd;
            MyAdapter.Fill(dTable);
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.DataSource = dTable;
            con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataSet();
        }
    }
}
