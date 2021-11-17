using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace createR
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
    }
}
