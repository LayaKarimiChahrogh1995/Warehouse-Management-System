﻿namespace EKAWindowApplication.UI.Form
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUserName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResult = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(71, 278);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(115, 34);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(71, 348);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radLabel1.Size = new System.Drawing.Size(109, 34);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(279, 277);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(188, 35);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(279, 348);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(188, 35);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(198, 438);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 47);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = false;
            this.lblResult.Location = new System.Drawing.Point(18, 222);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(462, 47);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(544, 564);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 603);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(552, 603);
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(552, 603);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblUserName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel lblResult;
    }
}
