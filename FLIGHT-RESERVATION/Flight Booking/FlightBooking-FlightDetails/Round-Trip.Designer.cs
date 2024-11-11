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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.picLine = new System.Windows.Forms.PictureBox();
            this.picAirplaneLift = new System.Windows.Forms.PictureBox();
            this.picAirplaneLand = new System.Windows.Forms.PictureBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.cboArrivalLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picCompanions = new System.Windows.Forms.PictureBox();
            this.picClassSeat = new System.Windows.Forms.PictureBox();
            this.picDepartureReturnDate = new System.Windows.Forms.PictureBox();
            this.picDepartureArrivalLocation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClassSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureReturnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureArrivalLocation)).BeginInit();
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
            this.cboDepartureLocation.Location = new System.Drawing.Point(103, 57);
            this.cboDepartureLocation.Name = "cboDepartureLocation";
            this.cboDepartureLocation.Size = new System.Drawing.Size(183, 37);
            this.cboDepartureLocation.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(705, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(682, 197);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 7;
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
            this.picLine.Click += new System.EventHandler(this.picLine_Click);
            // 
            // picAirplaneLift
            // 
            this.picAirplaneLift.Image = ((System.Drawing.Image)(resources.GetObject("picAirplaneLift.Image")));
            this.picAirplaneLift.Location = new System.Drawing.Point(42, 66);
            this.picAirplaneLift.Name = "picAirplaneLift";
            this.picAirplaneLift.Size = new System.Drawing.Size(50, 50);
            this.picAirplaneLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAirplaneLift.TabIndex = 9;
            this.picAirplaneLift.TabStop = false;
            // 
            // picAirplaneLand
            // 
            this.picAirplaneLand.Image = ((System.Drawing.Image)(resources.GetObject("picAirplaneLand.Image")));
            this.picAirplaneLand.Location = new System.Drawing.Point(42, 186);
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
            this.lblFrom.Location = new System.Drawing.Point(37, 34);
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
            this.lblDepartureLocation.Font = new System.Drawing.Font("Kantumruy Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureLocation.Location = new System.Drawing.Point(98, 97);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(334, 25);
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
            this.cboArrivalLocation.Location = new System.Drawing.Point(103, 171);
            this.cboArrivalLocation.Name = "cboArrivalLocation";
            this.cboArrivalLocation.Size = new System.Drawing.Size(183, 37);
            this.cboArrivalLocation.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kantumruy Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ninoy Aquino International Airport (MNL)";
            // 
            // picCompanions
            // 
            this.picCompanions.Image = ((System.Drawing.Image)(resources.GetObject("picCompanions.Image")));
            this.picCompanions.Location = new System.Drawing.Point(22, 278);
            this.picCompanions.Name = "picCompanions";
            this.picCompanions.Size = new System.Drawing.Size(490, 253);
            this.picCompanions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompanions.TabIndex = 1;
            this.picCompanions.TabStop = false;
            // 
            // picClassSeat
            // 
            this.picClassSeat.Image = ((System.Drawing.Image)(resources.GetObject("picClassSeat.Image")));
            this.picClassSeat.Location = new System.Drawing.Point(558, 278);
            this.picClassSeat.Name = "picClassSeat";
            this.picClassSeat.Size = new System.Drawing.Size(288, 120);
            this.picClassSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClassSeat.TabIndex = 2;
            this.picClassSeat.TabStop = false;
            // 
            // picDepartureReturnDate
            // 
            this.picDepartureReturnDate.Image = ((System.Drawing.Image)(resources.GetObject("picDepartureReturnDate.Image")));
            this.picDepartureReturnDate.Location = new System.Drawing.Point(548, 3);
            this.picDepartureReturnDate.Name = "picDepartureReturnDate";
            this.picDepartureReturnDate.Size = new System.Drawing.Size(304, 273);
            this.picDepartureReturnDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDepartureReturnDate.TabIndex = 3;
            this.picDepartureReturnDate.TabStop = false;
            // 
            // picDepartureArrivalLocation
            // 
            this.picDepartureArrivalLocation.Image = ((System.Drawing.Image)(resources.GetObject("picDepartureArrivalLocation.Image")));
            this.picDepartureArrivalLocation.Location = new System.Drawing.Point(22, 3);
            this.picDepartureArrivalLocation.Name = "picDepartureArrivalLocation";
            this.picDepartureArrivalLocation.Size = new System.Drawing.Size(490, 269);
            this.picDepartureArrivalLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDepartureArrivalLocation.TabIndex = 0;
            this.picDepartureArrivalLocation.TabStop = false;
            // 
            // Round_Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboArrivalLocation);
            this.Controls.Add(this.lblDepartureLocation);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.picAirplaneLand);
            this.Controls.Add(this.picAirplaneLift);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cboDepartureLocation);
            this.Controls.Add(this.picDepartureReturnDate);
            this.Controls.Add(this.picClassSeat);
            this.Controls.Add(this.picCompanions);
            this.Controls.Add(this.picDepartureArrivalLocation);
            this.Name = "Round_Trip";
            this.Size = new System.Drawing.Size(906, 537);
            this.Load += new System.EventHandler(this.Round_Trip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAirplaneLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClassSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureReturnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartureArrivalLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDepartureLocation;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.PictureBox picLine;
        private System.Windows.Forms.PictureBox picAirplaneLift;
        private System.Windows.Forms.PictureBox picAirplaneLand;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.ComboBox cboArrivalLocation;
        private Label label1;
        private PictureBox picCompanions;
        private PictureBox picClassSeat;
        private PictureBox picDepartureReturnDate;
        private PictureBox picDepartureArrivalLocation;
    }
}
