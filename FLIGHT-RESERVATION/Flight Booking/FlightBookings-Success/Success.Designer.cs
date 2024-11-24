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
            this.lblManageBookings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(238, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFlightBookedSuccessfully
            // 
            this.lblFlightBookedSuccessfully.AutoSize = true;
            this.lblFlightBookedSuccessfully.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightBookedSuccessfully.Location = new System.Drawing.Point(120, 252);
            this.lblFlightBookedSuccessfully.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlightBookedSuccessfully.Name = "lblFlightBookedSuccessfully";
            this.lblFlightBookedSuccessfully.Size = new System.Drawing.Size(443, 48);
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
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(229, 370);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(224, 76);
            this.btnContinue.TabIndex = 34;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(61, 300);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(411, 23);
            this.lblSuccess.TabIndex = 35;
            this.lblSuccess.Text = "Kindly check your email for the ticket or go to ";
            this.lblSuccess.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblManageBookings
            // 
            this.lblManageBookings.AutoSize = true;
            this.lblManageBookings.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageBookings.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblManageBookings.Location = new System.Drawing.Point(463, 300);
            this.lblManageBookings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageBookings.Name = "lblManageBookings";
            this.lblManageBookings.Size = new System.Drawing.Size(156, 23);
            this.lblManageBookings.TabIndex = 36;
            this.lblManageBookings.Text = "Manage Bookings";
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblManageBookings);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblFlightBookedSuccessfully);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Success";
            this.Size = new System.Drawing.Size(682, 552);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFlightBookedSuccessfully;
        public System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblManageBookings;
    }
}
