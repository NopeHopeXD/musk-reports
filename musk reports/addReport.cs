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
    public partial class addReportF : Form
    {
        public addReportF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }


        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            // this.Hide();
            // e.Cancel = true;
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* Hi, Lloyd here again, this was my bad attempt at data handling
         * It does not work and completely breaks the program, and I have no clue why
         * but I'm still working on it, have been for a while tbh, but yeah,
         * I'll let you know if this goes anywhere or if I delete it all again,
         * sorry for making the program look messy lol
        private void dataGridView1_InputError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if ((e.Exception) is System.Data.ConstraintException)
                {
                    // Text that gets shown to the user
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Input must be an integer.";
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Input myst be an integer.";

                    // Shows message box error
                    MessageBox.Show(e.Exception.Message, "Error ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // Prevent a ConstraintException
                    e.ThrowException = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: dataGridView1_InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // with help from TutorialsPoint and StackOverflowd
        */


        private void LblAddReport_Click(object sender, EventArgs e)
        {

        }

        private void dgInspectionForm_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new musk_reports.Form1()).Show(); this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*DataTable reportsDataTable = new DataTable();
            //creates a new DatabaseConnection for the purpose of running SQL commands on the Report table
            DatabaseConnection dbTemp = new DatabaseConnection();
            dbTemp.Open();

            string SQL = "", tableName = "report";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SQL = @"INSERT INTO " + tableName + " VALUES (";
                for (int col = 0; col < dataGridView1.ColumnCount; col++)
                {
                    string data = "";
                    if (dataGridView1.Rows[i].Cells[col].Value != null)
                    {
                        data = dataGridView1.Rows[i].Cells[col].Value.ToString();
                    }
                    SQL += "'" + data.Trim() + "'";
                    if (col < dataGridView1.ColumnCount - 1)
                    {
                        SQL += ",";
                    }
                }
                SQL += ")";
                string finalSQL = SQL;
                //INSERT to DB the finalSQL
                using (SqlCommand comm = new SqlCommand(finalSQL, dbTemp))
                {
                    comm.ExecuteNonQuery();
                }
            }

            dbTemp.Close();*/

            //Sorana - yesterday I tried doing a similar thing on Data and Header tables
            //but .ExecuteNonQuery() kept returning error no matter what changes I'd make
            //I will come back at it later today

            /*string InsertDataInDB;
            try
            {
                using (SqlConnection connec = new SqlConnection(ConnecString))
                {
                    using (SqlCommand command_c = new SqlCommand())
                    {
                        command_c.Connection = connec;
                        connec.Open();

                        //first table/header
                        for (int i = 0; i < overallInformation.Rows.Count; i++)
                        {
                            InsertDataInDB = @"INSERT INTO Header VALUES ("
                                + overallInformation.Rows[i].Cells["Site"].Value + ", "
                                + overallInformation.Rows[i].Cells["Work Area"].Value + ", "
                                + overallInformation.Rows[i].Cells["Supervisor"].Value + ", "
                                + overallInformation.Rows[i].Cells["Job Desc"].Value + ", "
                                + overallInformation.Rows[i].Cells["Date"].Value + ", "
                                + overallInformation.Rows[i].Cells["Type"].Value + ");";
                            command_c.CommandText = InsertDataInDB;
                        }

                        //2nd table/Inspection
                        for (int j = 0; j < dgInpectionForm.Rows.Count; j++)
                        {
                            InsertDataInDB = @"INSERT INTO Data VALUES ("
                                + dgInpectionForm.Rows[j].Cells["Interventions"].Value + ", "
                                + dgInpectionForm.Rows[j].Cells["Comment"].Value + ", "
                                + dgInpectionForm.Rows[j].Cells["Completed"].Value + ", "
                                + dgInpectionForm.Rows[j].Cells["Action Taken"].Value + ", "
                        }
                    }
                }
            } */

        }
    }
}
