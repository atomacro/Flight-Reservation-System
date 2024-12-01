namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_Payment
{
    partial class PaymentDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.TableLayoutPanel();
            this.btnContinue = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblFlightPrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pnlDetails);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 287);
            this.panel1.TabIndex = 2;
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlDetails.ColumnCount = 2;
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.RowCount = 6;
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlDetails.Size = new System.Drawing.Size(626, 7);
            this.pnlDetails.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.btnContinue.BorderRadius = 20;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(437, 396);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(200, 42);
            this.btnContinue.TabIndex = 16;
            this.btnContinue.Text = "Close";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.lblFlight.Location = new System.Drawing.Point(12, 9);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(125, 31);
            this.lblFlight.TabIndex = 17;
            this.lblFlight.Text = "MNL to SIN";
            // 
            // lblFlightPrice
            // 
            this.lblFlightPrice.AutoSize = true;
            this.lblFlightPrice.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightPrice.Location = new System.Drawing.Point(508, 9);
            this.lblFlightPrice.Name = "lblFlightPrice";
            this.lblFlightPrice.Size = new System.Drawing.Size(130, 31);
            this.lblFlightPrice.TabIndex = 18;
            this.lblFlightPrice.Text = "999.99 Php";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(392, 345);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(246, 31);
            this.lblSubTotal.TabIndex = 19;
            this.lblSubTotal.Text = "Total:          999.99 Php";
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 449);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblFlightPrice);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentDetails";
            this.Load += new System.EventHandler(this.PaymentDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RoundedButton btnContinue;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label lblFlightPrice;
        private System.Windows.Forms.TableLayoutPanel pnlDetails;
        private System.Windows.Forms.Label lblSubTotal;
    }
}