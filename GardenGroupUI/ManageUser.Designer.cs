
namespace GardenGroupUI
{
    partial class ManageUser
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
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.ColumnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenArchive = new System.Windows.Forms.Button();
            this.btnTicketOverview = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmailSignedIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "User management";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(67, 255);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(174, 24);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewUser.Location = new System.Drawing.Point(690, 244);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(116, 34);
            this.btnAddNewUser.TabIndex = 2;
            this.btnAddNewUser.Text = "&Add new User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnId,
            this.ColumnEmail,
            this.ColumnFirstname,
            this.columnLastname,
            this.columnTickets});
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(67, 287);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(740, 337);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "ID";
            this.ColumnId.Width = 98;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.Text = "Email";
            this.ColumnEmail.Width = 200;
            // 
            // ColumnFirstname
            // 
            this.ColumnFirstname.Text = "First name";
            this.ColumnFirstname.Width = 100;
            // 
            // columnLastname
            // 
            this.columnLastname.Text = "Last name";
            this.columnLastname.Width = 100;
            // 
            // columnTickets
            // 
            this.columnTickets.Text = "# Tickets";
            this.columnTickets.Width = 75;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.Location = new System.Drawing.Point(689, 640);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search by E-mail";
            // 
            // btnOpenArchive
            // 
            this.btnOpenArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenArchive.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOpenArchive.Location = new System.Drawing.Point(690, 205);
            this.btnOpenArchive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenArchive.Name = "btnOpenArchive";
            this.btnOpenArchive.Size = new System.Drawing.Size(116, 34);
            this.btnOpenArchive.TabIndex = 9;
            this.btnOpenArchive.Text = "&Open Archive";
            this.btnOpenArchive.UseVisualStyleBackColor = false;
            this.btnOpenArchive.Click += new System.EventHandler(this.btnOpenArchive_Click);
            // 
            // btnTicketOverview
            // 
            this.btnTicketOverview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTicketOverview.Location = new System.Drawing.Point(319, 118);
            this.btnTicketOverview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTicketOverview.Name = "btnTicketOverview";
            this.btnTicketOverview.Size = new System.Drawing.Size(228, 36);
            this.btnTicketOverview.TabIndex = 16;
            this.btnTicketOverview.Text = "&Ticket overview";
            this.btnTicketOverview.UseVisualStyleBackColor = false;
            this.btnTicketOverview.Click += new System.EventHandler(this.btnTicketOverview_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDashboard.Location = new System.Drawing.Point(68, 118);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 36);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "&Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnManageUser.Location = new System.Drawing.Point(575, 118);
            this.btnManageUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(228, 36);
            this.btnManageUser.TabIndex = 14;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogout.Location = new System.Drawing.Point(688, 29);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 32);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Signed in as:";
            // 
            // lblEmailSignedIn
            // 
            this.lblEmailSignedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailSignedIn.AutoSize = true;
            this.lblEmailSignedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignedIn.Location = new System.Drawing.Point(686, 8);
            this.lblEmailSignedIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailSignedIn.Name = "lblEmailSignedIn";
            this.lblEmailSignedIn.Size = new System.Drawing.Size(28, 17);
            this.lblEmailSignedIn.TabIndex = 19;
            this.lblEmailSignedIn.Text = ".....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GardenGroupUI.Properties.Resources.nodeskLogo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(859, 817);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmailSignedIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTicketOverview);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.btnOpenArchive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader ColumnId;
        private System.Windows.Forms.ColumnHeader ColumnEmail;
        private System.Windows.Forms.ColumnHeader ColumnFirstname;
        private System.Windows.Forms.ColumnHeader columnLastname;
        private System.Windows.Forms.ColumnHeader columnTickets;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenArchive;
        private System.Windows.Forms.Button btnTicketOverview;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmailSignedIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}