namespace FLIGHT_RESERVATION
{
    partial class View_Bookings
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookings1 = new FLIGHT_RESERVATION.Bookings();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bookings1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(39, 146);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(744, 588);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // bookings1
            // 
            this.bookings1.Location = new System.Drawing.Point(3, 3);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(8, 8);
            this.bookings1.TabIndex = 0;
            // 
            // View_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "View_Bookings";
            this.Size = new System.Drawing.Size(981, 737);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bookings bookings1;
    }
}
