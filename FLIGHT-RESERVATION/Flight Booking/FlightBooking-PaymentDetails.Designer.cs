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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaymentDetails
            // 
            this.pnlPaymentDetails.Location = new System.Drawing.Point(40, 124);
            this.pnlPaymentDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPaymentDetails.Name = "pnlPaymentDetails";
            this.pnlPaymentDetails.Size = new System.Drawing.Size(831, 415);
            this.pnlPaymentDetails.TabIndex = 0;
            // 
            // btnChangeType
            // 
            this.btnChangeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.Card_button;
            this.btnChangeType.Location = new System.Drawing.Point(291, 27);
            this.btnChangeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(328, 76);
            this.btnChangeType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeType.TabIndex = 70;
            this.btnChangeType.TabStop = false;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnBack.Location = new System.Drawing.Point(247, 561);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(195, 60);
            this.btnBack.TabIndex = 69;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(468, 561);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(195, 60);
            this.btnContinue.TabIndex = 68;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // FlightBooking_PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChangeType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pnlPaymentDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FlightBooking_PaymentDetails";
            this.Size = new System.Drawing.Size(909, 679);
            this.Load += new System.EventHandler(this.FlightBooking_PaymentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPaymentDetails;
        private System.Windows.Forms.PictureBox btnChangeType;
        public System.Windows.Forms.Button btnContinue;
        public System.Windows.Forms.Button btnBack;
    }
}
