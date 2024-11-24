namespace FLIGHT_RESERVATION.Flight_Booking
{
    partial class FlightBooking_PaymentDetails
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardDetails1 = new FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_.CardDetails();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnChangeType = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cardDetails1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(623, 369);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cardDetails1
            // 
            this.cardDetails1.Location = new System.Drawing.Point(3, 3);
            this.cardDetails1.Name = "cardDetails1";
            this.cardDetails1.Size = new System.Drawing.Size(623, 369);
            this.cardDetails1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(185, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 69;
            this.button1.TabStop = false;
            this.button1.Text = "CONTINUE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(351, 483);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(146, 49);
            this.btnContinue.TabIndex = 68;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnChangeType
            // 
            this.btnChangeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
            this.btnChangeType.Location = new System.Drawing.Point(218, 22);
            this.btnChangeType.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(246, 62);
            this.btnChangeType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeType.TabIndex = 70;
            this.btnChangeType.TabStop = false;
            // 
            // FlightBooking_PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FlightBooking_PaymentDetails";
            this.Size = new System.Drawing.Size(682, 552);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox btnChangeType;
        public FlightBookings__CardDetails_.CardDetails cardDetails1;
    }
}
