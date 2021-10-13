
namespace GardenGroupUI
{
    partial class TicketOverviewForm
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
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeIncident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypePriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isSolved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTypeOfUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ticket overview";
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.userColumn,
            this.Subject,
            this.TypeIncident,
            this.TypePriority,
            this.columnDate,
            this.Deadline,
            this.isSolved,
            this.Description});
            this.listViewTickets.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.GridLines = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(44, 242);
            this.listViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(1147, 590);
            this.listViewTickets.TabIndex = 8;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            this.listViewTickets.SelectedIndexChanged += new System.EventHandler(this.listViewTickets_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // userColumn
            // 
            this.userColumn.Text = "User";
            this.userColumn.Width = 100;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 100;
            // 
            // TypeIncident
            // 
            this.TypeIncident.Text = "Incident";
            this.TypeIncident.Width = 100;
            // 
            // TypePriority
            // 
            this.TypePriority.Text = "Priority";
            this.TypePriority.Width = 100;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 100;
            // 
            // Deadline
            // 
            this.Deadline.Text = "Deadline";
            this.Deadline.Width = 100;
            // 
            // columnStatus
            // 
            this.isSolved.Text = "IsSolved";
            this.isSolved.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 96;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateIncident.ForeColor = System.Drawing.Color.Black;
            this.btnCreateIncident.Location = new System.Drawing.Point(1044, 176);
            this.btnCreateIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(147, 60);
            this.btnCreateIncident.TabIndex = 5;
            this.btnCreateIncident.Text = "CREATE INCIDENT";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortBy.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Not sorted",
            "ID",
            "Priority",
            "Reported date"});
            this.cmbSortBy.Location = new System.Drawing.Point(44, 191);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(379, 45);
            this.cmbSortBy.TabIndex = 18;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(445, 178);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 60);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Welcome:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(140, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(16, 17);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Role:";
            // 
            // lblTypeOfUser
            // 
            this.lblTypeOfUser.AutoSize = true;
            this.lblTypeOfUser.Location = new System.Drawing.Point(140, 49);
            this.lblTypeOfUser.Name = "lblTypeOfUser";
            this.lblTypeOfUser.Size = new System.Drawing.Size(16, 17);
            this.lblTypeOfUser.TabIndex = 23;
            this.lblTypeOfUser.Text = "_";
            // 
            // TicketOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1308, 898);
            this.Controls.Add(this.lblTypeOfUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketOverviewForm";
            this.Text = "TicketOverviewForm";
            this.Load += new System.EventHandler(this.TicketOverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.ColumnHeader userColumn;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader isSolved;
        private System.Windows.Forms.ColumnHeader TypeIncident;
        private System.Windows.Forms.ColumnHeader TypePriority;
        private System.Windows.Forms.ColumnHeader Deadline;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTypeOfUser;
    }
}