namespace Pesho_station
{
    partial class frm_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Register));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Label();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.txt_fullName = new JMaterialTextbox.JMaterialTextbox();
            this.txt_username = new JMaterialTextbox.JMaterialTextbox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new JMaterialTextbox.JMaterialTextbox();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.txt_password = new JMaterialTextbox.JMaterialTextbox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_alrHaveAcc = new System.Windows.Forms.Label();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_registration = new System.Windows.Forms.PictureBox();
            this.lbl_wrongPhoneNumber = new System.Windows.Forms.Label();
            this.lbl_EmptyFields = new System.Windows.Forms.Label();
            this.lbl_usernameExists = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_registration)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.Location = new System.Drawing.Point(1, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(466, 29);
            this.pnl_top.TabIndex = 5;
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
            this.btn_minimize.Location = new System.Drawing.Point(473, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.Text = "_";
            this.btn_minimize.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_exit.Location = new System.Drawing.Point(496, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(17, 16);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.lbl_fullName.Location = new System.Drawing.Point(56, 230);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(101, 22);
            this.lbl_fullName.TabIndex = 6;
            this.lbl_fullName.Text = "Full name:";
            // 
            // txt_fullName
            // 
            this.txt_fullName.BackColor = System.Drawing.Color.Transparent;
            this.txt_fullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_fullName.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_fullName.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_fullName.HintText = null;
            this.txt_fullName.IsPassword = false;
            this.txt_fullName.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_fullName.LineThickness = 2;
            this.txt_fullName.Location = new System.Drawing.Point(188, 229);
            this.txt_fullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_fullName.MaxLength = 50;
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txt_fullName.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_fullName.ReadOnly = false;
            this.txt_fullName.Size = new System.Drawing.Size(279, 22);
            this.txt_fullName.TabIndex = 1;
            this.txt_fullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_fullName.TextName = "";
            this.txt_fullName.Leave += new System.EventHandler(this.txt_fullName_Leave);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_username.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_username.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_username.HintText = null;
            this.txt_username.IsPassword = false;
            this.txt_username.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_username.LineThickness = 2;
            this.txt_username.Location = new System.Drawing.Point(188, 278);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txt_username.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_username.ReadOnly = false;
            this.txt_username.Size = new System.Drawing.Size(279, 22);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextName = "";
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.lbl_username.Location = new System.Drawing.Point(51, 278);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(106, 22);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username:";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txt_phoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_phoneNumber.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_phoneNumber.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_phoneNumber.HintText = null;
            this.txt_phoneNumber.IsPassword = false;
            this.txt_phoneNumber.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_phoneNumber.LineThickness = 2;
            this.txt_phoneNumber.Location = new System.Drawing.Point(188, 328);
            this.txt_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phoneNumber.MaxLength = 10;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txt_phoneNumber.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_phoneNumber.ReadOnly = false;
            this.txt_phoneNumber.Size = new System.Drawing.Size(279, 22);
            this.txt_phoneNumber.TabIndex = 3;
            this.txt_phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_phoneNumber.TextName = "";
            this.txt_phoneNumber.Leave += new System.EventHandler(this.txt_phoneNumber_Leave);
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.lbl_phoneNumber.Location = new System.Drawing.Point(6, 328);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(151, 22);
            this.lbl_phoneNumber.TabIndex = 11;
            this.lbl_phoneNumber.Text = "Phone number:";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_password.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_password.HintText = null;
            this.txt_password.IsPassword = true;
            this.txt_password.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_password.LineThickness = 2;
            this.txt_password.Location = new System.Drawing.Point(188, 379);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txt_password.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.txt_password.ReadOnly = false;
            this.txt_password.Size = new System.Drawing.Size(279, 22);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextName = "";
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.lbl_password.Location = new System.Drawing.Point(57, 380);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(100, 22);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Password:";
            // 
            // btn_submit
            // 
            this.btn_submit.CausesValidation = false;
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_submit.FlatAppearance.BorderSize = 2;
            this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.btn_submit.Location = new System.Drawing.Point(188, 438);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(157, 41);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_alrHaveAcc
            // 
            this.lbl_alrHaveAcc.AutoSize = true;
            this.lbl_alrHaveAcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_alrHaveAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(31)))));
            this.lbl_alrHaveAcc.Location = new System.Drawing.Point(189, 500);
            this.lbl_alrHaveAcc.Name = "lbl_alrHaveAcc";
            this.lbl_alrHaveAcc.Size = new System.Drawing.Size(156, 17);
            this.lbl_alrHaveAcc.TabIndex = 17;
            this.lbl_alrHaveAcc.Text = "Already have an account?";
            // 
            // btn_signIn
            // 
            this.btn_signIn.FlatAppearance.BorderSize = 0;
            this.btn_signIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn_signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.btn_signIn.Location = new System.Drawing.Point(229, 520);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(72, 30);
            this.btn_signIn.TabIndex = 6;
            this.btn_signIn.Text = "Sign in";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 15;
            // 
            // pic_registration
            // 
            this.pic_registration.Image = ((System.Drawing.Image)(resources.GetObject("pic_registration.Image")));
            this.pic_registration.Location = new System.Drawing.Point(192, 46);
            this.pic_registration.Name = "pic_registration";
            this.pic_registration.Size = new System.Drawing.Size(129, 126);
            this.pic_registration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_registration.TabIndex = 19;
            this.pic_registration.TabStop = false;
            // 
            // lbl_wrongPhoneNumber
            // 
            this.lbl_wrongPhoneNumber.AutoSize = true;
            this.lbl_wrongPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.lbl_wrongPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_wrongPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_wrongPhoneNumber.Location = new System.Drawing.Point(310, 328);
            this.lbl_wrongPhoneNumber.Name = "lbl_wrongPhoneNumber";
            this.lbl_wrongPhoneNumber.Size = new System.Drawing.Size(0, 17);
            this.lbl_wrongPhoneNumber.TabIndex = 20;
            this.lbl_wrongPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_EmptyFields
            // 
            this.lbl_EmptyFields.AutoSize = true;
            this.lbl_EmptyFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.lbl_EmptyFields.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_EmptyFields.ForeColor = System.Drawing.Color.Red;
            this.lbl_EmptyFields.Location = new System.Drawing.Point(193, 196);
            this.lbl_EmptyFields.Name = "lbl_EmptyFields";
            this.lbl_EmptyFields.Size = new System.Drawing.Size(0, 17);
            this.lbl_EmptyFields.TabIndex = 21;
            this.lbl_EmptyFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usernameExists
            // 
            this.lbl_usernameExists.AutoSize = true;
            this.lbl_usernameExists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.lbl_usernameExists.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_usernameExists.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameExists.Location = new System.Drawing.Point(284, 278);
            this.lbl_usernameExists.Name = "lbl_usernameExists";
            this.lbl_usernameExists.Size = new System.Drawing.Size(0, 17);
            this.lbl_usernameExists.TabIndex = 22;
            this.lbl_usernameExists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(516, 593);
            this.Controls.Add(this.lbl_usernameExists);
            this.Controls.Add(this.lbl_EmptyFields);
            this.Controls.Add(this.lbl_wrongPhoneNumber);
            this.Controls.Add(this.pic_registration);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.lbl_alrHaveAcc);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.lbl_fullName);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_registration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label btn_minimize;
        private System.Windows.Forms.Label btn_exit;
        private System.Windows.Forms.Label lbl_fullName;
        private JMaterialTextbox.JMaterialTextbox txt_fullName;
        private JMaterialTextbox.JMaterialTextbox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private JMaterialTextbox.JMaterialTextbox txt_phoneNumber;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private JMaterialTextbox.JMaterialTextbox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_alrHaveAcc;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_registration;
        private System.Windows.Forms.Label lbl_wrongPhoneNumber;
        private System.Windows.Forms.Label lbl_EmptyFields;
        private System.Windows.Forms.Label lbl_usernameExists;
    }
}