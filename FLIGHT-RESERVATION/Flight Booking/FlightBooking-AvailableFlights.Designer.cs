namespace FLIGHT_RESERVATION { 
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
            this.lblAvailableFlights = new System.Windows.Forms.Label();
            this.pnlAvailableFlights = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFlightType = new System.Windows.Forms.Label();
            this.btnContinueAvailableFlights = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableFlights
            // 
            this.lblAvailableFlights.AutoSize = true;
            this.lblAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableFlights.Location = new System.Drawing.Point(205, 24);
            this.lblAvailableFlights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableFlights.Name = "lblAvailableFlights";
            this.lblAvailableFlights.Size = new System.Drawing.Size(277, 48);
            this.lblAvailableFlights.TabIndex = 1;
            this.lblAvailableFlights.Text = "Available Flights";
            // 
            // pnlAvailableFlights
            // 
            this.pnlAvailableFlights.AutoScroll = true;
            this.pnlAvailableFlights.Location = new System.Drawing.Point(32, 117);
            this.pnlAvailableFlights.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAvailableFlights.Name = "pnlAvailableFlights";
            this.pnlAvailableFlights.Size = new System.Drawing.Size(616, 320);
            this.pnlAvailableFlights.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFlightType
            // 
            this.lblFlightType.AutoSize = true;
            this.lblFlightType.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFlightType.ForeColor = System.Drawing.Color.DimGray;
            this.lblFlightType.Location = new System.Drawing.Point(234, 73);
            this.lblFlightType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlightType.Name = "lblFlightType";
            this.lblFlightType.Size = new System.Drawing.Size(228, 28);
            this.lblFlightType.TabIndex = 5;
            this.lblFlightType.Text = "Select Departure Flight";
            // 
            // btnContinueAvailableFlights
            // 
            this.btnContinueAvailableFlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.btnContinueAvailableFlights.BorderRadius = 23;
            this.btnContinueAvailableFlights.FlatAppearance.BorderSize = 0;
            this.btnContinueAvailableFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnContinueAvailableFlights.ForeColor = System.Drawing.Color.White;
            this.btnContinueAvailableFlights.Location = new System.Drawing.Point(317, 479);
            this.btnContinueAvailableFlights.Name = "btnContinueAvailableFlights";
            this.btnContinueAvailableFlights.Size = new System.Drawing.Size(130, 52);
            this.btnContinueAvailableFlights.TabIndex = 36;
            this.btnContinueAvailableFlights.Text = "Continue";
            this.btnContinueAvailableFlights.UseVisualStyleBackColor = false;
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
            this.btnBack.Location = new System.Drawing.Point(182, 479);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FlightBooking_AvailableFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnContinueAvailableFlights);
            this.Controls.Add(this.lblFlightType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlAvailableFlights);
            this.Controls.Add(this.lblAvailableFlights);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightBooking_AvailableFlights";
            this.Size = new System.Drawing.Size(680, 550);
            this.Load += new System.EventHandler(this.FlightBooking_AvailableFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAvailableFlights;
        private System.Windows.Forms.FlowLayoutPanel pnlAvailableFlights;
        private System.Windows.Forms.Label lblFlightType;
        public System.Windows.Forms.Button btnBack;
        public CustomControls.RoundedButton btnContinueAvailableFlights;
    }
}
