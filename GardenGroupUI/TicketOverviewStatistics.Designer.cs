
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidentsPastDeadline)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current incidents";
            // 
            // btnShowTickets
            // 
            this.btnShowTickets.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShowTickets.Location = new System.Drawing.Point(634, 9);
            this.btnShowTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowTickets.Name = "btnShowTickets";
            this.btnShowTickets.Size = new System.Drawing.Size(113, 41);
            this.btnShowTickets.TabIndex = 1;
            this.btnShowTickets.Text = "SHOW TICKETS";
            this.btnShowTickets.UseVisualStyleBackColor = false;
            this.btnShowTickets.Click += new System.EventHandler(this.btnShowTickets_Click);
            // 
            // lblUnsolvedTickets
            // 
            this.lblUnsolvedTickets.AutoSize = true;
            this.lblUnsolvedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsolvedTickets.Location = new System.Drawing.Point(93, 199);
            this.lblUnsolvedTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnsolvedTickets.Name = "lblUnsolvedTickets";
            this.lblUnsolvedTickets.Size = new System.Drawing.Size(42, 44);
            this.lblUnsolvedTickets.TabIndex = 2;
            this.lblUnsolvedTickets.Text = "_";
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTickets.Location = new System.Drawing.Point(221, 199);
            this.lblTotalTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(42, 44);
            this.lblTotalTickets.TabIndex = 3;
            this.lblTotalTickets.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // lblPastDeadline
            // 
            this.lblPastDeadline.AutoSize = true;
            this.lblPastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastDeadline.Location = new System.Drawing.Point(536, 199);
            this.lblPastDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPastDeadline.Name = "lblPastDeadline";
            this.lblPastDeadline.Size = new System.Drawing.Size(42, 44);
            this.lblPastDeadline.TabIndex = 5;
            this.lblPastDeadline.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unsolved incidents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unsolved / Total tickets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incidents past deadline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Amount of incidents past deadline";
            // 
            // chartUnresolvedTickets
            // 
            this.chartUnresolvedTickets.BorderlineColor = System.Drawing.Color.MediumSeaGreen;
            chartArea1.Name = "ChartArea1";
            this.chartUnresolvedTickets.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUnresolvedTickets.Legends.Add(legend1);
            this.chartUnresolvedTickets.Location = new System.Drawing.Point(25, 277);
            this.chartUnresolvedTickets.Name = "chartUnresolvedTickets";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Unresolved incidents";
            this.chartUnresolvedTickets.Series.Add(series1);
            this.chartUnresolvedTickets.Size = new System.Drawing.Size(331, 278);
            this.chartUnresolvedTickets.TabIndex = 11;
            this.chartUnresolvedTickets.Text = "chart1";
            // 
            // chartIncidentsPastDeadline
            // 
            this.chartIncidentsPastDeadline.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chartIncidentsPastDeadline.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIncidentsPastDeadline.Legends.Add(legend2);
            this.chartIncidentsPastDeadline.Location = new System.Drawing.Point(400, 277);
            this.chartIncidentsPastDeadline.Name = "chartIncidentsPastDeadline";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Past deadline";
            this.chartIncidentsPastDeadline.Series.Add(series2);
            this.chartIncidentsPastDeadline.Size = new System.Drawing.Size(331, 278);
            this.chartIncidentsPastDeadline.TabIndex = 13;
            this.chartIncidentsPastDeadline.Text = "chart1";
            // 
            // TicketOverviewStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(758, 567);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TicketOverviewStatistics";
            this.Text = "TicketOverviewStatistics";
            this.Load += new System.EventHandler(this.TicketOverviewStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidentsPastDeadline)).EndInit();
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
    }
}