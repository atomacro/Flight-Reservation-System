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
            this.pnlPaymentDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChangeType = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaymentDetails
            // 
            this.pnlPaymentDetails.Location = new System.Drawing.Point(30, 101);
            this.pnlPaymentDetails.Name = "pnlPaymentDetails";
            this.pnlPaymentDetails.Size = new System.Drawing.Size(623, 369);
            this.pnlPaymentDetails.TabIndex = 0;
            // 
            // btnChangeType
            // 
            this.btnChangeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.Card_button;
            this.btnChangeType.Location = new System.Drawing.Point(218, 22);
            this.btnChangeType.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(246, 62);
            this.btnChangeType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeType.TabIndex = 70;
            this.btnChangeType.TabStop = false;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
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
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
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
            // FlightBooking_PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChangeType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pnlPaymentDetails);
            this.Name = "FlightBooking_PaymentDetails";
            this.Size = new System.Drawing.Size(682, 552);
            this.Load += new System.EventHandler(this.FlightBooking_PaymentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPaymentDetails;
        private System.Windows.Forms.PictureBox btnChangeType;
        public System.Windows.Forms.Button btnContinue;
        public System.Windows.Forms.Button button1;
    }
}
