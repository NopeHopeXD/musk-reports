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

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dtSetup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<string> RowNames()
        {
            List<string> s = new List<string>();
            s.Add("Work at Heights");
            s.Add("Lifting Opperations");
            s.Add("Certification");
            s.Add("Confined Work Space");
            s.Add("Electrical Work");
            s.Add("Site Set Up");
            s.Add("Paperwork");
            s.Add("Certification - Training, Insurance, Induction");
            s.Add("Hot Work");
            s.Add("Isolation and Lock Offs");
            s.Add("Fire Exists");
            s.Add("Awareness - Fire Exit, Assembly Point");
            s.Add("Waste Management");
            s.Add("Product Contamination");
            s.Add("COSHH & Asbestos");
            s.Add("PPE");
            s.Add("Manual Handling");
            s.Add("Other Contractors");
            s.Add("Power Tools, Cables & Other Equipment");
            s.Add("Volatge Detector Checked");
            s.Add("Tools Used Fit For Purpose");
            s.Add("Company Vehicles");
            s.Add("Fire Precautions");
            s.Add("Workshop Conditions");
            s.Add("Working Standards");
            s.Add("Quality");
            s.Add("Site Rules");
            s.Add("Enviromental");
            s.Add("Portection of Individuals");
            s.Add("Tools, Cables & Other Equipment");
            s.Add("Misc");

            return s;
        }



        public void dtSetup()
        {

            
            Grid.DataSource = dt;

            DataRow row;

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

            List<string> s = RowNames();
            for (int i = 0; i < s.Count(); i ++){
                row = dt.NewRow();
                row["SubSections"] = s[i];
                dt.Rows.Add(row);
            }

            /* Hi! It's Lloyd here again
             * So above, I can imagine some aren't supposed to be integers, some are meant to be strings.
             * However I'm not certain which ones should be which so I'll leave it for now.
             * Obviously an error occurs when the user enters data that doesn't match the data type required,
             * so I'll be working on trying to solve this issue and more validation stuff over the next while.
             * I'll do more of this tomorrow. Cheers chaps.
             */


        }

        private List<Data> fetchData(string Command)
        {
            //fuck sql just sayin XD

            DatabaseConnection dbConn = new DatabaseConnection();            
            dbConn.getData(Command);
            
            //set up table for data

            return dbConn.data;

        }

        private void Test_Click(object sender, EventArgs e)
        {
            Test.Text = "Loading DB";
            string Command = "SELECT * FROM Data INNER JOIN Header ON DataSetID=Header.HeaderID AND Header.Site='Mars Melton'";
            List<Data> d = fetchData(Command);

            foreach (var i in d) {
                string temp = dt.Rows[i.InterventionNo]["Mars Melton"].ToString();
                if (temp == "")
                {
                    dt.Rows[i.InterventionNo]["Mars Melton"] = i.Interventions;
                } else
                {
                    int intTemp = Int16.Parse(temp);
                    intTemp+=i.Interventions;
                    dt.Rows[i.InterventionNo]["Mars Melton"] = intTemp;
                }
            }

            //Test.Text = "Something Happened";

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}