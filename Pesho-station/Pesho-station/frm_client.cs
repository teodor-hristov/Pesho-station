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
    public partial class frm_Client : Form
    {
        public frm_Client()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
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

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(pnl_left.Width == 245)
            {
                pnl_left.Width = 71;
                pnl_rightBorder.Location = new Point(67, 9);
            }
            else
            {
                pnl_rightBorder.Location = new Point(241, 9);
                pnl_left.Width = 245;
            }
        }
    }
}
