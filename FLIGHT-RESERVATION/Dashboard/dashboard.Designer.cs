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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAboutUs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutUs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kantumruy Pro", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(106, 229);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(468, 52);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Airplane Ticketing System";
            // 
            // lblBody
            // 
            this.lblBody.Font = new System.Drawing.Font("Kantumruy Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(73, 331);
            this.lblBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(534, 144);
            this.lblBody.TabIndex = 2;
            this.lblBody.Text = resources.GetString("lblBody.Text");
            this.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 310);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 9);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picAboutUs
            // 
            this.picAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("picAboutUs.Image")));
            this.picAboutUs.Location = new System.Drawing.Point(-7, -10);
            this.picAboutUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAboutUs.Name = "picAboutUs";
            this.picAboutUs.Size = new System.Drawing.Size(697, 186);
            this.picAboutUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAboutUs.TabIndex = 0;
            this.picAboutUs.TabStop = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picAboutUs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(680, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAboutUs;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
