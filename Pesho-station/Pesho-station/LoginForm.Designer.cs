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
            this.exitButton = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.exitButton.Location = new System.Drawing.Point(383, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(17, 16);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.minimizeButton.Location = new System.Drawing.Point(360, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(16, 16);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.Minimize_Click);
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
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.jMaterialTextbox1.HintText = null;
            this.jMaterialTextbox1.IsPassword = true;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.jMaterialTextbox1.LineThickness = 2;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(34, 255);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(330, 35);
            this.jMaterialTextbox1.TabIndex = 2;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.jMaterialTextbox2.HintText = null;
            this.jMaterialTextbox2.IsPassword = false;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.jMaterialTextbox2.LineThickness = 2;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(34, 196);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(330, 35);
            this.jMaterialTextbox2.TabIndex = 1;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "User Name";
            // 
            // loginButton
            // 
            this.loginButton.CausesValidation = false;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.loginButton.Location = new System.Drawing.Point(34, 319);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(157, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // signupButton
            // 
            this.signupButton.CausesValidation = false;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.signupButton.FlatAppearance.BorderSize = 2;
            this.signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.signupButton.Location = new System.Drawing.Point(207, 319);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(157, 41);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.jMaterialTextbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jMaterialTextbox1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Panel topPanel;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
    }
}

