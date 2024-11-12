namespace FLIGHT_RESERVATION
{
    partial class FlightBooking_TwoWay
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
            this.pnlFlightBooking = new System.Windows.Forms.FlowLayoutPanel();
            this.round_Trip1 = new FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails.Round_Trip();
            this.pnlFlightBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFlightBooking
            // 
            this.pnlFlightBooking.Controls.Add(this.round_Trip1);
            this.pnlFlightBooking.Location = new System.Drawing.Point(15, 106);
            this.pnlFlightBooking.Name = "pnlFlightBooking";
            this.pnlFlightBooking.Size = new System.Drawing.Size(871, 571);
            this.pnlFlightBooking.TabIndex = 0;
            // 
            // round_Trip1
            // 
            this.round_Trip1.BackColor = System.Drawing.Color.White;
            this.round_Trip1.Location = new System.Drawing.Point(3, 3);
            this.round_Trip1.Name = "round_Trip1";
            this.round_Trip1.Size = new System.Drawing.Size(871, 571);
            this.round_Trip1.TabIndex = 0;
            // 
            // FlightBooking_TwoWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFlightBooking);
            this.Name = "FlightBooking_TwoWay";
            this.Size = new System.Drawing.Size(906, 677);
            this.pnlFlightBooking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFlightBooking;
        private Flight_Booking.FlightBooking_FlightDetails.Round_Trip round_Trip1;
    }
}
