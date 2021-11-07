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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Menu = new System.Windows.Forms.Panel();
            this.TestDisp = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.TitleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Grid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(262, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 558);
            this.panel2.TabIndex = 3;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.Size = new System.Drawing.Size(1049, 542);
            this.Grid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.29961F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1335, 636);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.TestDisp);
            this.Menu.Controls.Add(this.Test);
            this.Menu.Location = new System.Drawing.Point(4, 72);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(248, 558);
            this.Menu.TabIndex = 1;
            // 
            // TestDisp
            // 
            this.TestDisp.AutoSize = true;
            this.TestDisp.Location = new System.Drawing.Point(73, 112);
            this.TestDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestDisp.Name = "TestDisp";
            this.TestDisp.Size = new System.Drawing.Size(44, 17);
            this.TestDisp.TabIndex = 1;
            this.TestDisp.Text = "Temp";
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(41, 23);
            this.Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(136, 28);
            this.Test.TabIndex = 0;
            this.Test.Text = "Load Report Here";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Controls.Add(this.Label);
            this.TitleBox.Location = new System.Drawing.Point(4, 4);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(248, 59);
            this.TitleBox.TabIndex = 2;
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(35, 15);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(169, 29);
            this.Label.TabIndex = 0;
            this.Label.Text = "Musk Reports";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 666);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Musk Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.TitleBox.ResumeLayout(false);
            this.TitleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label TestDisp;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Panel TitleBox;
        private System.Windows.Forms.Label Label;
    }
}

