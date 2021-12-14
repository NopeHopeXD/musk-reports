﻿namespace musk_reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListReportsButton = new System.Windows.Forms.Button();
            this.RemoveReportButton = new System.Windows.Forms.Button();
            this.AddReportButton = new System.Windows.Forms.Button();
            this.YTDReportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SetReportingPeriodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the form to display";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set the reporting period (before selecting a form to display)";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Number of - - - - -";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day/s",
            "Week/s",
            "Month/s",
            "Year/s"});
            this.comboBox2.Location = new System.Drawing.Point(17, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Period";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YTDReportButton);
            this.Controls.Add(this.AddReportButton);
            this.Controls.Add(this.RemoveReportButton);
            this.Controls.Add(this.ListReportsButton);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListReportsButton;
        private System.Windows.Forms.Button RemoveReportButton;
        private System.Windows.Forms.Button AddReportButton;
        private System.Windows.Forms.Button YTDReportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button SetReportingPeriodButton;
    }
}