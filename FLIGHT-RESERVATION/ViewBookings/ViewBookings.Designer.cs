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
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBookings
            // 
            this.pnlBookings.AutoScroll = true;
            this.pnlBookings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlBookings.Location = new System.Drawing.Point(110, 143);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(773, 538);
            this.pnlBookings.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(110, 56);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(155, 53);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Latest First";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.pnlBookings);
            this.Name = "ViewBookings";
            this.Size = new System.Drawing.Size(986, 738);
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBookings;
        private System.Windows.Forms.Button btnSort;
    }
}
