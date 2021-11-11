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
            dt.Columns.Add("SubSections", typeof(string));
            dt.Columns.Add("T&L", typeof(int));
            dt.Columns.Add("AkzoNobel Snowmarket", typeof(int));
            dt.Columns.Add("Weetabix", typeof(int));
            dt.Columns.Add("Koito", typeof(int));
            dt.Columns.Add("Mars Melton", typeof(int));
            dt.Columns.Add("Projects", typeof(int));
            dt.Columns.Add("Design", typeof(int));
            dt.Columns.Add("Misc", typeof(int));
            dt.Columns.Add("Monthly Total", typeof(int));

            /* Hi! It's Lloyd here again
             * So above, I can imagine some aren't supposed to be integers, some are meant to be strings.
             * However I'm not certain which ones should be which so I'll leave it for now.
             * Obviously an error occurs when the user enters data that doesn't match the data type required,
             * so I'll be working on trying to solve this issue and more validation stuff over the next while.
             * I'll do more of this tomorrow. Cheers chaps.
             */


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

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}