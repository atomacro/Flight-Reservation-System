﻿namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_AvailableFlights
{
    partial class AvailableFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableFlights));
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblLocation2 = new System.Windows.Forms.Label();
            this.lblSeatsAvailable = new System.Windows.Forms.Label();
            this.tblLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tblLayoutPanel.ColumnCount = 3;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.07246F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.92754F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tblLayoutPanel.Controls.Add(this.lblLocation1, 0, 0);
            this.tblLayoutPanel.Controls.Add(this.lblTime2, 2, 1);
            this.tblLayoutPanel.Controls.Add(this.lblTime1, 0, 1);
            this.tblLayoutPanel.Controls.Add(this.lblLocation2, 2, 0);
            this.tblLayoutPanel.Controls.Add(this.pictureBox1, 1, 0);
            this.tblLayoutPanel.Location = new System.Drawing.Point(19, 25);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tblLayoutPanel.RowCount = 2;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblLayoutPanel.Size = new System.Drawing.Size(461, 85);
            this.tblLayoutPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation1.Font = new System.Drawing.Font("Kantumruy Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation1.Location = new System.Drawing.Point(3, 0);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(113, 47);
            this.lblLocation1.TabIndex = 1;
            this.lblLocation1.Text = "MNL";
            this.lblLocation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime2.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(344, 47);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(114, 38);
            this.lblTime2.TabIndex = 4;
            this.lblTime2.Text = "07:50";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime2.Click += new System.EventHandler(this.lblTime2_Click);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime1.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(3, 47);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(113, 38);
            this.lblTime1.TabIndex = 5;
            this.lblTime1.Text = "13:34";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLocation2
            // 
            this.lblLocation2.AutoEllipsis = true;
            this.lblLocation2.AutoSize = true;
            this.lblLocation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation2.Font = new System.Drawing.Font("Kantumruy Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation2.Location = new System.Drawing.Point(344, 0);
            this.lblLocation2.Name = "lblLocation2";
            this.lblLocation2.Size = new System.Drawing.Size(114, 47);
            this.lblLocation2.TabIndex = 2;
            this.lblLocation2.Text = "SIN";
            this.lblLocation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeatsAvailable
            // 
            this.lblSeatsAvailable.AutoSize = true;
            this.lblSeatsAvailable.Font = new System.Drawing.Font("Kantumruy Pro Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblSeatsAvailable.Location = new System.Drawing.Point(486, 55);
            this.lblSeatsAvailable.Name = "lblSeatsAvailable";
            this.lblSeatsAvailable.Size = new System.Drawing.Size(183, 28);
            this.lblSeatsAvailable.TabIndex = 8;
            this.lblSeatsAvailable.Text = "3 Seats Available";
            // 
            // AvailableFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.Unselected_Border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblSeatsAvailable);
            this.Controls.Add(this.tblLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "AvailableFlights";
            this.Size = new System.Drawing.Size(698, 138);
            this.Load += new System.EventHandler(this.AvailableFlights_Load);
            this.tblLayoutPanel.ResumeLayout(false);
            this.tblLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblLocation2;
        private System.Windows.Forms.Label lblSeatsAvailable;
        public System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
