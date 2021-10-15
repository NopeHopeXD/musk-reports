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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.allCompGraph = new System.Windows.Forms.Button();
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
            chartArea19.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chart1.Legends.Add(legend19);
            this.chart1.Location = new System.Drawing.Point(913, 83);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chart1.Series.Add(series19);
            this.chart1.Size = new System.Drawing.Size(210, 107);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea20.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chart2.Legends.Add(legend20);
            this.chart2.Location = new System.Drawing.Point(913, 196);
            this.chart2.Name = "chart2";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chart2.Series.Add(series20);
            this.chart2.Size = new System.Drawing.Size(210, 107);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart5
            // 
            chartArea21.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.chart5.Legends.Add(legend21);
            this.chart5.Location = new System.Drawing.Point(1129, 83);
            this.chart5.Name = "chart5";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chart5.Series.Add(series21);
            this.chart5.Size = new System.Drawing.Size(210, 107);
            this.chart5.TabIndex = 9;
            this.chart5.Text = "chart5";
            // 
            // chart3
            // 
            chartArea22.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.chart3.Legends.Add(legend22);
            this.chart3.Location = new System.Drawing.Point(1129, 196);
            this.chart3.Name = "chart3";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Series1";
            this.chart3.Series.Add(series22);
            this.chart3.Size = new System.Drawing.Size(210, 107);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea23.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea23);
            legend23.Name = "Legend1";
            this.chart4.Legends.Add(legend23);
            this.chart4.Location = new System.Drawing.Point(913, 309);
            this.chart4.Name = "chart4";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Series1";
            this.chart4.Series.Add(series23);
            this.chart4.Size = new System.Drawing.Size(210, 107);
            this.chart4.TabIndex = 11;
            this.chart4.Text = "chart4";
            // 
            // chart6
            // 
            chartArea24.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea24);
            legend24.Name = "Legend1";
            this.chart6.Legends.Add(legend24);
            this.chart6.Location = new System.Drawing.Point(1129, 309);
            this.chart6.Name = "chart6";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Series1";
            this.chart6.Series.Add(series24);
            this.chart6.Size = new System.Drawing.Size(210, 107);
            this.chart6.TabIndex = 12;
            this.chart6.Text = "chart6";
            // 
            // allCompGraph
            // 
            this.allCompGraph.BackColor = System.Drawing.Color.Transparent;
            this.allCompGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.allCompGraph.Cursor = System.Windows.Forms.Cursors.Default;
            this.allCompGraph.ForeColor = System.Drawing.Color.Transparent;
            this.allCompGraph.Location = new System.Drawing.Point(913, 83);
            this.allCompGraph.Name = "allCompGraph";
            this.allCompGraph.Size = new System.Drawing.Size(210, 107);
            this.allCompGraph.TabIndex = 13;
            this.allCompGraph.UseVisualStyleBackColor = false;
            this.allCompGraph.Click += new System.EventHandler(this.AllCompGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 572);
            this.Controls.Add(this.allCompGraph);
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
        private System.Windows.Forms.Button allCompGraph;
    }
}

