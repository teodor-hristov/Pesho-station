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
    public partial class frm_ManageRequests : Form
    {
        public frm_ManageRequests()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.pnl_main.AutoScroll = true;
        }
    }
}
