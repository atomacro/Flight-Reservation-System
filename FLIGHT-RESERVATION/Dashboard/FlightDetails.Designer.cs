namespace FLIGHT_RESERVATION.Dashboard
{
    partial class FlightDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightDetails));
            this.btnClose = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFlightType = new System.Windows.Forms.Label();
            this.lblFlightPrice = new System.Windows.Forms.Label();
            this.lblArrivalAirport = new System.Windows.Forms.Label();
            this.lblDepartureAirport = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAirplaneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblLocation2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.btnClose.BorderRadius = 20;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(517, 616);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 49);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.label13.Location = new System.Drawing.Point(137, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(552, 35);
            this.label13.TabIndex = 19;
            this.label13.Text = "Thank you for using Airplane Ticketing System";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(47, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 365);
            this.panel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.48101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.51899F));
            this.tableLayoutPanel2.Controls.Add(this.lblFlightType, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblFlightPrice, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblArrivalAirport, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDepartureAirport, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDepartureDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAirplaneNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblArrivalDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(647, 406);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // lblFlightType
            // 
            this.lblFlightType.AutoSize = true;
            this.lblFlightType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFlightType.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFlightType.ForeColor = System.Drawing.Color.Black;
            this.lblFlightType.Location = new System.Drawing.Point(252, 367);
            this.lblFlightType.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblFlightType.Name = "lblFlightType";
            this.lblFlightType.Size = new System.Drawing.Size(55, 26);
            this.lblFlightType.TabIndex = 25;
            this.lblFlightType.Text = "Local";
            this.lblFlightType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFlightPrice
            // 
            this.lblFlightPrice.AutoSize = true;
            this.lblFlightPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFlightPrice.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFlightPrice.ForeColor = System.Drawing.Color.Black;
            this.lblFlightPrice.Location = new System.Drawing.Point(252, 316);
            this.lblFlightPrice.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblFlightPrice.Name = "lblFlightPrice";
            this.lblFlightPrice.Size = new System.Drawing.Size(122, 26);
            this.lblFlightPrice.TabIndex = 24;
            this.lblFlightPrice.Text = "3,500.00 Php";
            this.lblFlightPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrivalAirport
            // 
            this.lblArrivalAirport.AutoSize = true;
            this.lblArrivalAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblArrivalAirport.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblArrivalAirport.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalAirport.Location = new System.Drawing.Point(252, 241);
            this.lblArrivalAirport.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblArrivalAirport.Name = "lblArrivalAirport";
            this.lblArrivalAirport.Size = new System.Drawing.Size(289, 50);
            this.lblArrivalAirport.TabIndex = 23;
            this.lblArrivalAirport.Text = "Mactan-Cebu International Airport\r\nCebu, PH\r\n";
            this.lblArrivalAirport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartureAirport
            // 
            this.lblDepartureAirport.AutoSize = true;
            this.lblDepartureAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDepartureAirport.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartureAirport.ForeColor = System.Drawing.Color.Black;
            this.lblDepartureAirport.Location = new System.Drawing.Point(252, 166);
            this.lblDepartureAirport.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblDepartureAirport.Name = "lblDepartureAirport";
            this.lblDepartureAirport.Size = new System.Drawing.Size(286, 50);
            this.lblDepartureAirport.TabIndex = 22;
            this.lblDepartureAirport.Text = "Ninoy Aquino International Airport\r\nManila, PH\r\n";
            this.lblDepartureAirport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDepartureDate.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartureDate.ForeColor = System.Drawing.Color.Black;
            this.lblDepartureDate.Location = new System.Drawing.Point(252, 64);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(173, 26);
            this.lblDepartureDate.TabIndex = 21;
            this.lblDepartureDate.Text = "November 09, 2024";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(5, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Arrival Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Airplane Number:";
            // 
            // lblAirplaneNumber
            // 
            this.lblAirplaneNumber.AutoSize = true;
            this.lblAirplaneNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAirplaneNumber.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAirplaneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAirplaneNumber.Location = new System.Drawing.Point(252, 13);
            this.lblAirplaneNumber.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblAirplaneNumber.Name = "lblAirplaneNumber";
            this.lblAirplaneNumber.Size = new System.Drawing.Size(127, 26);
            this.lblAirplaneNumber.TabIndex = 11;
            this.lblAirplaneNumber.Text = "Flight: ABC123";
            this.lblAirplaneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Departure Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(5, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 50);
            this.label4.TabIndex = 17;
            this.label4.Text = "Departure Airport:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblArrivalDate.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblArrivalDate.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalDate.Location = new System.Drawing.Point(252, 115);
            this.lblArrivalDate.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(173, 26);
            this.lblArrivalDate.TabIndex = 9;
            this.lblArrivalDate.Text = "November 09, 2024";
            this.lblArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(5, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 50);
            this.label5.TabIndex = 18;
            this.label5.Text = "Arrival Airport:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(5, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Flight Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Flight Type:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblLocation1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 85);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation1.Font = new System.Drawing.Font("Kantumruy Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblLocation1.Location = new System.Drawing.Point(4, 1);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(127, 44);
            this.lblLocation1.TabIndex = 1;
            this.lblLocation1.Text = "MNL";
            this.lblLocation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime2.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.lblTime2.Location = new System.Drawing.Point(539, 46);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(128, 38);
            this.lblTime2.TabIndex = 4;
            this.lblTime2.Text = "07:50";
            this.lblTime2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime1.Font = new System.Drawing.Font("Kantumruy Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.lblTime1.Location = new System.Drawing.Point(4, 46);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(127, 38);
            this.lblTime1.TabIndex = 5;
            this.lblTime1.Text = "13:34";
            this.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLocation2
            // 
            this.lblLocation2.AutoEllipsis = true;
            this.lblLocation2.AutoSize = true;
            this.lblLocation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation2.Font = new System.Drawing.Font("Kantumruy Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblLocation2.Location = new System.Drawing.Point(539, 1);
            this.lblLocation2.Name = "lblLocation2";
            this.lblLocation2.Size = new System.Drawing.Size(128, 44);
            this.lblLocation2.TabIndex = 2;
            this.lblLocation2.Text = "ORD";
            this.lblLocation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(394, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FLIGHT_RESERVATION.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(31, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // FlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlightDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightDetails";
            this.Load += new System.EventHandler(this.FlightDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFlightType;
        private System.Windows.Forms.Label lblFlightPrice;
        private System.Windows.Forms.Label lblArrivalAirport;
        private System.Windows.Forms.Label lblDepartureAirport;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAirplaneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblLocation2;
    }
}