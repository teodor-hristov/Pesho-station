namespace Pesho_station
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextbox = new JMaterialTextbox.JMaterialTextbox();
            this.UsernameTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextbox = new JMaterialTextbox.JMaterialTextbox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new JMaterialTextbox.JMaterialTextbox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Location = new System.Drawing.Point(1, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(466, 29);
            this.topPanel.TabIndex = 5;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.MinimizeButton.Location = new System.Drawing.Point(473, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(16, 16);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.ExitButton.Location = new System.Drawing.Point(496, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(17, 16);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.FullNameLabel.Location = new System.Drawing.Point(56, 219);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(101, 22);
            this.FullNameLabel.TabIndex = 6;
            this.FullNameLabel.Text = "Full name:";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.FullNameTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTextbox.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTextbox.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.FullNameTextbox.HintText = null;
            this.FullNameTextbox.IsPassword = false;
            this.FullNameTextbox.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FullNameTextbox.LineThickness = 2;
            this.FullNameTextbox.Location = new System.Drawing.Point(188, 218);
            this.FullNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FullNameTextbox.MaxLength = 32767;
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.FullNameTextbox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.FullNameTextbox.ReadOnly = false;
            this.FullNameTextbox.Size = new System.Drawing.Size(279, 22);
            this.FullNameTextbox.TabIndex = 1;
            this.FullNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FullNameTextbox.TextName = "";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTextBox.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.UsernameTextBox.HintText = null;
            this.UsernameTextBox.IsPassword = false;
            this.UsernameTextBox.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UsernameTextBox.LineThickness = 2;
            this.UsernameTextBox.Location = new System.Drawing.Point(188, 266);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameTextBox.MaxLength = 32767;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.UsernameTextBox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.UsernameTextBox.ReadOnly = false;
            this.UsernameTextBox.Size = new System.Drawing.Size(279, 22);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameTextBox.TextName = "";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.UsernameLabel.Location = new System.Drawing.Point(51, 267);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(106, 22);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username:";
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNumberTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextbox.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextbox.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PhoneNumberTextbox.HintText = null;
            this.PhoneNumberTextbox.IsPassword = false;
            this.PhoneNumberTextbox.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PhoneNumberTextbox.LineThickness = 2;
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(188, 317);
            this.PhoneNumberTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTextbox.MaxLength = 10;
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.PhoneNumberTextbox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PhoneNumberTextbox.ReadOnly = false;
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(279, 22);
            this.PhoneNumberTextbox.TabIndex = 3;
            this.PhoneNumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PhoneNumberTextbox.TextName = "";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(6, 317);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(151, 22);
            this.PhoneNumberLabel.TabIndex = 11;
            this.PhoneNumberLabel.Text = "Phone number:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextbox.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextbox.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PasswordTextbox.HintText = null;
            this.PasswordTextbox.IsPassword = true;
            this.PasswordTextbox.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PasswordTextbox.LineThickness = 2;
            this.PasswordTextbox.Location = new System.Drawing.Point(188, 368);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextbox.MaxLength = 32767;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.PasswordTextbox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PasswordTextbox.ReadOnly = false;
            this.PasswordTextbox.Size = new System.Drawing.Size(279, 22);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTextbox.TextName = "";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.PasswordLabel.Location = new System.Drawing.Point(57, 369);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 22);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Password:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.CausesValidation = false;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SubmitButton.FlatAppearance.BorderSize = 2;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.SubmitButton.Location = new System.Drawing.Point(188, 427);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(157, 41);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(189, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Already have an account?";
            // 
            // SignInButton
            // 
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.SignInButton.Location = new System.Drawing.Point(229, 509);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(72, 30);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.signInButton_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(516, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FullNameTextbox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label FullNameLabel;
        private JMaterialTextbox.JMaterialTextbox FullNameTextbox;
        private JMaterialTextbox.JMaterialTextbox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private JMaterialTextbox.JMaterialTextbox PhoneNumberTextbox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private JMaterialTextbox.JMaterialTextbox PasswordTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}