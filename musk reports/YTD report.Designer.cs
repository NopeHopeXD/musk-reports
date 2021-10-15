namespace musk_reports
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubSections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphs = new System.Windows.Forms.Button();
            this.AddReportPage = new System.Windows.Forms.Button();
            this.AllReportsPage = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubSections,
            this.Company1,
            this.Company2,
            this.Company3,
            this.Company4,
            this.Company5});
            this.dataGridView1.Location = new System.Drawing.Point(241, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // SubSections
            // 
            this.SubSections.HeaderText = "Sub Sections";
            this.SubSections.Name = "SubSections";
            this.SubSections.ReadOnly = true;
            // 
            // Company1
            // 
            this.Company1.HeaderText = "T&L";
            this.Company1.Name = "Company1";
            // 
            // Company2
            // 
            this.Company2.HeaderText = "AkzoNobel Snowmarket";
            this.Company2.Name = "Company2";
            // 
            // Company3
            // 
            this.Company3.HeaderText = "Weetabix";
            this.Company3.Name = "Company3";
            // 
            // Company4
            // 
            this.Company4.HeaderText = "Koito";
            this.Company4.Name = "Company4";
            // 
            // Company5
            // 
            this.Company5.HeaderText = "Mars Melton";
            this.Company5.Name = "Company5";
            // 
            // graphs
            // 
            this.graphs.Location = new System.Drawing.Point(76, 83);
            this.graphs.Name = "graphs";
            this.graphs.Size = new System.Drawing.Size(49, 30);
            this.graphs.TabIndex = 2;
            this.graphs.Text = "Graphs";
            this.graphs.UseVisualStyleBackColor = true;
            this.graphs.Click += new System.EventHandler(this.Graphs_Click);
            // 
            // AddReportPage
            // 
            this.AddReportPage.Location = new System.Drawing.Point(241, 17);
            this.AddReportPage.Name = "AddReportPage";
            this.AddReportPage.Size = new System.Drawing.Size(75, 23);
            this.AddReportPage.TabIndex = 3;
            this.AddReportPage.Text = "Add Report";
            this.AddReportPage.UseVisualStyleBackColor = true;
            this.AddReportPage.Click += new System.EventHandler(this.Button2_Click);
            // 
            // AllReportsPage
            // 
            this.AllReportsPage.Location = new System.Drawing.Point(332, 17);
            this.AllReportsPage.Name = "AllReportsPage";
            this.AllReportsPage.Size = new System.Drawing.Size(75, 23);
            this.AllReportsPage.TabIndex = 4;
            this.AllReportsPage.Text = "button1";
            this.AllReportsPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(913, 83);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(210, 107);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(913, 196);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(210, 107);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart5
            // 
            chartArea15.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart5.Legends.Add(legend15);
            this.chart5.Location = new System.Drawing.Point(1129, 83);
            this.chart5.Name = "chart5";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart5.Series.Add(series15);
            this.chart5.Size = new System.Drawing.Size(210, 107);
            this.chart5.TabIndex = 9;
            this.chart5.Text = "chart5";
            // 
            // chart3
            // 
            chartArea16.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart3.Legends.Add(legend16);
            this.chart3.Location = new System.Drawing.Point(1129, 196);
            this.chart3.Name = "chart3";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chart3.Series.Add(series16);
            this.chart3.Size = new System.Drawing.Size(210, 107);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea17.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart4.Legends.Add(legend17);
            this.chart4.Location = new System.Drawing.Point(913, 309);
            this.chart4.Name = "chart4";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chart4.Series.Add(series17);
            this.chart4.Size = new System.Drawing.Size(210, 107);
            this.chart4.TabIndex = 11;
            this.chart4.Text = "chart4";
            // 
            // chart6
            // 
            chartArea18.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart6.Legends.Add(legend18);
            this.chart6.Location = new System.Drawing.Point(1129, 309);
            this.chart6.Name = "chart6";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chart6.Series.Add(series18);
            this.chart6.Size = new System.Drawing.Size(210, 107);
            this.chart6.TabIndex = 12;
            this.chart6.Text = "chart6";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(913, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 107);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart6);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.AllReportsPage);
            this.Controls.Add(this.AddReportPage);
            this.Controls.Add(this.graphs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Musk Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company5;
        private System.Windows.Forms.Button graphs;
        private System.Windows.Forms.Button AddReportPage;
        private System.Windows.Forms.Button AllReportsPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.Button button1;
    }
}

