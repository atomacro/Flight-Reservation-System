namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_Success
{
    partial class Success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFlightBookedSuccessfully = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblViewBookings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(317, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFlightBookedSuccessfully
            // 
            this.lblFlightBookedSuccessfully.AutoSize = true;
            this.lblFlightBookedSuccessfully.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightBookedSuccessfully.Location = new System.Drawing.Point(160, 310);
            this.lblFlightBookedSuccessfully.Name = "lblFlightBookedSuccessfully";
            this.lblFlightBookedSuccessfully.Size = new System.Drawing.Size(554, 60);
            this.lblFlightBookedSuccessfully.TabIndex = 2;
            this.lblFlightBookedSuccessfully.Text = "Flight Booked Successfully";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(305, 455);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(299, 94);
            this.btnContinue.TabIndex = 34;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(81, 369);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(504, 29);
            this.lblSuccess.TabIndex = 35;
            this.lblSuccess.Text = "Kindly check your email for the ticket or go to ";
            this.lblSuccess.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblViewBookings
            // 
            this.lblViewBookings.AutoSize = true;
            this.lblViewBookings.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBookings.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblViewBookings.Location = new System.Drawing.Point(617, 369);
            this.lblViewBookings.Name = "lblViewBookings";
            this.lblViewBookings.Size = new System.Drawing.Size(164, 29);
            this.lblViewBookings.TabIndex = 36;
            this.lblViewBookings.Text = "View Bookings";
            this.lblViewBookings.Click += new System.EventHandler(this.lblManageBookings_Click);
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblViewBookings);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblFlightBookedSuccessfully);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Success";
            this.Size = new System.Drawing.Size(909, 679);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFlightBookedSuccessfully;
        public System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSuccess;
        public System.Windows.Forms.Label lblViewBookings;
    }
}
