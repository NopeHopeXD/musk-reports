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
            //graphSetup();
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

        private List<string> ColumnNames()
        {
            List<string> s = new List<string>();
            s.Add("SubSections");
            s.Add("T&L");
            s.Add("AkzoNobel Snowmarket");
            s.Add("Weetabix");
            s.Add("Koito");
            s.Add("Mars Melton");
            s.Add("Projects");
            s.Add("Design");
            s.Add("Misc");
            s.Add("Monthly Total");

            return s;
        }

        private void graphSetup()
        {
            //make a doughnut graph that displays the total infractions, split on the subsections

            string[] x = new string[RowNames().Count()];
            RowNames().CopyTo(x);

            int[] y = new int[RowNames().Count()];

            int count = 0;
            for( var i = 0; i < RowNames().Count(); i++)
            {
                y[i] = 0;
                for (var j = 1; j < ColumnNames().Count(); j++)
                {
                    string temp = dt.Rows[i][j].ToString();
                    if (temp != "")
                    {
                        y[i] += Int16.Parse(temp);
                    }                  
                }
                if (y[i] == 0)
                {
                    x[i] = "";
                } else
                {
                    count += 1;
                }
            }

            string[] x1 = new string[count];
            int[] y1 = new int[count];

            int temp1 = 0;
            for(var i=0;i<y.Length;i++)
            {
                if (y[i] != 0)
                {
                    y1[temp1] = y[i];
                    x1[temp1] = x[i];
                    temp1++;
                }
            }

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series[0].Points.DataBindXY(x1, y1);
            chart1.Legends[0].Enabled = true;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;


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
            foreach (var i in ColumnNames())
            {
                string Command = "SELECT * FROM Data INNER JOIN Header ON DataSetID=Header.HeaderID AND Header.Site='"+i+"'";
                List<Data> d = fetchData(Command);

                foreach (var j in d)
                {
                    string temp = dt.Rows[j.InterventionNo][i].ToString();
                    if (temp == "")
                    {
                        dt.Rows[j.InterventionNo][i] = j.Interventions;
                    }
                    else
                    {
                        int intTemp = Int16.Parse(temp);
                        intTemp += j.Interventions;
                        dt.Rows[j.InterventionNo][i] = intTemp;
                    }
                }
            }


            //Test.Text = "Something Happened";

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new musk_reports.AddNewReport()).Show(); this.Close();
        }

        private void DispGraphPage_Click(object sender, EventArgs e)
        {
            Graphs.Visible = !Graphs.Visible;
            if (Graphs.Visible) {
                graphSetup();
                DispGraphPage.Text = "Show Table";
            } else
            {
                DispGraphPage.Text = "Show Graphs";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new musk_reports.RemoveReport()).Show(); this.Close();
        }
    }
}