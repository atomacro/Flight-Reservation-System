namespace FLIGHT_RESERVATION
{
    partial class View_Bookings
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
            this.pnlBookings = new System.Windows.Forms.FlowLayoutPanel();
            this.bookings1 = new FLIGHT_RESERVATION.Bookings();
            this.pnlBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBookings
            // 
            this.pnlBookings.Controls.Add(this.bookings1);
            this.pnlBookings.Location = new System.Drawing.Point(39, 146);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(744, 588);
            this.pnlBookings.TabIndex = 1;
            // 
            // bookings1
            // 
            this.bookings1.Location = new System.Drawing.Point(3, 3);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(8, 8);
            this.bookings1.TabIndex = 0;
            // 
            // View_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBookings);
            this.Name = "View_Bookings";
            this.Size = new System.Drawing.Size(981, 737);
            this.Load += new System.EventHandler(this.View_Bookings_Load);
            this.pnlBookings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBookings;
        private Bookings bookings1;
    }
}
