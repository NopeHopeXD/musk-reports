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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtSetup(DataTable dt)
        {
            dt.Columns.Add("Subsections", typeof(string));
            dt.Columns.Add("T&L", typeof(int));
            dt.Columns.Add("AkzoNobel Snowmarket", typeof(int));
            dt.Columns.Add("Weetabix", typeof(int));
            dt.Columns.Add("Koito", typeof(int));
            dt.Columns.Add("Mars Melton", typeof(int));
            dt.Columns.Add("Projects", typeof(int));
            dt.Columns.Add("Design", typeof(int));
            dt.Columns.Add("Misc", typeof(int));
            dt.Columns.Add("Monthly Total", typeof(int));

            
        }

        private void doSQLshit()
        {
            //fuck sql just sayin XD
            
            DatabaseConnection dbConn = new DatabaseConnection();
            string TestText = "";

            DataTable dt = new DataTable();
            dbConn.getData("");
            Grid.DataSource = dt;
            //set up table for data
            dtSetup(dt);

            foreach (var d in dbConn.data)
            {
                TestText += d.Comment + ", ";
                
            }
            TestDisp.Text = TestText;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Test.Text = "Loading DB";

            doSQLshit();

            //Test.Text = "Something Happened";

        }

        private void DispData_Click(object sender, EventArgs e)
        {

        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
