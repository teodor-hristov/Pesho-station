namespace Pesho_station
{
    partial class frm_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Client));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_leftYellow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_home = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_time = new System.Windows.Forms.Button();
            this.btn_phone = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_rightBorder = new System.Windows.Forms.Panel();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            this.pnl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_exit);
            this.pnl_top.Location = new System.Drawing.Point(3, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1294, 29);
            this.pnl_top.TabIndex = 8;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.AutoSize = true;
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_minimize.Location = new System.Drawing.Point(1249, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.Text = "_";
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_exit.Location = new System.Drawing.Point(1272, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(17, 16);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnl_left.Controls.Add(this.pnl_leftYellow);
            this.pnl_left.Controls.Add(this.label1);
            this.pnl_left.Controls.Add(this.btn_logout);
            this.pnl_left.Controls.Add(this.lbl_settings);
            this.pnl_left.Controls.Add(this.lbl_time);
            this.pnl_left.Controls.Add(this.lbl_phone);
            this.pnl_left.Controls.Add(this.lbl_home);
            this.pnl_left.Controls.Add(this.btn_settings);
            this.pnl_left.Controls.Add(this.btn_time);
            this.pnl_left.Controls.Add(this.btn_phone);
            this.pnl_left.Controls.Add(this.btn_home);
            this.pnl_left.Controls.Add(this.pnl_rightBorder);
            this.pnl_left.Controls.Add(this.lbl_fullName);
            this.pnl_left.Controls.Add(this.btn_menu);
            this.pnl_left.Location = new System.Drawing.Point(3, 27);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(245, 727);
            this.pnl_left.TabIndex = 9;
            // 
            // pnl_leftYellow
            // 
            this.pnl_leftYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnl_leftYellow.Location = new System.Drawing.Point(1, 179);
            this.pnl_leftYellow.Name = "pnl_leftYellow";
            this.pnl_leftYellow.Size = new System.Drawing.Size(5, 45);
            this.pnl_leftYellow.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(73, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Log out";
            this.label1.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(16, 671);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(40, 40);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_settings.Location = new System.Drawing.Point(74, 450);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(80, 22);
            this.lbl_settings.TabIndex = 18;
            this.lbl_settings.Text = "Settings";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_time.Location = new System.Drawing.Point(74, 363);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(146, 22);
            this.lbl_time.TabIndex = 17;
            this.lbl_time.Text = "Time remaining";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_phone.Location = new System.Drawing.Point(74, 277);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(99, 22);
            this.lbl_phone.TabIndex = 16;
            this.lbl_phone.Text = "Call a taxi";
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_home.Location = new System.Drawing.Point(74, 199);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(64, 22);
            this.lbl_home.TabIndex = 15;
            this.lbl_home.Text = "Home";
            this.lbl_home.Enter += new System.EventHandler(this.btn_home_Enter);
            // 
            // btn_settings
            // 
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(16, 437);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(40, 40);
            this.btn_settings.TabIndex = 14;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Enter += new System.EventHandler(this.btn_settings_Enter);
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_Leave);
            // 
            // btn_time
            // 
            this.btn_time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_time.BackgroundImage")));
            this.btn_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_time.FlatAppearance.BorderSize = 0;
            this.btn_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_time.Location = new System.Drawing.Point(16, 351);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(40, 40);
            this.btn_time.TabIndex = 13;
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Enter += new System.EventHandler(this.btn_time_Enter);
            this.btn_time.Leave += new System.EventHandler(this.btn_time_Leave);
            // 
            // btn_phone
            // 
            this.btn_phone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_phone.BackgroundImage")));
            this.btn_phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phone.FlatAppearance.BorderSize = 0;
            this.btn_phone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phone.Location = new System.Drawing.Point(16, 265);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(40, 40);
            this.btn_phone.TabIndex = 12;
            this.btn_phone.UseVisualStyleBackColor = true;
            this.btn_phone.Enter += new System.EventHandler(this.btn_phone_Enter);
            this.btn_phone.Leave += new System.EventHandler(this.btn_phone_Leave);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(9, 176);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(52, 55);
            this.btn_home.TabIndex = 11;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Enter += new System.EventHandler(this.btn_home_Enter);
            this.btn_home.Leave += new System.EventHandler(this.btn_home_Leave);
            // 
            // pnl_rightBorder
            // 
            this.pnl_rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnl_rightBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnl_rightBorder.Location = new System.Drawing.Point(241, 9);
            this.pnl_rightBorder.Name = "pnl_rightBorder";
            this.pnl_rightBorder.Size = new System.Drawing.Size(2, 718);
            this.pnl_rightBorder.TabIndex = 10;
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_fullName.Location = new System.Drawing.Point(71, 15);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(105, 45);
            this.lbl_fullName.TabIndex = 9;
            this.lbl_fullName.Text = "Menu";
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.BackgroundImage")));
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(9, 8);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(52, 55);
            this.btn_menu.TabIndex = 8;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.pnl_main.Location = new System.Drawing.Point(247, 31);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1054, 720);
            this.pnl_main.TabIndex = 10;
            // 
            // frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1296, 754);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_client";
            this.Load += new System.EventHandler(this.frm_Client_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label btn_minimize;
        private System.Windows.Forms.Label btn_exit;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.Panel pnl_rightBorder;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.Button btn_phone;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel pnl_leftYellow;
        private System.Windows.Forms.Panel pnl_main;
    }
}