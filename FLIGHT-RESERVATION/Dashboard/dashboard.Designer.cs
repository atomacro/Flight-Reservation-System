namespace FLIGHT_RESERVATION
{
    partial class dashboard
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
            this.btnSortAll = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.btnSortLocal = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.btnSortInternational = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.SuspendLayout();
            // 
            // pnlBookings
            // 
            this.pnlBookings.AutoScroll = true;
            this.pnlBookings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlBookings.Location = new System.Drawing.Point(40, 116);
            this.pnlBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(827, 487);
            this.pnlBookings.TabIndex = 1;
            // 
            // btnSortAll
            // 
            this.btnSortAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(58)))), ((int)(((byte)(238)))));
            this.btnSortAll.BorderRadius = 15;
            this.btnSortAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortAll.FlatAppearance.BorderSize = 0;
            this.btnSortAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAll.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnSortAll.ForeColor = System.Drawing.Color.White;
            this.btnSortAll.Location = new System.Drawing.Point(53, 40);
            this.btnSortAll.Name = "btnSortAll";
            this.btnSortAll.Size = new System.Drawing.Size(91, 54);
            this.btnSortAll.TabIndex = 2;
            this.btnSortAll.Text = "All";
            this.btnSortAll.UseVisualStyleBackColor = false;
            // 
            // btnSortLocal
            // 
            this.btnSortLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.btnSortLocal.BorderRadius = 15;
            this.btnSortLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortLocal.FlatAppearance.BorderSize = 0;
            this.btnSortLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortLocal.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnSortLocal.ForeColor = System.Drawing.Color.Black;
            this.btnSortLocal.Location = new System.Drawing.Point(158, 40);
            this.btnSortLocal.Name = "btnSortLocal";
            this.btnSortLocal.Size = new System.Drawing.Size(111, 54);
            this.btnSortLocal.TabIndex = 3;
            this.btnSortLocal.Text = "Local";
            this.btnSortLocal.UseVisualStyleBackColor = false;
            // 
            // btnSortInternational
            // 
            this.btnSortInternational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.btnSortInternational.BorderRadius = 15;
            this.btnSortInternational.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortInternational.FlatAppearance.BorderSize = 0;
            this.btnSortInternational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortInternational.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnSortInternational.ForeColor = System.Drawing.Color.Black;
            this.btnSortInternational.Location = new System.Drawing.Point(285, 40);
            this.btnSortInternational.Name = "btnSortInternational";
            this.btnSortInternational.Size = new System.Drawing.Size(184, 54);
            this.btnSortInternational.TabIndex = 4;
            this.btnSortInternational.Text = "International";
            this.btnSortInternational.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSortInternational);
            this.Controls.Add(this.btnSortLocal);
            this.Controls.Add(this.btnSortAll);
            this.Controls.Add(this.pnlBookings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(907, 677);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBookings;
        private CustomControls.RoundedButton btnSortAll;
        private CustomControls.RoundedButton btnSortLocal;
        private CustomControls.RoundedButton btnSortInternational;
    }
}
