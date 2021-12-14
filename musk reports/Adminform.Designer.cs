namespace musk_reports
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.SelectFormLabel = new System.Windows.Forms.Label();
            this.ListReportsButton = new System.Windows.Forms.Button();
            this.RemoveReportButton = new System.Windows.Forms.Button();
            this.AddReportButton = new System.Windows.Forms.Button();
            this.YTDReportButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.NumberOfDaysWeeksMonthsYearsComboBox = new System.Windows.Forms.ComboBox();
            this.PeriodComboBox = new System.Windows.Forms.ComboBox();
            this.SetReportingPeriodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFormLabel
            // 
            this.SelectFormLabel.AutoSize = true;
            this.SelectFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormLabel.Location = new System.Drawing.Point(12, 194);
            this.SelectFormLabel.Name = "SelectFormLabel";
            this.SelectFormLabel.Size = new System.Drawing.Size(229, 25);
            this.SelectFormLabel.TabIndex = 0;
            this.SelectFormLabel.Text = "Select the form to display";
            this.SelectFormLabel.Click += new System.EventHandler(this.SelectFormLabel_Click);
            // 
            // ListReportsButton
            // 
            this.ListReportsButton.Location = new System.Drawing.Point(17, 244);
            this.ListReportsButton.Name = "ListReportsButton";
            this.ListReportsButton.Size = new System.Drawing.Size(152, 41);
            this.ListReportsButton.TabIndex = 1;
            this.ListReportsButton.Text = "List Reports";
            this.ListReportsButton.UseVisualStyleBackColor = true;
            this.ListReportsButton.Click += new System.EventHandler(this.ListReportsButton_Click);
            // 
            // RemoveReportButton
            // 
            this.RemoveReportButton.Location = new System.Drawing.Point(325, 244);
            this.RemoveReportButton.Name = "RemoveReportButton";
            this.RemoveReportButton.Size = new System.Drawing.Size(128, 41);
            this.RemoveReportButton.TabIndex = 2;
            this.RemoveReportButton.Text = "Remove Report";
            this.RemoveReportButton.UseVisualStyleBackColor = true;
            this.RemoveReportButton.Click += new System.EventHandler(this.RemoveReportButton_Click);
            // 
            // AddReportButton
            // 
            this.AddReportButton.Location = new System.Drawing.Point(175, 244);
            this.AddReportButton.Name = "AddReportButton";
            this.AddReportButton.Size = new System.Drawing.Size(144, 41);
            this.AddReportButton.TabIndex = 3;
            this.AddReportButton.Text = "Add Report";
            this.AddReportButton.UseVisualStyleBackColor = true;
            this.AddReportButton.Click += new System.EventHandler(this.AddReportButton_Click);
            // 
            // YTDReportButton
            // 
            this.YTDReportButton.Location = new System.Drawing.Point(459, 244);
            this.YTDReportButton.Name = "YTDReportButton";
            this.YTDReportButton.Size = new System.Drawing.Size(141, 41);
            this.YTDReportButton.TabIndex = 4;
            this.YTDReportButton.Text = "YTD Report";
            this.YTDReportButton.UseVisualStyleBackColor = true;
            this.YTDReportButton.Click += new System.EventHandler(this.YTDReportButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(516, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Set the reporting period (before selecting a form to display)";
            // 
            // NumberOfDaysWeeksMonthsYearsComboBox
            // 
            this.NumberOfDaysWeeksMonthsYearsComboBox.Enabled = false;
            this.NumberOfDaysWeeksMonthsYearsComboBox.FormattingEnabled = true;
            this.NumberOfDaysWeeksMonthsYearsComboBox.Location = new System.Drawing.Point(17, 91);
            this.NumberOfDaysWeeksMonthsYearsComboBox.Name = "NumberOfDaysWeeksMonthsYearsComboBox";
            this.NumberOfDaysWeeksMonthsYearsComboBox.Size = new System.Drawing.Size(161, 24);
            this.NumberOfDaysWeeksMonthsYearsComboBox.TabIndex = 6;
            this.NumberOfDaysWeeksMonthsYearsComboBox.Text = "Number of - - - - -";
            this.NumberOfDaysWeeksMonthsYearsComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberOfDaysWeeksMonthsYearsComboBox_SelectedIndexChanged);
            // 
            // PeriodComboBox
            // 
            this.PeriodComboBox.FormattingEnabled = true;
            this.PeriodComboBox.Items.AddRange(new object[] {
            "Day/s",
            "Week/s",
            "Month/s",
            "Year/s"});
            this.PeriodComboBox.Location = new System.Drawing.Point(17, 64);
            this.PeriodComboBox.Name = "PeriodComboBox";
            this.PeriodComboBox.Size = new System.Drawing.Size(161, 24);
            this.PeriodComboBox.TabIndex = 7;
            this.PeriodComboBox.Text = "Period";
            this.PeriodComboBox.SelectedIndexChanged += new System.EventHandler(this.PeriodComboBox_SelectedIndexChanged);
            // 
            // SetReportingPeriodButton
            // 
            this.SetReportingPeriodButton.Location = new System.Drawing.Point(17, 119);
            this.SetReportingPeriodButton.Name = "SetReportingPeriodButton";
            this.SetReportingPeriodButton.Size = new System.Drawing.Size(140, 30);
            this.SetReportingPeriodButton.TabIndex = 9;
            this.SetReportingPeriodButton.Text = "Set Reporting Period";
            this.SetReportingPeriodButton.UseVisualStyleBackColor = true;
            this.SetReportingPeriodButton.Click += new System.EventHandler(this.SetReportingPeriodButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.SetReportingPeriodButton);
            this.Controls.Add(this.PeriodComboBox);
            this.Controls.Add(this.NumberOfDaysWeeksMonthsYearsComboBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.YTDReportButton);
            this.Controls.Add(this.AddReportButton);
            this.Controls.Add(this.RemoveReportButton);
            this.Controls.Add(this.ListReportsButton);
            this.Controls.Add(this.SelectFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musk Reports Admin";
            this.Load += new System.EventHandler(this.Adminform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFormLabel;
        private System.Windows.Forms.Button ListReportsButton;
        private System.Windows.Forms.Button RemoveReportButton;
        private System.Windows.Forms.Button AddReportButton;
        private System.Windows.Forms.Button YTDReportButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox NumberOfDaysWeeksMonthsYearsComboBox;
        private System.Windows.Forms.ComboBox PeriodComboBox;
        private System.Windows.Forms.Button SetReportingPeriodButton;
    }
}