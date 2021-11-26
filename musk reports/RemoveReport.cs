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

        DataTable reportsTable = new DataTable();
        DatabaseConnection dbTemp = new DatabaseConnection();
        public RemoveReport()
        {
            InitializeComponent();
            InitializeTable();
            reportTable.DataSource = reportsTable;
        }

        public void InitializeTable()
        {
            List<Data> tempData = dbTemp.generalGetData("SELECT * FROM Report");
            foreach (var i in tempData)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new musk_reports.Form1()).Show(); this.Close();
        }
    }
}
