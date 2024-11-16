namespace FLIGHT_RESERVATION
{
    partial class FlightBooking_FlightDetails
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
            this.btnChangeType = new System.Windows.Forms.PictureBox();
            this.pnlFlightBooking = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeType
            // 
            this.btnChangeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
            this.btnChangeType.Location = new System.Drawing.Point(261, 14);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(328, 76);
            this.btnChangeType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnChangeType.TabIndex = 1;
            this.btnChangeType.TabStop = false;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // pnlFlightBooking
            // 
            this.pnlFlightBooking.Location = new System.Drawing.Point(20, 128);
            this.pnlFlightBooking.Name = "pnlFlightBooking";
            this.pnlFlightBooking.Size = new System.Drawing.Size(871, 549);
            this.pnlFlightBooking.TabIndex = 2;
            // 
            // FlightBooking_FlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlFlightBooking);
            this.Controls.Add(this.btnChangeType);
            this.Name = "FlightBooking_FlightDetails";
            this.Size = new System.Drawing.Size(906, 677);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnChangeType;
        private System.Windows.Forms.Panel pnlFlightBooking;
    }
}
