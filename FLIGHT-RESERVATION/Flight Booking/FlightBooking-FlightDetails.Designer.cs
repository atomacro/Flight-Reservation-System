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
            this.pnlFlightBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFlightBooking
            // 
            this.pnlFlightBooking.Location = new System.Drawing.Point(15, 106);
            this.pnlFlightBooking.Name = "pnlFlightBooking";
            this.pnlFlightBooking.Size = new System.Drawing.Size(871, 571);
            this.pnlFlightBooking.TabIndex = 0;
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
    }
}
