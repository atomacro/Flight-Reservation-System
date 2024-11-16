using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails
{
    partial class Round_Trip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Round_Trip));
            this.cboDepartureLocation = new System.Windows.Forms.ComboBox();
            this.picLine = new System.Windows.Forms.PictureBox();
            this.picAirplaneLift = new System.Windows.Forms.PictureBox();
            this.picAirplaneLand = new System.Windows.Forms.PictureBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.cboArrivalLocation = new System.Windows.Forms.ComboBox();
            this.lblArrivalLocation = new System.Windows.Forms.Label();
            this.picCompanions = new System.Windows.Forms.PictureBox();
            this.picClassSeat = new System.Windows.Forms.PictureBox();
            this.picDepartureReturnDate = new System.Windows.Forms.PictureBox();
            this.picDepartureArrivalLocation = new System.Windows.Forms.PictureBox();
            this.lblCompanions = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAdult = new System.Windows.Forms.Label();
            this.numAdult = new System.Windows.Forms.NumericUpDown();
            this.lblChildren = new System.Windows.Forms.Label();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.lblInfant = new System.Windows.Forms.Label();
            this.numInfant = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.cboDepartureDate = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cboReturnDate = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblClassSeat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClassSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureReturnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureArrivalLocation)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDepartureLocation
            // 
            this.cboDepartureLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartureLocation.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureLocation.FormattingEnabled = true;
            this.cboDepartureLocation.Items.AddRange(new object[] {
            "Manila",
            "Singapore",
            "Mexico"});
            this.cboDepartureLocation.Location = new System.Drawing.Point(93, 68);
            this.cboDepartureLocation.Name = "cboDepartureLocation";
            this.cboDepartureLocation.Size = new System.Drawing.Size(183, 37);
            this.cboDepartureLocation.TabIndex = 4;
            // 
            // picLine
            // 
            this.picLine.Image = ((System.Drawing.Image)(resources.GetObject("picLine.Image")));
            this.picLine.Location = new System.Drawing.Point(42, 140);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(425, 11);
            this.picLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLine.TabIndex = 8;
            this.picLine.TabStop = false;
            // 
            // picAirplaneLift
            // 
            this.picAirplaneLift.Image = ((System.Drawing.Image)(resources.GetObject("picAirplaneLift.Image")));
            this.picAirplaneLift.Location = new System.Drawing.Point(37, 79);
            this.picAirplaneLift.Name = "picAirplaneLift";
            this.picAirplaneLift.Size = new System.Drawing.Size(50, 50);
            this.picAirplaneLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAirplaneLift.TabIndex = 9;
            this.picAirplaneLift.TabStop = false;
            // 
            // picAirplaneLand
            // 
            this.picAirplaneLand.Image = ((System.Drawing.Image)(resources.GetObject("picAirplaneLand.Image")));
            this.picAirplaneLand.Location = new System.Drawing.Point(37, 186);
            this.picAirplaneLand.Name = "picAirplaneLand";
            this.picAirplaneLand.Size = new System.Drawing.Size(50, 50);
            this.picAirplaneLand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAirplaneLand.TabIndex = 10;
            this.picAirplaneLand.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(37, 47);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 29);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(37, 154);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 29);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "To";
            // 
            // lblDepartureLocation
            // 
            this.lblDepartureLocation.AutoSize = true;
            this.lblDepartureLocation.Font = new System.Drawing.Font("Kantumruy Pro", 12F);
            this.lblDepartureLocation.Location = new System.Drawing.Point(93, 108);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(398, 29);
            this.lblDepartureLocation.TabIndex = 13;
            this.lblDepartureLocation.Text = "Ninoy Aquino International Airport (MNL)";
            // 
            // cboArrivalLocation
            // 
            this.cboArrivalLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboArrivalLocation.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArrivalLocation.FormattingEnabled = true;
            this.cboArrivalLocation.Items.AddRange(new object[] {
            "Manila",
            "Singapore",
            "Mexico"});
            this.cboArrivalLocation.Location = new System.Drawing.Point(93, 171);
            this.cboArrivalLocation.Name = "cboArrivalLocation";
            this.cboArrivalLocation.Size = new System.Drawing.Size(183, 37);
            this.cboArrivalLocation.TabIndex = 15;
            // 
            // lblArrivalLocation
            // 
            this.lblArrivalLocation.AutoSize = true;
            this.lblArrivalLocation.Font = new System.Drawing.Font("Kantumruy Pro", 12F);
            this.lblArrivalLocation.Location = new System.Drawing.Point(93, 211);
            this.lblArrivalLocation.Name = "lblArrivalLocation";
            this.lblArrivalLocation.Size = new System.Drawing.Size(398, 29);
            this.lblArrivalLocation.TabIndex = 16;
            this.lblArrivalLocation.Text = "Ninoy Aquino International Airport (MNL)";
            // 
            // picCompanions
            // 
            this.picCompanions.Image = ((System.Drawing.Image)(resources.GetObject("picCompanions.Image")));
            this.picCompanions.Location = new System.Drawing.Point(22, 277);
            this.picCompanions.Margin = new System.Windows.Forms.Padding(0);
            this.picCompanions.Name = "picCompanions";
            this.picCompanions.Size = new System.Drawing.Size(498, 262);
            this.picCompanions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompanions.TabIndex = 1;
            this.picCompanions.TabStop = false;
            // 
            // picClassSeat
            // 
            this.picClassSeat.Image = ((System.Drawing.Image)(resources.GetObject("picClassSeat.Image")));
            this.picClassSeat.Location = new System.Drawing.Point(535, 280);
            this.picClassSeat.Name = "picClassSeat";
            this.picClassSeat.Size = new System.Drawing.Size(315, 120);
            this.picClassSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClassSeat.TabIndex = 2;
            this.picClassSeat.TabStop = false;
            // 
            // picDepartureReturnDate
            // 
            this.picDepartureReturnDate.Image = ((System.Drawing.Image)(resources.GetObject("picDepartureReturnDate.Image")));
            this.picDepartureReturnDate.Location = new System.Drawing.Point(535, 19);
            this.picDepartureReturnDate.Name = "picDepartureReturnDate";
            this.picDepartureReturnDate.Size = new System.Drawing.Size(315, 255);
            this.picDepartureReturnDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartureReturnDate.TabIndex = 3;
            this.picDepartureReturnDate.TabStop = false;
            // 
            // picDepartureArrivalLocation
            // 
            this.picDepartureArrivalLocation.Image = ((System.Drawing.Image)(resources.GetObject("picDepartureArrivalLocation.Image")));
            this.picDepartureArrivalLocation.Location = new System.Drawing.Point(22, 19);
            this.picDepartureArrivalLocation.Name = "picDepartureArrivalLocation";
            this.picDepartureArrivalLocation.Size = new System.Drawing.Size(497, 255);
            this.picDepartureArrivalLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartureArrivalLocation.TabIndex = 0;
            this.picDepartureArrivalLocation.TabStop = false;
            // 
            // lblCompanions
            // 
            this.lblCompanions.AutoSize = true;
            this.lblCompanions.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanions.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanions.Location = new System.Drawing.Point(37, 295);
            this.lblCompanions.Name = "lblCompanions";
            this.lblCompanions.Size = new System.Drawing.Size(117, 29);
            this.lblCompanions.TabIndex = 17;
            this.lblCompanions.Text = "Passengers";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAdult);
            this.flowLayoutPanel1.Controls.Add(this.numAdult);
            this.flowLayoutPanel1.Controls.Add(this.lblChildren);
            this.flowLayoutPanel1.Controls.Add(this.numChildren);
            this.flowLayoutPanel1.Controls.Add(this.lblInfant);
            this.flowLayoutPanel1.Controls.Add(this.numInfant);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 182);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(3, 0);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(64, 29);
            this.lblAdult.TabIndex = 0;
            this.lblAdult.Text = "Adult";
            // 
            // numAdult
            // 
            this.numAdult.Location = new System.Drawing.Point(10, 32);
            this.numAdult.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.numAdult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdult.Name = "numAdult";
            this.numAdult.Size = new System.Drawing.Size(64, 22);
            this.numAdult.TabIndex = 3;
            this.numAdult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(3, 57);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(243, 29);
            this.lblChildren.TabIndex = 1;
            this.lblChildren.Text = "Children (2-11 years old)";
            // 
            // numChildren
            // 
            this.numChildren.Location = new System.Drawing.Point(10, 89);
            this.numChildren.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(64, 22);
            this.numChildren.TabIndex = 4;
            // 
            // lblInfant
            // 
            this.lblInfant.AutoSize = true;
            this.lblInfant.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfant.Location = new System.Drawing.Point(3, 114);
            this.lblInfant.Name = "lblInfant";
            this.lblInfant.Size = new System.Drawing.Size(70, 29);
            this.lblInfant.TabIndex = 2;
            this.lblInfant.Text = "Infant";
            // 
            // numInfant
            // 
            this.numInfant.Location = new System.Drawing.Point(10, 146);
            this.numInfant.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.numInfant.Name = "numInfant";
            this.numInfant.Size = new System.Drawing.Size(64, 22);
            this.numInfant.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(42, 389);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartureDate.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(553, 50);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(156, 29);
            this.lblDepartureDate.TabIndex = 22;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // cboDepartureDate
            // 
            this.cboDepartureDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartureDate.FormattingEnabled = true;
            this.cboDepartureDate.Items.AddRange(new object[] {
            "Sample",
            "Sample",
            "Sample"});
            this.cboDepartureDate.Location = new System.Drawing.Point(614, 95);
            this.cboDepartureDate.Name = "cboDepartureDate";
            this.cboDepartureDate.Size = new System.Drawing.Size(205, 24);
            this.cboDepartureDate.TabIndex = 23;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(557, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(553, 157);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(127, 29);
            this.lblReturnDate.TabIndex = 25;
            this.lblReturnDate.Text = "Return Date";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(558, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(558, 189);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // cboReturnDate
            // 
            this.cboReturnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReturnDate.FormattingEnabled = true;
            this.cboReturnDate.Items.AddRange(new object[] {
            "Sample",
            "Sample",
            "Sample"});
            this.cboReturnDate.Location = new System.Drawing.Point(614, 202);
            this.cboReturnDate.Name = "cboReturnDate";
            this.cboReturnDate.Size = new System.Drawing.Size(205, 24);
            this.cboReturnDate.TabIndex = 29;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(557, 330);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // lblClassSeat
            // 
            this.lblClassSeat.AutoSize = true;
            this.lblClassSeat.BackColor = System.Drawing.Color.Transparent;
            this.lblClassSeat.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassSeat.Location = new System.Drawing.Point(553, 298);
            this.lblClassSeat.Name = "lblClassSeat";
            this.lblClassSeat.Size = new System.Drawing.Size(110, 29);
            this.lblClassSeat.TabIndex = 31;
            this.lblClassSeat.Text = "Class Seat";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sample",
            "Sample",
            "Sample"});
            this.comboBox1.Location = new System.Drawing.Point(613, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFlight.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.BUTTON;
            this.btnSearchFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFlight.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.btnSearchFlight.ForeColor = System.Drawing.Color.White;
            this.btnSearchFlight.Location = new System.Drawing.Point(552, 437);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(298, 93);
            this.btnSearchFlight.TabIndex = 33;
            this.btnSearchFlight.Text = "SEARCH FLIGHT";
            this.btnSearchFlight.UseVisualStyleBackColor = false;
            // 
            // Round_Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblClassSeat);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.cboReturnDate);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cboDepartureDate);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCompanions);
            this.Controls.Add(this.lblArrivalLocation);
            this.Controls.Add(this.cboArrivalLocation);
            this.Controls.Add(this.lblDepartureLocation);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.picAirplaneLand);
            this.Controls.Add(this.picAirplaneLift);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.cboDepartureLocation);
            this.Controls.Add(this.picDepartureReturnDate);
            this.Controls.Add(this.picClassSeat);
            this.Controls.Add(this.picCompanions);
            this.Controls.Add(this.picDepartureArrivalLocation);
            this.Name = "Round_Trip";
            this.Size = new System.Drawing.Size(871, 571);
            this.Load += new System.EventHandler(this.Round_Trip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClassSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureReturnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureArrivalLocation)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDepartureLocation;
        private System.Windows.Forms.PictureBox picLine;
        private System.Windows.Forms.PictureBox picAirplaneLift;
        private System.Windows.Forms.PictureBox picAirplaneLand;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.ComboBox cboArrivalLocation;
        private Label lblArrivalLocation;
        private PictureBox picCompanions;
        private PictureBox picClassSeat;
        private PictureBox picDepartureReturnDate;
        private PictureBox picDepartureArrivalLocation;
        private Label lblCompanions;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblAdult;
        private Label lblChildren;
        private Label lblInfant;
        private NumericUpDown numAdult;
        private NumericUpDown numChildren;
        private NumericUpDown numInfant;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblDepartureDate;
        private ComboBox cboDepartureDate;
        private PictureBox pictureBox4;
        private Label lblReturnDate;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ComboBox cboReturnDate;
        private PictureBox pictureBox7;
        private Label lblClassSeat;
        private ComboBox comboBox1;
        public Button btnSearchFlight;
    }
}
