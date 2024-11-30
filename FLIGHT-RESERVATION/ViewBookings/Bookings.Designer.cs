namespace FLIGHT_RESERVATION
{
    partial class Bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblLocation2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAirplaneNumber = new System.Windows.Forms.Label();
            this.roundedButton1 = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation1.Font = new System.Drawing.Font("Kantumruy Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblLocation1.Location = new System.Drawing.Point(2, 0);
            this.lblLocation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(69, 38);
            this.lblLocation1.TabIndex = 1;
            this.lblLocation1.Text = "MNL";
            this.lblLocation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLocation1.Click += new System.EventHandler(this.lblLocation1_Click);
            // 
            // lblLocation2
            // 
            this.lblLocation2.AutoEllipsis = true;
            this.lblLocation2.AutoSize = true;
            this.lblLocation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation2.Font = new System.Drawing.Font("Kantumruy Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblLocation2.Location = new System.Drawing.Point(295, 0);
            this.lblLocation2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation2.Name = "lblLocation2";
            this.lblLocation2.Size = new System.Drawing.Size(71, 38);
            this.lblLocation2.TabIndex = 2;
            this.lblLocation2.Text = "ORD";
            this.lblLocation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLocation2.Click += new System.EventHandler(this.lblLocation2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(216, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime2.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(295, 38);
            this.lblTime2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(71, 31);
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
            this.lblTime1.Location = new System.Drawing.Point(2, 38);
            this.lblTime1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(69, 31);
            this.lblTime1.TabIndex = 5;
            this.lblTime1.Text = "13:34";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime1.Click += new System.EventHandler(this.lblTime1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblLocation1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 69);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(22, 20);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 21);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "November 09, 2024";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblAirplaneNumber
            // 
            this.lblAirplaneNumber.AutoSize = true;
            this.lblAirplaneNumber.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirplaneNumber.Location = new System.Drawing.Point(283, 20);
            this.lblAirplaneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAirplaneNumber.Name = "lblAirplaneNumber";
            this.lblAirplaneNumber.Size = new System.Drawing.Size(105, 21);
            this.lblAirplaneNumber.TabIndex = 7;
            this.lblAirplaneNumber.Text = "Flight: ABC123";
            this.lblAirplaneNumber.Click += new System.EventHandler(this.lblAirplaneNumber_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(391, 52);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(123, 40);
            this.roundedButton1.TabIndex = 8;
            this.roundedButton1.Text = "View";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.lblAirplaneNumber);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblDate);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bookings";
            this.Size = new System.Drawing.Size(532, 146);
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblLocation2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAirplaneNumber;
        private CustomControls.RoundedButton roundedButton1;
    }
}
