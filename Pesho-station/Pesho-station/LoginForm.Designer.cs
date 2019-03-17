namespace Pesho_station
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ExitButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.PasswordLoginTextbox = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLoginTextbox = new JMaterialTextbox.JMaterialTextbox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignupButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.ExitButton.Location = new System.Drawing.Point(383, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(17, 16);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.MinimizeButton.Location = new System.Drawing.Point(360, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(16, 16);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // topPanel
            // 
            this.topPanel.Location = new System.Drawing.Point(1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(353, 29);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // PasswordLoginTextbox
            // 
            this.PasswordLoginTextbox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLoginTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLoginTextbox.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLoginTextbox.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PasswordLoginTextbox.HintText = null;
            this.PasswordLoginTextbox.IsPassword = true;
            this.PasswordLoginTextbox.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PasswordLoginTextbox.LineThickness = 2;
            this.PasswordLoginTextbox.Location = new System.Drawing.Point(34, 255);
            this.PasswordLoginTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordLoginTextbox.MaxLength = 32767;
            this.PasswordLoginTextbox.Name = "PasswordLoginTextbox";
            this.PasswordLoginTextbox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.PasswordLoginTextbox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PasswordLoginTextbox.ReadOnly = false;
            this.PasswordLoginTextbox.Size = new System.Drawing.Size(330, 35);
            this.PasswordLoginTextbox.TabIndex = 2;
            this.PasswordLoginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordLoginTextbox.TextName = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // UsernameLoginTextbox
            // 
            this.UsernameLoginTextbox.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLoginTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLoginTextbox.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLoginTextbox.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.UsernameLoginTextbox.HintText = null;
            this.UsernameLoginTextbox.IsPassword = false;
            this.UsernameLoginTextbox.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UsernameLoginTextbox.LineThickness = 2;
            this.UsernameLoginTextbox.Location = new System.Drawing.Point(34, 196);
            this.UsernameLoginTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameLoginTextbox.MaxLength = 32767;
            this.UsernameLoginTextbox.Name = "UsernameLoginTextbox";
            this.UsernameLoginTextbox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.UsernameLoginTextbox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.UsernameLoginTextbox.ReadOnly = false;
            this.UsernameLoginTextbox.Size = new System.Drawing.Size(330, 35);
            this.UsernameLoginTextbox.TabIndex = 1;
            this.UsernameLoginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameLoginTextbox.TextName = "User Name";
            // 
            // LoginButton
            // 
            this.LoginButton.CausesValidation = false;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LoginButton.FlatAppearance.BorderSize = 2;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.LoginButton.Location = new System.Drawing.Point(34, 319);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(157, 41);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // SignupButton
            // 
            this.SignupButton.CausesValidation = false;
            this.SignupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SignupButton.FlatAppearance.BorderSize = 2;
            this.SignupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SignupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.SignupButton.Location = new System.Drawing.Point(207, 319);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(157, 41);
            this.SignupButton.TabIndex = 4;
            this.SignupButton.Text = "Sign up";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameLoginTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLoginTextbox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Panel topPanel;
        private JMaterialTextbox.JMaterialTextbox PasswordLoginTextbox;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox UsernameLoginTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

