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
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.pnl_rightBorder = new System.Windows.Forms.Panel();
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
            this.pnl_left.Controls.Add(this.pnl_rightBorder);
            this.pnl_left.Controls.Add(this.lbl_fullName);
            this.pnl_left.Controls.Add(this.btn_menu);
            this.pnl_left.Location = new System.Drawing.Point(3, 27);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(245, 727);
            this.pnl_left.TabIndex = 9;
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
            // pnl_rightBorder
            // 
            this.pnl_rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnl_rightBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnl_rightBorder.Location = new System.Drawing.Point(241, 9);
            this.pnl_rightBorder.Name = "pnl_rightBorder";
            this.pnl_rightBorder.Size = new System.Drawing.Size(2, 718);
            this.pnl_rightBorder.TabIndex = 10;
            // 
            // frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1296, 754);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_client";
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
    }
}