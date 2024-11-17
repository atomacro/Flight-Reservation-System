namespace FLIGHT_RESERVATION
{
    partial class ForgotPassword
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
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnChangePassword = new FLIGHT_RESERVATION.CustomControls.RoundedButton();
            this.txtEmail = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPageName = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtPassword = new FLIGHT_RESERVATION.CustomControls.RoundedTextBox();
            this.SuspendLayout();
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnHidePassword.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.visibility_off;
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Location = new System.Drawing.Point(650, 375);
            this.btnHidePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(40, 30);
            this.btnHidePassword.TabIndex = 17;
            this.btnHidePassword.UseVisualStyleBackColor = false;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Kantumruy Pro Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.lblLogin.Location = new System.Drawing.Point(208, 439);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(135, 25);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Back to Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.btnChangePassword.BorderRadius = 20;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(206, 507);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(495, 57);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(206, 246);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtEmail.PlaceholderText = "Enter your email";
            this.txtEmail.Size = new System.Drawing.Size(495, 48);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.UnderlinedStyle = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(206, 321);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(144, 41);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(206, 201);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 41);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Email";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPageName
            // 
            this.lblPageName.AutoSize = true;
            this.lblPageName.Font = new System.Drawing.Font("Kantumruy Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.Location = new System.Drawing.Point(243, 113);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(421, 60);
            this.lblPageName.TabIndex = 20;
            this.lblPageName.Text = "FORGOT PASSWORD";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnShowPassword.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.visibility;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(650, 375);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(40, 30);
            this.btnShowPassword.TabIndex = 21;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Kantumruy Pro SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(206, 366);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.txtPassword.PlaceholderText = "Enter your new password";
            this.txtPassword.Size = new System.Drawing.Size(495, 48);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UnderlinedStyle = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPageName);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(907, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Label lblLogin;
        private CustomControls.RoundedButton btnChangePassword;
        private CustomControls.RoundedTextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Button btnShowPassword;
        private CustomControls.RoundedTextBox txtPassword;
    }
}
