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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GraphsPanel = new System.Windows.Forms.Panel();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.GraphsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Report";
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 24);
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
            this.AllReportsPage.Size = new System.Drawing.Size(117, 23);
            this.AllReportsPage.TabIndex = 4;
            this.AllReportsPage.Text = "Delete Report";
            this.AllReportsPage.UseVisualStyleBackColor = true;
            this.AllReportsPage.Click += new System.EventHandler(this.AllReportsPage_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(44, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(230, 118);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(207, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 501);
            this.panel1.TabIndex = 14;
            // 
            // GraphsPanel
            // 
            this.GraphsPanel.Controls.Add(this.chart4);
            this.GraphsPanel.Controls.Add(this.chart5);
            this.GraphsPanel.Controls.Add(this.chart6);
            this.GraphsPanel.Controls.Add(this.chart3);
            this.GraphsPanel.Controls.Add(this.chart2);
            this.GraphsPanel.Controls.Add(this.chart1);
            this.GraphsPanel.Location = new System.Drawing.Point(197, 46);
            this.GraphsPanel.Name = "GraphsPanel";
            this.GraphsPanel.Size = new System.Drawing.Size(707, 511);
            this.GraphsPanel.TabIndex = 2;
            this.GraphsPanel.Visible = false;
            this.GraphsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphsPanel_Paint);
            // 
            // chart4
            // 
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart4.Legends.Add(legend2);
            this.chart4.Location = new System.Drawing.Point(454, 371);
            this.chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(230, 118);
            this.chart4.TabIndex = 10;
            this.chart4.Text = "chart4";
            // 
            // chart5
            // 
            chartArea3.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart5.Legends.Add(legend3);
            this.chart5.Location = new System.Drawing.Point(454, 199);
            this.chart5.Name = "chart5";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart5.Series.Add(series3);
            this.chart5.Size = new System.Drawing.Size(230, 118);
            this.chart5.TabIndex = 9;
            this.chart5.Text = "chart5";
            // 
            // chart6
            // 
            chartArea4.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart6.Legends.Add(legend4);
            this.chart6.Location = new System.Drawing.Point(454, 37);
            this.chart6.Name = "chart6";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart6.Series.Add(series4);
            this.chart6.Size = new System.Drawing.Size(230, 118);
            this.chart6.TabIndex = 8;
            this.chart6.Text = "chart6";
            // 
            // chart3
            // 
            chartArea5.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart3.Legends.Add(legend5);
            this.chart3.Location = new System.Drawing.Point(44, 371);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(230, 118);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(44, 199);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(230, 118);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 572);
            this.Controls.Add(this.GraphsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AllReportsPage);
            this.Controls.Add(this.AddReportPage);
            this.Controls.Add(this.graphs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Musk Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.GraphsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel GraphsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

