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
    public partial class ListReports : Form
    {

        DataTable reportsDataTable = new DataTable();
        //creates a new DatabaseConnection for the purpose of running SQL commands on the Report table
        DatabaseConnection dbTemp = new DatabaseConnection();
        public ListReports()
        {
            InitializeComponent();
            InitializeTable();
            //links the completed dataTable to the dataGridView on the form
            reportTable.DataSource = reportsDataTable;
            //this displas the reporting priod set on the admin form
           ReportingPeriodLabel.Text = "Reporting Period : " + Musk_ReportsGlobalVariables.GlobalVarReportingPeriod;
        }

        public void InitializeTable()
        {
            //Function runs a SELECT query on the Report table to get the data
            List<Report> tableData = dbTemp.GetReportData();
            //Columns and rows added manually, loops through the tableData variable to fill the cells
            reportsDataTable.Columns.Add("ReportID", typeof(int));
            reportsDataTable.Columns.Add("StaffID", typeof(int));
            reportsDataTable.Columns.Add("HeaderID", typeof(int));
            reportsDataTable.Columns.Add("DataSetID", typeof(int));
            foreach (var reportInstance in tableData)
            {
                reportsDataTable.Rows.Add(reportInstance.ReportID, reportInstance.StaffID, reportInstance.HeaderID, reportInstance.DataSetID);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                      

        private void AddReportButton_Click(object sender, EventArgs e)
        {
            //this displays the add reports form and closes the list reports
            (new musk_reports.addReportF()).Show();
            this.Close();
        }

        private void DeleteReportButton_Click(object sender, EventArgs e)
        {
            //this displays the remove reports form and closes the list reports
            (new musk_reports.RemoveReport()).Show();
            this.Close();
        }

        private void ReportingPeriodLabel_Click(object sender, EventArgs e)
        {

        }


        private void ListReports_Load(object sender, EventArgs e)
        {

        }
        private void reportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
