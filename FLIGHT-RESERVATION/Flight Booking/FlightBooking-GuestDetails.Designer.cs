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
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnContinue = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.SuspendLayout();
            // 
            // lblAvailableFlights
            // 
            this.lblAvailableFlights.AutoSize = true;
            this.lblAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableFlights.Location = new System.Drawing.Point(191, 24);
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
            this.pnlGuestDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGuestDetails.Name = "pnlGuestDetails";
            this.pnlGuestDetails.Size = new System.Drawing.Size(656, 377);
            this.pnlGuestDetails.TabIndex = 6;
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(-10, -10);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(0, 0);
            this.btnFocus.TabIndex = 999;
            this.btnFocus.TabStop = false;
            this.btnFocus.Text = "button1";
            this.btnFocus.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.btnBack.Location = new System.Drawing.Point(202, 483);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 52);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.btnContinue.BorderRadius = 23;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(337, 483);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(130, 52);
            this.btnContinue.TabIndex = 1000;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // FlightBookings_GuestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlGuestDetails);
            this.Controls.Add(this.lblAvailableFlights);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnFocus;
        public CustomControls.RoundedButton btnContinue;
    }
}
