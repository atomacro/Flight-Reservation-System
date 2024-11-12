namespace FLIGHT_RESERVATION.Flight_Booking
{
    partial class FlightBooking_AvailableFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightBooking_AvailableFlights));
            this.lblAvailableFlights = new System.Windows.Forms.Label();
            this.pnlAvailableFlights = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableFlights
            // 
            this.lblAvailableFlights.AutoSize = true;
            this.lblAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableFlights.Location = new System.Drawing.Point(273, 47);
            this.lblAvailableFlights.Name = "lblAvailableFlights";
            this.lblAvailableFlights.Size = new System.Drawing.Size(350, 60);
            this.lblAvailableFlights.TabIndex = 1;
            this.lblAvailableFlights.Text = "Available Flights";
            // 
            // pnlAvailableFlights
            // 
            this.pnlAvailableFlights.AutoScroll = true;
            this.pnlAvailableFlights.Location = new System.Drawing.Point(85, 110);
            this.pnlAvailableFlights.Name = "pnlAvailableFlights";
            this.pnlAvailableFlights.Size = new System.Drawing.Size(746, 420);
            this.pnlAvailableFlights.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FlightBooking_AvailableFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlAvailableFlights);
            this.Controls.Add(this.lblAvailableFlights);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlightBooking_AvailableFlights";
            this.Size = new System.Drawing.Size(906, 677);
            this.Load += new System.EventHandler(this.FlightBooking_AvailableFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAvailableFlights;
        private System.Windows.Forms.FlowLayoutPanel pnlAvailableFlights;
    }
}
