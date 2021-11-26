using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace musk_reports
{
    class GenFunc
    {
        public List<string> rowNames;
        public List<string> columnNames;

        public GenFunc()
        {
            rowNames = RowNames();
            columnNames = ColumnNames();
        }

        //DataTable dt = new DataTable();

        public List<string> RowNames()
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

        public List<string> ColumnNames()
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

        public List<Data> fetchData(string Command)
        {
            //fuck sql just sayin XD

            DatabaseConnection dbConn = new DatabaseConnection();
            dbConn.getData(Command);

            //set up table for data

            return dbConn.data;

        }

        public DataTable datatableSetup()
        {
            DataTable dt = new DataTable();
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

            List<string> s = rowNames;
            for (int i = 0; i < s.Count(); i++)
            {
                row = dt.NewRow();
                row["SubSections"] = s[i];
                dt.Rows.Add(row);
            }

            foreach (var column in columnNames)
            {
                string Command = "SELECT * FROM Data INNER JOIN Header ON DataSetID=Header.HeaderID AND Header.Site='" + column + "'";
                List<Data> d = fetchData(Command);

                foreach (var dataPoint in d)
                {
                    string temp = dt.Rows[dataPoint.InterventionNo][column].ToString();
                    if (temp == "")
                    {
                        dt.Rows[dataPoint.InterventionNo][column] = dataPoint.Interventions;
                    }
                    else
                    {
                        int intTemp = Int16.Parse(temp);
                        intTemp += dataPoint.Interventions;
                        dt.Rows[dataPoint.InterventionNo][column] = intTemp;
                    }
                }
            }

            return dt;
        }

        public Tuple<string[], int[]> getAxis(DataTable dt)
        {
            string[] xAxis_DoughnutGraph = new string[rowNames.Count()];
            rowNames.CopyTo(xAxis_DoughnutGraph);

            int[] yAxis_DoughnutGraph = new int[rowNames.Count()];
            //this loop adds up each of the rows
            int count = 0;

            for (var row = 1; row < rowNames.Count(); row++)
            {
                yAxis_DoughnutGraph[row] = 0;
                for (var j = 1; j < columnNames.Count(); j++)
                {
                    string temp = dt.Rows[row][j].ToString();
                    if (temp != "")
                    {
                        yAxis_DoughnutGraph[row] += Int16.Parse(temp);
                    }
                }
                if (yAxis_DoughnutGraph[row] == 0)
                {
                    xAxis_DoughnutGraph[row] = "";
                }
                else
                {
                    count += 1;
                }
            }

            string[] x1 = new string[count];
            int[] y1 = new int[count];

            int temp1 = 0;
            for (var i = 0; i < yAxis_DoughnutGraph.Length; i++)
            {
                if (yAxis_DoughnutGraph[i] != 0)
                {
                    y1[temp1] = yAxis_DoughnutGraph[i];
                    x1[temp1] = xAxis_DoughnutGraph[i];
                    temp1++;
                }
            }

            return new Tuple<string[], int[]>(x1, y1);
        }

        public Tuple<string[], int[]> getSpecificAxis(DataTable dt, int columnIndex)
        {
            string[] xAxis = new string[rowNames.Count()];
            int[] yAxis = new int[rowNames.Count()];

            rowNames.CopyTo(xAxis);
            int count = 0; // to set length for the "Pretty" list

            for (int row = 0; row < yAxis.Length; row++)
            {
                try
                {
                    yAxis[row] = Int32.Parse(dt.Rows[row][columnIndex].ToString());
                    xAxis[row] = xAxis[row] + " // " + yAxis[row].ToString();
                    count++;
                }
                catch
                {
                    yAxis[row] = 0;
                }
            }

            //this creates the pretty strings
            string[] x = new string[count];
            int[] y = new int[count];

            int temp1 = 0;
            for (var i = 0; i < yAxis.Length; i++)
            {
                if (yAxis[i] != 0)
                {
                    y[temp1] = yAxis[i];
                    x[temp1] = xAxis[i];
                    temp1++;
                }
            }

            return new Tuple<string[], int[]>(x, y);
        }
    }
}
