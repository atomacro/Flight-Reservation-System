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
            this.pnlBookings = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlBookings
            // 
            this.pnlBookings.AutoScroll = true;
            this.pnlBookings.Location = new System.Drawing.Point(63, 141);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(756, 538);
            this.pnlBookings.TabIndex = 0;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBookings);
            this.Name = "ViewBookings";
            this.Size = new System.Drawing.Size(986, 738);
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBookings;
    }
}
