namespace FLIGHT_RESERVATION
{
    partial class FlightBookings_GuestDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAvailableFlights = new System.Windows.Forms.Label();
            this.pnlGuestDetails = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(834, 468);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 465);
            this.panel1.TabIndex = 0;
            // 
            // lblAvailableFlights
            // 
            this.lblAvailableFlights.AutoSize = true;
            this.lblAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableFlights.Location = new System.Drawing.Point(184, 24);
            this.lblAvailableFlights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableFlights.Name = "lblAvailableFlights";
            this.lblAvailableFlights.Size = new System.Drawing.Size(298, 48);
            this.lblAvailableFlights.TabIndex = 2;
            this.lblAvailableFlights.Text = "Passenger Details";
            // 
            // pnlGuestDetails
            // 
            this.pnlGuestDetails.AutoScroll = true;
            this.pnlGuestDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlGuestDetails.Location = new System.Drawing.Point(16, 83);
            this.pnlGuestDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGuestDetails.Name = "pnlGuestDetails";
            this.pnlGuestDetails.Size = new System.Drawing.Size(656, 377);
            this.pnlGuestDetails.TabIndex = 6;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(349, 483);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(130, 52);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Location = new System.Drawing.Point(202, 483);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 52);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FlightBookings_GuestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlGuestDetails);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblAvailableFlights);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlightBookings_GuestDetails";
            this.Size = new System.Drawing.Size(680, 552);
            this.Load += new System.EventHandler(this.FlightBookings_GuestDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAvailableFlights;
        private System.Windows.Forms.Panel pnlGuestDetails;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnContinue;
    }
}
