
namespace GardenGroupUI
{
    partial class AddTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cmbTypeOfIncident = new System.Windows.Forms.ComboBox();
            this.cmbTypeOfPriority = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.txtDateReported = new System.Windows.Forms.TextBox();
            this.btnTicketOverview = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmailSignedIn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Create new ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reported by signinUser:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Subject of incident:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Type of incident:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Deadline:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Type of priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date/time reported:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(277, 502);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(213, 72);
            this.txtDescription.TabIndex = 27;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(277, 293);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(213, 22);
            this.txtSubject.TabIndex = 28;
            // 
            // cmbTypeOfIncident
            // 
            this.cmbTypeOfIncident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfIncident.FormattingEnabled = true;
            this.cmbTypeOfIncident.Location = new System.Drawing.Point(277, 333);
            this.cmbTypeOfIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTypeOfIncident.Name = "cmbTypeOfIncident";
            this.cmbTypeOfIncident.Size = new System.Drawing.Size(213, 24);
            this.cmbTypeOfIncident.TabIndex = 29;
            // 
            // cmbTypeOfPriority
            // 
            this.cmbTypeOfPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfPriority.FormattingEnabled = true;
            this.cmbTypeOfPriority.Location = new System.Drawing.Point(277, 419);
            this.cmbTypeOfPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTypeOfPriority.Name = "cmbTypeOfPriority";
            this.cmbTypeOfPriority.Size = new System.Drawing.Size(213, 24);
            this.cmbTypeOfPriority.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCancel.Location = new System.Drawing.Point(277, 580);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 34);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(387, 580);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 34);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "&Add ticket";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(277, 461);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(213, 22);
            this.dtpDeadline.TabIndex = 35;
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(277, 376);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(213, 24);
            this.cmbUser.TabIndex = 36;
            // 
            // txtDateReported
            // 
            this.txtDateReported.Location = new System.Drawing.Point(277, 255);
            this.txtDateReported.Name = "txtDateReported";
            this.txtDateReported.ReadOnly = true;
            this.txtDateReported.Size = new System.Drawing.Size(213, 22);
            this.txtDateReported.TabIndex = 37;
            // 
            // btnTicketOverview
            // 
            this.btnTicketOverview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTicketOverview.Location = new System.Drawing.Point(335, 153);
            this.btnTicketOverview.Name = "btnTicketOverview";
            this.btnTicketOverview.Size = new System.Drawing.Size(200, 44);
            this.btnTicketOverview.TabIndex = 64;
            this.btnTicketOverview.Text = "&Ticket overview";
            this.btnTicketOverview.UseVisualStyleBackColor = false;
            this.btnTicketOverview.Click += new System.EventHandler(this.btnTicketOverview_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDashboard.Location = new System.Drawing.Point(109, 153);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 44);
            this.btnDashboard.TabIndex = 63;
            this.btnDashboard.Text = "&Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnManageUser.Location = new System.Drawing.Point(563, 153);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(200, 44);
            this.btnManageUser.TabIndex = 62;
            this.btnManageUser.Text = "Manage signinUser";
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GardenGroupUI.Properties.Resources.nodeskLogo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmailSignedIn
            // 
            this.lblEmailSignedIn.AutoSize = true;
            this.lblEmailSignedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignedIn.Location = new System.Drawing.Point(541, 15);
            this.lblEmailSignedIn.Name = "lblEmailSignedIn";
            this.lblEmailSignedIn.Size = new System.Drawing.Size(29, 20);
            this.lblEmailSignedIn.TabIndex = 74;
            this.lblEmailSignedIn.Text = ".....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(421, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 73;
            this.label9.Text = "Signed in as";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogout.Location = new System.Drawing.Point(578, 41);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 31);
            this.btnLogout.TabIndex = 72;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(796, 627);
            this.Controls.Add(this.lblEmailSignedIn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTicketOverview);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.txtDateReported);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTypeOfPriority);
            this.Controls.Add(this.cmbTypeOfIncident);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.Load += new System.EventHandler(this.AddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cmbTypeOfIncident;
        private System.Windows.Forms.ComboBox cmbTypeOfPriority;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtDateReported;
        private System.Windows.Forms.Button btnTicketOverview;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmailSignedIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLogout;
    }
}