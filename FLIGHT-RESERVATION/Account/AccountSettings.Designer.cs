namespace FLIGHT_RESERVATION.Account
{
    partial class AccountSettings
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.txtEmail = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLName = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.txtFName = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.btnSignUp = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Kantumruy Pro", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(201, 110);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(473, 66);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Account Information";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnHidePassword.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.visibility_off;
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Location = new System.Drawing.Point(400, 466);
            this.btnHidePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(40, 30);
            this.btnHidePassword.TabIndex = 31;
            this.btnHidePassword.UseVisualStyleBackColor = false;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnShowPassword.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.visibility;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(400, 466);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(40, 30);
            this.btnShowPassword.TabIndex = 30;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(95, 418);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(223, 35);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Current Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtCurrentPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtCurrentPassword.BorderRadius = 10;
            this.txtCurrentPassword.BorderSize = 2;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentPassword.Location = new System.Drawing.Point(101, 458);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCurrentPassword.Multiline = false;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtCurrentPassword.PasswordChar = false;
            this.txtCurrentPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtCurrentPassword.PlaceholderText = "Enter your password";
            this.txtCurrentPassword.Size = new System.Drawing.Size(345, 44);
            this.txtCurrentPassword.TabIndex = 28;
            this.txtCurrentPassword.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(100, 350);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtEmail.PlaceholderText = "Enter your email";
            this.txtEmail.Size = new System.Drawing.Size(715, 44);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.UnderlinedStyle = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(93, 318);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 35);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DimGray;
            this.lblLastName.Location = new System.Drawing.Point(460, 230);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(137, 35);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtLName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtLName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtLName.BorderRadius = 10;
            this.txtLName.BorderSize = 2;
            this.txtLName.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtLName.ForeColor = System.Drawing.Color.Black;
            this.txtLName.Location = new System.Drawing.Point(465, 263);
            this.txtLName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtLName.PasswordChar = false;
            this.txtLName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtLName.PlaceholderText = "Enter last name";
            this.txtLName.Size = new System.Drawing.Size(349, 44);
            this.txtLName.TabIndex = 24;
            this.txtLName.UnderlinedStyle = false;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtFName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtFName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtFName.BorderRadius = 10;
            this.txtFName.BorderSize = 2;
            this.txtFName.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtFName.ForeColor = System.Drawing.Color.Black;
            this.txtFName.Location = new System.Drawing.Point(96, 263);
            this.txtFName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtFName.PasswordChar = false;
            this.txtFName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtFName.PlaceholderText = "Enter first name";
            this.txtFName.Size = new System.Drawing.Size(349, 44);
            this.txtFName.TabIndex = 23;
            this.txtFName.UnderlinedStyle = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.lblFirstName.Location = new System.Drawing.Point(93, 230);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(140, 35);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.visibility_off;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(767, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button2.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.visibility;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(767, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(461, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 35);
            this.label3.TabIndex = 35;
            this.label3.Text = "New Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtNewPassword.BorderRadius = 10;
            this.txtNewPassword.BorderSize = 2;
            this.txtNewPassword.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(468, 458);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtNewPassword.PasswordChar = false;
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtNewPassword.PlaceholderText = "Enter your password";
            this.txtNewPassword.Size = new System.Drawing.Size(345, 44);
            this.txtNewPassword.TabIndex = 34;
            this.txtNewPassword.UnderlinedStyle = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(261, 549);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(384, 57);
            this.btnSignUp.TabIndex = 38;
            this.btnSignUp.Text = "SAVE CHANGES";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountSettings";
            this.Size = new System.Drawing.Size(907, 677);
            this.Load += new System.EventHandler(this.AccountSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Label lblPassword;
        private CustomControls.RoundedTextBox txtCurrentPassword;
        private CustomControls.RoundedTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private CustomControls.RoundedTextBox txtLName;
        private CustomControls.RoundedTextBox txtFName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RoundedTextBox txtNewPassword;
        private CustomControls.RoundedButton btnSignUp;
    }
}
