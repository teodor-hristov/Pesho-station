namespace Pesho_station
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_exit = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.txt_passwordLogin = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usernameLogin = new JMaterialTextbox.JMaterialTextbox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.pic_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_exit.Location = new System.Drawing.Point(383, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(17, 16);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.AutoSize = true;
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_minimize.Location = new System.Drawing.Point(360, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "_";
            this.btn_minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.Location = new System.Drawing.Point(1, 1);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(353, 29);
            this.pnl_top.TabIndex = 2;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // txt_passwordLogin
            // 
            this.txt_passwordLogin.BackColor = System.Drawing.Color.Transparent;
            this.txt_passwordLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_passwordLogin.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_passwordLogin.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_passwordLogin.HintText = null;
            this.txt_passwordLogin.IsPassword = true;
            this.txt_passwordLogin.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_passwordLogin.LineThickness = 2;
            this.txt_passwordLogin.Location = new System.Drawing.Point(34, 255);
            this.txt_passwordLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_passwordLogin.MaxLength = 50;
            this.txt_passwordLogin.Name = "txt_passwordLogin";
            this.txt_passwordLogin.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txt_passwordLogin.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_passwordLogin.ReadOnly = false;
            this.txt_passwordLogin.Size = new System.Drawing.Size(330, 35);
            this.txt_passwordLogin.TabIndex = 2;
            this.txt_passwordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_passwordLogin.TextName = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // txt_usernameLogin
            // 
            this.txt_usernameLogin.BackColor = System.Drawing.Color.Transparent;
            this.txt_usernameLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_usernameLogin.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_usernameLogin.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_usernameLogin.HintText = null;
            this.txt_usernameLogin.IsPassword = false;
            this.txt_usernameLogin.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_usernameLogin.LineThickness = 2;
            this.txt_usernameLogin.Location = new System.Drawing.Point(34, 196);
            this.txt_usernameLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_usernameLogin.MaxLength = 50;
            this.txt_usernameLogin.Name = "txt_usernameLogin";
            this.txt_usernameLogin.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txt_usernameLogin.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_usernameLogin.ReadOnly = false;
            this.txt_usernameLogin.Size = new System.Drawing.Size(330, 35);
            this.txt_usernameLogin.TabIndex = 1;
            this.txt_usernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_usernameLogin.TextName = "User Name";
            // 
            // btn_login
            // 
            this.btn_login.CausesValidation = false;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_login.Location = new System.Drawing.Point(34, 319);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(157, 41);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_signUp
            // 
            this.btn_signUp.CausesValidation = false;
            this.btn_signUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_signUp.FlatAppearance.BorderSize = 2;
            this.btn_signUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_signUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_signUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_signUp.Location = new System.Drawing.Point(207, 319);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(157, 41);
            this.btn_signUp.TabIndex = 4;
            this.btn_signUp.Text = "Sign up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // pic_login
            // 
            this.pic_login.Image = ((System.Drawing.Image)(resources.GetObject("pic_login.Image")));
            this.pic_login.Location = new System.Drawing.Point(145, 67);
            this.pic_login.Name = "pic_login";
            this.pic_login.Size = new System.Drawing.Size(100, 92);
            this.pic_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_login.TabIndex = 8;
            this.pic_login.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.pic_login);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_usernameLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passwordLogin);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_exit;
        private System.Windows.Forms.Label btn_minimize;
        private System.Windows.Forms.Panel pnl_top;
        private JMaterialTextbox.JMaterialTextbox txt_passwordLogin;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox txt_usernameLogin;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.PictureBox pic_login;
    }
}

