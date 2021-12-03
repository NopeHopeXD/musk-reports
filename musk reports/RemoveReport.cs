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
        int tempReportIDFromForm = -1;
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
            int temp = (int)reportIDBox.Value;

            if (temp > 0)
            {
                bool matchFound = false;
                foreach (var reportInstance in tableData)
                {
                    if (reportInstance.ReportID == temp)
                    {
                        matchFound = true;
                        tempReportIDFromForm = temp;
                        break;
                    }
                }
                if (matchFound)
                {
                    var deleteConfirmation = MessageBox.Show("This action will permanently delete the report of ID "+temp.ToString()+". Continue?", "ALERT", MessageBoxButtons.YesNo);
                    if (deleteConfirmation == DialogResult.Yes)
                    {
                        dbTemp.RemoveReportData(tempReportIDFromForm);
                    }
                    
                }
                else
                {
                    MessageBox.Show("No report with a matching ID has been found.", "ALERT");
                }
            }
            else
            {
                MessageBox.Show("The provided report ID is not within the valid range.", "ALERT");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
