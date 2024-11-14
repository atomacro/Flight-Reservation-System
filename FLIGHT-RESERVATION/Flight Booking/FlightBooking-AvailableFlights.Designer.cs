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
            this.btnContinueAvailableFlights = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableFlights
            // 
            this.lblAvailableFlights.AutoSize = true;
            this.lblAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableFlights.Location = new System.Drawing.Point(267, 30);
            this.lblAvailableFlights.Name = "lblAvailableFlights";
            this.lblAvailableFlights.Size = new System.Drawing.Size(350, 60);
            this.lblAvailableFlights.TabIndex = 1;
            this.lblAvailableFlights.Text = "Available Flights";
            // 
            // pnlAvailableFlights
            // 
            this.pnlAvailableFlights.AutoScroll = true;
            this.pnlAvailableFlights.Location = new System.Drawing.Point(43, 144);
            this.pnlAvailableFlights.Name = "pnlAvailableFlights";
            this.pnlAvailableFlights.Size = new System.Drawing.Size(821, 394);
            this.pnlAvailableFlights.TabIndex = 2;
            // 
            // btnContinueAvailableFlights
            // 
            this.btnContinueAvailableFlights.BackColor = System.Drawing.Color.Transparent;
            this.btnContinueAvailableFlights.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON;
            this.btnContinueAvailableFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinueAvailableFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAvailableFlights.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueAvailableFlights.ForeColor = System.Drawing.Color.White;
            this.btnContinueAvailableFlights.Location = new System.Drawing.Point(441, 589);
            this.btnContinueAvailableFlights.Name = "btnContinueAvailableFlights";
            this.btnContinueAvailableFlights.Size = new System.Drawing.Size(173, 64);
            this.btnContinueAvailableFlights.TabIndex = 4;
            this.btnContinueAvailableFlights.Text = "Continue";
            this.btnContinueAvailableFlights.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnBack.Location = new System.Drawing.Point(243, 589);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 64);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FlightBooking_AvailableFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnContinueAvailableFlights);
            this.Controls.Add(this.btnBack);
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
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnContinueAvailableFlights;
    }
}
