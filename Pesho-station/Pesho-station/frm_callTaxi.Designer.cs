namespace Pesho_station
{
    partial class frm_callTaxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_callTaxi));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_requestTaxi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nightRate = new System.Windows.Forms.Label();
            this.lbl_dayRate = new System.Windows.Forms.Label();
            this.lbl_journey = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_vehicleType = new System.Windows.Forms.Label();
            this.lbl_numberPassengers = new System.Windows.Forms.Label();
            this.lbl_booking = new System.Windows.Forms.Label();
            this.lbl_dropoffDest = new System.Windows.Forms.Label();
            this.lbl_pickupAddress = new System.Windows.Forms.Label();
            this.lbl_pickupTime = new System.Windows.Forms.Label();
            this.btn_phone = new System.Windows.Forms.Button();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.btn_requestTaxi);
            this.pnl_main.Controls.Add(this.label5);
            this.pnl_main.Controls.Add(this.lbl_nightRate);
            this.pnl_main.Controls.Add(this.lbl_dayRate);
            this.pnl_main.Controls.Add(this.lbl_journey);
            this.pnl_main.Controls.Add(this.lbl_note);
            this.pnl_main.Controls.Add(this.lbl_vehicleType);
            this.pnl_main.Controls.Add(this.lbl_numberPassengers);
            this.pnl_main.Controls.Add(this.lbl_booking);
            this.pnl_main.Controls.Add(this.lbl_dropoffDest);
            this.pnl_main.Controls.Add(this.lbl_pickupAddress);
            this.pnl_main.Controls.Add(this.lbl_pickupTime);
            this.pnl_main.Controls.Add(this.btn_phone);
            this.pnl_main.Location = new System.Drawing.Point(12, 71);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1074, 573);
            this.pnl_main.TabIndex = 32;
            // 
            // btn_requestTaxi
            // 
            this.btn_requestTaxi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_requestTaxi.FlatAppearance.BorderSize = 0;
            this.btn_requestTaxi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_requestTaxi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_requestTaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requestTaxi.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_requestTaxi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_requestTaxi.Location = new System.Drawing.Point(323, 473);
            this.btn_requestTaxi.Name = "btn_requestTaxi";
            this.btn_requestTaxi.Size = new System.Drawing.Size(280, 59);
            this.btn_requestTaxi.TabIndex = 44;
            this.btn_requestTaxi.Text = "Request a taxi";
            this.btn_requestTaxi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requestTaxi.UseVisualStyleBackColor = true;
            this.btn_requestTaxi.MouseLeave += new System.EventHandler(this.btn_requestTaxi_MouseLeave);
            this.btn_requestTaxi.MouseHover += new System.EventHandler(this.btn_requestTaxi_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label5.Location = new System.Drawing.Point(753, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "(optional)";
            // 
            // lbl_nightRate
            // 
            this.lbl_nightRate.AutoSize = true;
            this.lbl_nightRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_nightRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(157)))), ((int)(((byte)(30)))));
            this.lbl_nightRate.Location = new System.Drawing.Point(347, 395);
            this.lbl_nightRate.Name = "lbl_nightRate";
            this.lbl_nightRate.Size = new System.Drawing.Size(197, 20);
            this.lbl_nightRate.TabIndex = 42;
            this.lbl_nightRate.Text = "Night rate per km: 0.89leva";
            // 
            // lbl_dayRate
            // 
            this.lbl_dayRate.AutoSize = true;
            this.lbl_dayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_dayRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(157)))), ((int)(((byte)(30)))));
            this.lbl_dayRate.Location = new System.Drawing.Point(351, 363);
            this.lbl_dayRate.Name = "lbl_dayRate";
            this.lbl_dayRate.Size = new System.Drawing.Size(188, 20);
            this.lbl_dayRate.TabIndex = 41;
            this.lbl_dayRate.Text = "Day rate per km: 0.79leva";
            // 
            // lbl_journey
            // 
            this.lbl_journey.AutoSize = true;
            this.lbl_journey.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_journey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_journey.Location = new System.Drawing.Point(650, 34);
            this.lbl_journey.Name = "lbl_journey";
            this.lbl_journey.Size = new System.Drawing.Size(271, 41);
            this.lbl_journey.TabIndex = 40;
            this.lbl_journey.Text = "Journey details";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.lbl_note.Location = new System.Drawing.Point(614, 289);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(158, 24);
            this.lbl_note.TabIndex = 39;
            this.lbl_note.Text = "Note to the driver:";
            // 
            // lbl_vehicleType
            // 
            this.lbl_vehicleType.AutoSize = true;
            this.lbl_vehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_vehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.lbl_vehicleType.Location = new System.Drawing.Point(653, 210);
            this.lbl_vehicleType.Name = "lbl_vehicleType";
            this.lbl_vehicleType.Size = new System.Drawing.Size(119, 24);
            this.lbl_vehicleType.TabIndex = 38;
            this.lbl_vehicleType.Text = "Vehicle type:";
            // 
            // lbl_numberPassengers
            // 
            this.lbl_numberPassengers.AutoSize = true;
            this.lbl_numberPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_numberPassengers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.lbl_numberPassengers.Location = new System.Drawing.Point(566, 136);
            this.lbl_numberPassengers.Name = "lbl_numberPassengers";
            this.lbl_numberPassengers.Size = new System.Drawing.Size(206, 24);
            this.lbl_numberPassengers.TabIndex = 37;
            this.lbl_numberPassengers.Text = "Number of passangers:";
            // 
            // lbl_booking
            // 
            this.lbl_booking.AutoSize = true;
            this.lbl_booking.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_booking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbl_booking.Location = new System.Drawing.Point(185, 34);
            this.lbl_booking.Name = "lbl_booking";
            this.lbl_booking.Size = new System.Drawing.Size(154, 41);
            this.lbl_booking.TabIndex = 36;
            this.lbl_booking.Text = "Booking";
            // 
            // lbl_dropoffDest
            // 
            this.lbl_dropoffDest.AutoSize = true;
            this.lbl_dropoffDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_dropoffDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.lbl_dropoffDest.Location = new System.Drawing.Point(53, 289);
            this.lbl_dropoffDest.Name = "lbl_dropoffDest";
            this.lbl_dropoffDest.Size = new System.Drawing.Size(170, 24);
            this.lbl_dropoffDest.TabIndex = 35;
            this.lbl_dropoffDest.Text = "Dropoff destination:";
            // 
            // lbl_pickupAddress
            // 
            this.lbl_pickupAddress.AutoSize = true;
            this.lbl_pickupAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pickupAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.lbl_pickupAddress.Location = new System.Drawing.Point(79, 210);
            this.lbl_pickupAddress.Name = "lbl_pickupAddress";
            this.lbl_pickupAddress.Size = new System.Drawing.Size(144, 24);
            this.lbl_pickupAddress.TabIndex = 34;
            this.lbl_pickupAddress.Text = "Pickup address:";
            // 
            // lbl_pickupTime
            // 
            this.lbl_pickupTime.AutoSize = true;
            this.lbl_pickupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pickupTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.lbl_pickupTime.Location = new System.Drawing.Point(111, 136);
            this.lbl_pickupTime.Name = "lbl_pickupTime";
            this.lbl_pickupTime.Size = new System.Drawing.Size(112, 24);
            this.lbl_pickupTime.TabIndex = 33;
            this.lbl_pickupTime.Text = "Pickup time:";
            // 
            // btn_phone
            // 
            this.btn_phone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_phone.BackgroundImage")));
            this.btn_phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_phone.FlatAppearance.BorderSize = 0;
            this.btn_phone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btn_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phone.Location = new System.Drawing.Point(282, 480);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(40, 40);
            this.btn_phone.TabIndex = 32;
            this.btn_phone.UseVisualStyleBackColor = true;
            // 
            // frm_callTaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1204, 681);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_callTaxi";
            this.Text = "frm_callTaxi";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_requestTaxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nightRate;
        private System.Windows.Forms.Label lbl_dayRate;
        private System.Windows.Forms.Label lbl_journey;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_vehicleType;
        private System.Windows.Forms.Label lbl_numberPassengers;
        private System.Windows.Forms.Label lbl_booking;
        private System.Windows.Forms.Label lbl_dropoffDest;
        private System.Windows.Forms.Label lbl_pickupAddress;
        private System.Windows.Forms.Label lbl_pickupTime;
        private System.Windows.Forms.Button btn_phone;
    }
}