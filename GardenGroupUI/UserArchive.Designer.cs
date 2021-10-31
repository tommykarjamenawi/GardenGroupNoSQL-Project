
namespace GardenGroupUI
{
    partial class UserArchive
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
            this.lstUsers = new System.Windows.Forms.ListView();
            this.ColumnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnId,
            this.ColumnEmail,
            this.ColumnFirstname,
            this.columnLastname});
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(72, 152);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(629, 334);
            this.lstUsers.TabIndex = 4;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "ID";
            this.ColumnId.Width = 98;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.Text = "Email";
            this.ColumnEmail.Width = 146;
            // 
            // ColumnFirstname
            // 
            this.ColumnFirstname.Text = "First name";
            this.ColumnFirstname.Width = 196;
            // 
            // columnLastname
            // 
            this.columnLastname.Text = "Last name";
            this.columnLastname.Width = 174;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(72, 99);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(126, 33);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "&Users Archive";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(215, 99);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(126, 33);
            this.btnTicket.TabIndex = 6;
            this.btnTicket.Text = "&Tickets Archive";
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(575, 104);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(126, 33);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "&Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Return Manage user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lstUsers);
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader ColumnId;
        private System.Windows.Forms.ColumnHeader ColumnEmail;
        private System.Windows.Forms.ColumnHeader ColumnFirstname;
        private System.Windows.Forms.ColumnHeader columnLastname;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button button1;
    }
}