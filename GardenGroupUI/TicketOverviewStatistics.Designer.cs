
namespace GardenGroupUI
{
    partial class TicketOverviewStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowTickets = new System.Windows.Forms.Button();
            this.lblUnsolvedTickets = new System.Windows.Forms.Label();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPastDeadline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartUnresolvedTickets = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIncidentsPastDeadline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidentsPastDeadline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current incidents";
            // 
            // btnShowTickets
            // 
            this.btnShowTickets.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShowTickets.Location = new System.Drawing.Point(860, 98);
            this.btnShowTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowTickets.Name = "btnShowTickets";
            this.btnShowTickets.Size = new System.Drawing.Size(151, 50);
            this.btnShowTickets.TabIndex = 1;
            this.btnShowTickets.Text = "&Show tickets";
            this.btnShowTickets.UseVisualStyleBackColor = false;
            this.btnShowTickets.Click += new System.EventHandler(this.btnShowTickets_Click);
            // 
            // lblUnsolvedTickets
            // 
            this.lblUnsolvedTickets.AutoSize = true;
            this.lblUnsolvedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsolvedTickets.Location = new System.Drawing.Point(124, 245);
            this.lblUnsolvedTickets.Name = "lblUnsolvedTickets";
            this.lblUnsolvedTickets.Size = new System.Drawing.Size(51, 55);
            this.lblUnsolvedTickets.TabIndex = 2;
            this.lblUnsolvedTickets.Text = "_";
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTickets.Location = new System.Drawing.Point(295, 245);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(51, 55);
            this.lblTotalTickets.TabIndex = 3;
            this.lblTotalTickets.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // lblPastDeadline
            // 
            this.lblPastDeadline.AutoSize = true;
            this.lblPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastDeadline.Location = new System.Drawing.Point(715, 245);
            this.lblPastDeadline.Name = "lblPastDeadline";
            this.lblPastDeadline.Size = new System.Drawing.Size(51, 55);
            this.lblPastDeadline.TabIndex = 5;
            this.lblPastDeadline.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unsolved incidents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unsolved / Total tickets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incidents past deadline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Amount of incidents past deadline";
            // 
            // chartUnresolvedTickets
            // 
            this.chartUnresolvedTickets.BorderlineColor = System.Drawing.Color.MediumSeaGreen;
            chartArea5.Name = "ChartArea1";
            this.chartUnresolvedTickets.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartUnresolvedTickets.Legends.Add(legend5);
            this.chartUnresolvedTickets.Location = new System.Drawing.Point(33, 341);
            this.chartUnresolvedTickets.Margin = new System.Windows.Forms.Padding(4);
            this.chartUnresolvedTickets.Name = "chartUnresolvedTickets";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.CustomProperties = "PieStartAngle=270";
            series5.Legend = "Legend1";
            series5.Name = "Unresolved incidents";
            this.chartUnresolvedTickets.Series.Add(series5);
            this.chartUnresolvedTickets.Size = new System.Drawing.Size(441, 342);
            this.chartUnresolvedTickets.TabIndex = 11;
            this.chartUnresolvedTickets.Text = "chart1";
            title9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "title1chart1";
            title9.Text = "Unresolved Incidents";
            title10.Name = "title2chart1";
            title10.Text = "All tickets currently open";
            this.chartUnresolvedTickets.Titles.Add(title9);
            this.chartUnresolvedTickets.Titles.Add(title10);
            // 
            // chartIncidentsPastDeadline
            // 
            this.chartIncidentsPastDeadline.BorderlineColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.chartIncidentsPastDeadline.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartIncidentsPastDeadline.Legends.Add(legend6);
            this.chartIncidentsPastDeadline.Location = new System.Drawing.Point(533, 341);
            this.chartIncidentsPastDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.chartIncidentsPastDeadline.Name = "chartIncidentsPastDeadline";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.CustomProperties = "PieStartAngle=270";
            series6.Legend = "Legend1";
            series6.Name = "Past deadline";
            this.chartIncidentsPastDeadline.Series.Add(series6);
            this.chartIncidentsPastDeadline.Size = new System.Drawing.Size(441, 342);
            this.chartIncidentsPastDeadline.TabIndex = 13;
            this.chartIncidentsPastDeadline.Text = "chart1";
            title11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.Name = "title1chart2";
            title11.Text = "Incidents past deadline";
            title12.Name = "title2chart2";
            title12.Text = "These tickets need your immediate attention";
            this.chartIncidentsPastDeadline.Titles.Add(title11);
            this.chartIncidentsPastDeadline.Titles.Add(title12);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GardenGroupUI.Properties.Resources.nodeskLogo;
            this.pictureBox3.Location = new System.Drawing.Point(910, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // TicketOverviewStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1011, 698);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chartIncidentsPastDeadline);
            this.Controls.Add(this.chartUnresolvedTickets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPastDeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalTickets);
            this.Controls.Add(this.lblUnsolvedTickets);
            this.Controls.Add(this.btnShowTickets);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketOverviewStatistics";
            this.Text = "TicketOverviewStatistics";
            this.Load += new System.EventHandler(this.TicketOverviewStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidentsPastDeadline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTickets;
        private System.Windows.Forms.Label lblUnsolvedTickets;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPastDeadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUnresolvedTickets;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncidentsPastDeadline;
        private System.Windows.Forms.PictureBox pictureBox3;
    }

}