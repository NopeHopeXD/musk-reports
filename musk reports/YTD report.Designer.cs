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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Menu = new System.Windows.Forms.Panel();
            this.Test = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Graphs = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DispGraphPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.TitleBox.SuspendLayout();
            this.Graphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Graphs);
            this.panel2.Controls.Add(this.Grid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(246, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 554);
            this.panel2.TabIndex = 3;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1005, 551);
            this.Grid.TabIndex = 2;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.64192F));
            this.tableLayoutPanel1.Controls.Add(this.Menu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TitleBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.29961F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 627);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.DispGraphPage);
            this.Menu.Controls.Add(this.Test);
            this.Menu.Location = new System.Drawing.Point(3, 70);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(237, 554);
            this.Menu.TabIndex = 1;
            // 
            // Test
            // 
            this.Test.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Test.Location = new System.Drawing.Point(63, 3);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(102, 23);
            this.Test.TabIndex = 0;
            this.Test.Text = "Load Report Here";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Controls.Add(this.Label);
            this.TitleBox.Location = new System.Drawing.Point(3, 3);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(237, 61);
            this.TitleBox.TabIndex = 2;
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(237, 61);
            this.Label.TabIndex = 0;
            this.Label.Text = "Musk Reports";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(246, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graphs
            // 
            this.Graphs.Controls.Add(this.label2);
            this.Graphs.Controls.Add(this.chart1);
            this.Graphs.Location = new System.Drawing.Point(0, 0);
            this.Graphs.Name = "Graphs";
            this.Graphs.Size = new System.Drawing.Size(1011, 554);
            this.Graphs.TabIndex = 3;
            this.Graphs.Visible = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(297, 125);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // DispGraphPage
            // 
            this.DispGraphPage.Location = new System.Drawing.Point(63, 51);
            this.DispGraphPage.Name = "DispGraphPage";
            this.DispGraphPage.Size = new System.Drawing.Size(102, 23);
            this.DispGraphPage.TabIndex = 2;
            this.DispGraphPage.Text = "Show Graphs";
            this.DispGraphPage.UseVisualStyleBackColor = true;
            this.DispGraphPage.Click += new System.EventHandler(this.DispGraphPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Musk Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.TitleBox.ResumeLayout(false);
            this.Graphs.ResumeLayout(false);
            this.Graphs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Panel TitleBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Graphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button DispGraphPage;
        private System.Windows.Forms.Label label2;
    }
}

