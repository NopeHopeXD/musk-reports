using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musk_reports
{
    public partial class RemoveReport : Form
    {

        DataTable reportsDataTable = new DataTable();
        string tempReportIDFromForm = string.Empty;
        //creates a new DatabaseConnection for the purpose of running SQL commands on the Report table
        DatabaseConnection dbTemp = new DatabaseConnection();
        List<Report> tableData;
        public RemoveReport()
        {
            InitializeComponent();
            InitializeTable();
            //links the completed dataTable to the dataGridView on the form
            reportTable.DataSource = reportsDataTable;
        }

        public void InitializeTable()
        {
            //Function runs a SELECT query on the Report table to get the data
            tableData = dbTemp.GetReportData();
            //Columns and rows added manually, loops through the tableData variable to fill the cells
            reportsDataTable.Columns.Add("ReportID", typeof(int));
            reportsDataTable.Columns.Add("Staff Name", typeof(string));
            reportsDataTable.Columns.Add("HeaderID", typeof(int));
            reportsDataTable.Columns.Add("DataSetID", typeof(int));

            foreach (var reportInstance in tableData)
            {
                string tempStaffName = dbTemp.GetStaffNameFromID(reportInstance.StaffID);
                reportsDataTable.Rows.Add(reportInstance.ReportID, tempStaffName, reportInstance.HeaderID, reportInstance.DataSetID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new musk_reports.Form1()).Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempReportIDFromForm = reportIDTextBox.Text;
            if (tempReportIDFromForm != "")
            {
                foreach (var reportInstance in tableData)
                {
                    
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
