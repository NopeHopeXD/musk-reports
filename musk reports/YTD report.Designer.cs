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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 572);
            this.Controls.Add(this.AllReportsPage);
            this.Controls.Add(this.AddReportPage);
            this.Controls.Add(this.graphs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Musk Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

