namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_PaymentDetails
{
    partial class GCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCash));
            this.lblBookingTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.lblReferenceNumber = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingTotal
            // 
            this.lblBookingTotal.AutoSize = true;
            this.lblBookingTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingTotal.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingTotal.Location = new System.Drawing.Point(190, 29);
            this.lblBookingTotal.Name = "lblBookingTotal";
            this.lblBookingTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookingTotal.Size = new System.Drawing.Size(124, 23);
            this.lblBookingTotal.TabIndex = 0;
            this.lblBookingTotal.Text = "Booking Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(311, 29);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPrice.Size = new System.Drawing.Size(121, 23);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "99999.99 Php";
            // 
            // picQrCode
            // 
            this.picQrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQrCode.Image = ((System.Drawing.Image)(resources.GetObject("picQrCode.Image")));
            this.picQrCode.Location = new System.Drawing.Point(216, 59);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(191, 175);
            this.picQrCode.TabIndex = 2;
            this.picQrCode.TabStop = false;
            // 
            // lblReferenceNumber
            // 
            this.lblReferenceNumber.AutoSize = true;
            this.lblReferenceNumber.Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenceNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblReferenceNumber.Location = new System.Drawing.Point(188, 251);
            this.lblReferenceNumber.Name = "lblReferenceNumber";
            this.lblReferenceNumber.Size = new System.Drawing.Size(126, 19);
            this.lblReferenceNumber.TabIndex = 5;
            this.lblReferenceNumber.Text = "Reference Number";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtReferenceNumber.BorderColor = System.Drawing.Color.White;
            this.txtReferenceNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.txtReferenceNumber.BorderRadius = 10;
            this.txtReferenceNumber.BorderSize = 1;
            this.txtReferenceNumber.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.txtReferenceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReferenceNumber.Location = new System.Drawing.Point(178, 269);
            this.txtReferenceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenceNumber.Multiline = false;
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReferenceNumber.PasswordChar = false;
            this.txtReferenceNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtReferenceNumber.PlaceholderText = "XXXXXXXXXXXXX";
            this.txtReferenceNumber.Size = new System.Drawing.Size(266, 35);
            this.txtReferenceNumber.TabIndex = 6;
            this.txtReferenceNumber.UnderlinedStyle = false;
            // 
            // GCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.lblReferenceNumber);
            this.Controls.Add(this.picQrCode);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblBookingTotal);
            this.Name = "GCash";
            this.Size = new System.Drawing.Size(623, 369);
            this.Load += new System.EventHandler(this.GCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.Label lblReferenceNumber;
        private CustomControls.RoundedTextBox txtReferenceNumber;
    }
}
