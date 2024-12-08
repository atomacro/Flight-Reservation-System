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
            this.btnSortInternational = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.btnSortLocal = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeType
            // 
            this.btnChangeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
            this.btnChangeType.Location = new System.Drawing.Point(218, 10);
            this.btnChangeType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(220, 58);
            this.btnChangeType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeType.TabIndex = 1;
            this.btnChangeType.TabStop = false;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // pnlFlightBooking
            // 
            this.pnlFlightBooking.Location = new System.Drawing.Point(15, 104);
            this.pnlFlightBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFlightBooking.Name = "pnlFlightBooking";
            this.pnlFlightBooking.Size = new System.Drawing.Size(653, 446);
            this.pnlFlightBooking.TabIndex = 2;
            // 
            // btnSortInternational
            // 
            this.btnSortInternational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.btnSortInternational.BorderRadius = 15;
            this.btnSortInternational.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortInternational.FlatAppearance.BorderSize = 0;
            this.btnSortInternational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortInternational.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSortInternational.ForeColor = System.Drawing.Color.Black;
            this.btnSortInternational.Location = new System.Drawing.Point(102, 55);
            this.btnSortInternational.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSortInternational.Name = "btnSortInternational";
            this.btnSortInternational.Size = new System.Drawing.Size(112, 45);
            this.btnSortInternational.TabIndex = 6;
            this.btnSortInternational.Text = "International";
            this.btnSortInternational.UseVisualStyleBackColor = false;
            this.btnSortInternational.Click += new System.EventHandler(this.btnSortInternational_Click);
            // 
            // btnSortLocal
            // 
            this.btnSortLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.btnSortLocal.BorderRadius = 15;
            this.btnSortLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortLocal.FlatAppearance.BorderSize = 0;
            this.btnSortLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortLocal.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSortLocal.ForeColor = System.Drawing.Color.Black;
            this.btnSortLocal.Location = new System.Drawing.Point(15, 54);
            this.btnSortLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSortLocal.Name = "btnSortLocal";
            this.btnSortLocal.Size = new System.Drawing.Size(83, 45);
            this.btnSortLocal.TabIndex = 5;
            this.btnSortLocal.Text = "Local";
            this.btnSortLocal.UseVisualStyleBackColor = false;
            this.btnSortLocal.Click += new System.EventHandler(this.btnSortLocal_Click);
            // 
            // FlightBooking_FlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSortInternational);
            this.Controls.Add(this.btnSortLocal);
            this.Controls.Add(this.pnlFlightBooking);
            this.Controls.Add(this.btnChangeType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlightBooking_FlightDetails";
            this.Size = new System.Drawing.Size(680, 550);
            this.Load += new System.EventHandler(this.FlightBooking_FlightDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnChangeType;
        private System.Windows.Forms.Panel pnlFlightBooking;
        private CustomControls.RoundedButton btnSortInternational;
        private CustomControls.RoundedButton btnSortLocal;
    }
}
