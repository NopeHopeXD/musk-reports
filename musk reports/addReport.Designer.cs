
namespace musk_reports
{
    partial class addReportF
    {
        private const int V = 28;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReportF));
            this.lblAddReport = new System.Windows.Forms.Label();
            this.lbltitleReport = new System.Windows.Forms.Label();
            this.overallInformation = new System.Windows.Forms.DataGridView();
            this.site_ins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedBy_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspector_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_inspection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_of_inspection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInpectionForm = new System.Windows.Forms.DataGridView();
            this.inspection_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_intervensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments_ab_interv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed_inspection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_taken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.overallInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInpectionForm)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddReport
            // 
            this.lblAddReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReport.Location = new System.Drawing.Point(44, 15);
            this.lblAddReport.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddReport.Name = "lblAddReport";
            this.lblAddReport.Size = new System.Drawing.Size(110, 25);
            this.lblAddReport.TabIndex = 0;
            this.lblAddReport.Text = "Add Report";
            this.lblAddReport.Click += new System.EventHandler(this.LblAddReport_Click);
            // 
            // lbltitleReport
            // 
            this.lbltitleReport.AutoSize = true;
            this.lbltitleReport.Location = new System.Drawing.Point(3, 62);
            this.lbltitleReport.Name = "lbltitleReport";
            this.lbltitleReport.Size = new System.Drawing.Size(826, 37);
            this.lbltitleReport.TabIndex = 1;
            this.lbltitleReport.Text = "Health, Safety, Quality and Environmental Site Inspection";
            // 
            // overallInformation
            // 
            this.overallInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overallInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.site_ins,
            this.work_area,
            this.supervisor_name,
            this.completedBy_name,
            this.job_description,
            this.inspector_name,
            this.date_of_inspection,
            this.type_of_inspection});
            this.overallInformation.Location = new System.Drawing.Point(3, 127);
            this.overallInformation.Name = "overallInformation";
            this.overallInformation.RowHeadersWidth = 62;
            this.overallInformation.RowTemplate.Height = 28;
            this.overallInformation.Size = new System.Drawing.Size(1233, 244);
            this.overallInformation.TabIndex = 2;
            this.overallInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // site_ins
            // 
            this.site_ins.HeaderText = "Site";
            this.site_ins.MinimumWidth = 8;
            this.site_ins.Name = "site_ins";
            this.site_ins.Width = 150;
            // 
            // work_area
            // 
            this.work_area.HeaderText = "Work Area";
            this.work_area.MinimumWidth = 8;
            this.work_area.Name = "work_area";
            this.work_area.Width = 150;
            // 
            // supervisor_name
            // 
            this.supervisor_name.HeaderText = "Supervisor";
            this.supervisor_name.MinimumWidth = 8;
            this.supervisor_name.Name = "supervisor_name";
            this.supervisor_name.Width = 150;
            // 
            // completedBy_name
            // 
            this.completedBy_name.HeaderText = "Completed By";
            this.completedBy_name.MinimumWidth = 8;
            this.completedBy_name.Name = "completedBy_name";
            this.completedBy_name.Width = 150;
            // 
            // job_description
            // 
            this.job_description.HeaderText = "Job Description";
            this.job_description.MinimumWidth = 8;
            this.job_description.Name = "job_description";
            this.job_description.Width = 150;
            // 
            // inspector_name
            // 
            this.inspector_name.HeaderText = "Inspector";
            this.inspector_name.MinimumWidth = 8;
            this.inspector_name.Name = "inspector_name";
            this.inspector_name.Width = 150;
            // 
            // date_of_inspection
            // 
            this.date_of_inspection.HeaderText = "Date";
            this.date_of_inspection.MinimumWidth = 8;
            this.date_of_inspection.Name = "date_of_inspection";
            this.date_of_inspection.Width = 150;
            // 
            // type_of_inspection
            // 
            this.type_of_inspection.HeaderText = "Type";
            this.type_of_inspection.MinimumWidth = 8;
            this.type_of_inspection.Name = "type_of_inspection";
            this.type_of_inspection.Width = 150;
            // 
            // dgInpectionForm
            // 
            this.dgInpectionForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInpectionForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspection_cat,
            this.number_of_intervensions,
            this.comments_ab_interv,
            this.completed_inspection,
            this.action_taken});
            this.dgInpectionForm.Location = new System.Drawing.Point(3, 3);
            this.dgInpectionForm.Name = "dgInpectionForm";
            this.dgInpectionForm.RowHeadersWidth = 62;
            this.dgInpectionForm.Size = new System.Drawing.Size(813, 241);
            this.dgInpectionForm.TabIndex = 3;
            this.dgInpectionForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inspection_cat
            // 
            this.inspection_cat.HeaderText = "Inspection Category";
            this.inspection_cat.MinimumWidth = 8;
            this.inspection_cat.Name = "inspection_cat";
            this.inspection_cat.Width = 150;
            // 
            // number_of_intervensions
            // 
            this.number_of_intervensions.HeaderText = "Intervensions";
            this.number_of_intervensions.MinimumWidth = 8;
            this.number_of_intervensions.Name = "number_of_intervensions";
            this.number_of_intervensions.Width = 150;
            // 
            // comments_ab_interv
            // 
            this.comments_ab_interv.HeaderText = "Comments";
            this.comments_ab_interv.MinimumWidth = 8;
            this.comments_ab_interv.Name = "comments_ab_interv";
            this.comments_ab_interv.Width = 150;
            // 
            // completed_inspection
            // 
            this.completed_inspection.HeaderText = "Completed";
            this.completed_inspection.MinimumWidth = 8;
            this.completed_inspection.Name = "completed_inspection";
            this.completed_inspection.Width = 150;
            // 
            // action_taken
            // 
            this.action_taken.HeaderText = "Action Taken";
            this.action_taken.MinimumWidth = 8;
            this.action_taken.Name = "action_taken";
            this.action_taken.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.Location = new System.Drawing.Point(823, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(202, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Report Overview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbltitleReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.overallInformation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 627);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.86922F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.13078F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAddReport, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1254, 56);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.70513F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.29487F));
            this.tableLayoutPanel3.Controls.Add(this.dgInpectionForm, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 377);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1248, 247);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // addReportF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "addReportF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overallInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInpectionForm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void NewMethod()
        {
            using (addReportF form1 = this)
            {
                form1.dgInpectionForm.RowTemplate.Height = V;
            }
        }

        #endregion

        private System.Windows.Forms.Label lblAddReport;
        private System.Windows.Forms.Label lbltitleReport;
        private System.Windows.Forms.DataGridView overallInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn site_ins;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedBy_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_inspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_of_inspection;
        private System.Windows.Forms.DataGridView dgInpectionForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspection_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_intervensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments_ab_interv;
        private System.Windows.Forms.DataGridViewTextBoxColumn completed_inspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_taken;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

