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
    public partial class frm_callTaxi : Form
    {
        public frm_callTaxi()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
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
    }
}
