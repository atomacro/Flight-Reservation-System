namespace FLIGHT_RESERVATION.ViewBookings
{
    partial class ViewBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookings));
            this.pnlBookings = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSort = new System.Windows.Forms.Button();
            this.bookings1 = new FLIGHT_RESERVATION.Bookings();
            this.pnlBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBookings
            // 
            this.pnlBookings.AutoScroll = true;
            this.pnlBookings.Controls.Add(this.bookings1);
            this.pnlBookings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlBookings.Location = new System.Drawing.Point(42, 94);
            this.pnlBookings.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(547, 396);
            this.pnlBookings.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(42, 33);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(116, 43);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Latest First";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // bookings1
            // 
            this.bookings1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookings1.BackgroundImage")));
            this.bookings1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookings1.Location = new System.Drawing.Point(2, 2);
            this.bookings1.Margin = new System.Windows.Forms.Padding(2);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(532, 146);
            this.bookings1.TabIndex = 0;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.pnlBookings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBookings";
            this.Size = new System.Drawing.Size(680, 550);
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            this.pnlBookings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBookings;
        private System.Windows.Forms.Button btnSort;
        private Bookings bookings1;
    }
}
