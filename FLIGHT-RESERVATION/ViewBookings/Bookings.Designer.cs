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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblLocation2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(29, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(173, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "November 09, 2024";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation1.Font = new System.Drawing.Font("Kantumruy Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation1.Location = new System.Drawing.Point(3, 0);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(112, 47);
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
            this.lblLocation2.Font = new System.Drawing.Font("Kantumruy Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation2.Location = new System.Drawing.Point(507, 0);
            this.lblLocation2.Name = "lblLocation2";
            this.lblLocation2.Size = new System.Drawing.Size(109, 47);
            this.lblLocation2.TabIndex = 2;
            this.lblLocation2.Text = "SIN";
            this.lblLocation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLocation2.Click += new System.EventHandler(this.lblLocation2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime2.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(507, 47);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(109, 38);
            this.lblTime2.TabIndex = 4;
            this.lblTime2.Text = "07:50";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime2.Click += new System.EventHandler(this.lblTime2_Click);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime1.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(3, 47);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(112, 38);
            this.lblTime1.TabIndex = 5;
            this.lblTime1.Text = "13:34";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTime1.Click += new System.EventHandler(this.lblTime1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.4127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.5873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.lblLocation1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 85);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblDate);
            this.DoubleBuffered = true;
            this.Name = "Bookings";
            this.Size = new System.Drawing.Size(699, 180);
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblLocation2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
