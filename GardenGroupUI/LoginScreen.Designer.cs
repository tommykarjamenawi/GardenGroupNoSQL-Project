
namespace GardenGroupUI
{
    partial class LoginScreen
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chbRememberMe = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(199, 179);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(430, 62);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(118, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(511, 62);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(199, 97);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(430, 61);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // chbRememberMe
            // 
            this.chbRememberMe.AutoSize = true;
            this.chbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRememberMe.Location = new System.Drawing.Point(199, 247);
            this.chbRememberMe.Name = "chbRememberMe";
            this.chbRememberMe.Size = new System.Drawing.Size(195, 33);
            this.chbRememberMe.TabIndex = 8;
            this.chbRememberMe.Text = "remember me";
            this.chbRememberMe.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(100, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(16, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GardenGroupUI.Properties.Resources.nodeskLogo;
            this.pictureBox3.Location = new System.Drawing.Point(629, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GardenGroupUI.Properties.Resources.green_circle_orange_house_key_11;
            this.pictureBox2.Location = new System.Drawing.Point(118, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GardenGroupUI.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(118, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(753, 441);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.chbRememberMe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.Text = "GardenGroup Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chbRememberMe;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}