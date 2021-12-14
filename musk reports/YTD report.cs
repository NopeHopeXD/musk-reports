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
        // Run "datatableSetup" from GenFunc.cs
        DataTable dt = new GenFunc().datatableSetup();

        // Initialise Form1 and set DataSource to 'dt'
        public Form1()
        {
            InitializeComponent();
            Grid.DataSource = dt;
            //graphSetup();

            // This displays the reporting period on the form set in the adminform
            label3.Text = "Reporting Period : " + Musk_ReportsGlobalVariables.GlobalVarReportingPeriod;
        }



        // Set up the Graph
        private void graphSetup()
        {
            // Make a doughnut graph that displays the total infractions, split on the subsections
            GenFunc gf = new GenFunc();
            Tuple<string[], int[]> XYaxis = gf.getAxis(dt);
            string[] xAxis = XYaxis.Item1;
            int[] yAxis = XYaxis.Item2;

            // Format the Pi Chart
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series[0].Points.DataBindXY(xAxis, yAxis);
            chart1.Legends[0].Enabled = true;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;    // Make it 3D
            chart1.BackColor = Color.Transparent;

        }



        // The Button that switches between the Table and the Graph
        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Switch Boolean
            Graphs.Visible = !Graphs.Visible;

            // Change the Button text, and run graphSetup method
            if (Graphs.Visible) {
                graphSetup();
                DispGraphPage.Text = "Show Table";
            } else {
                DispGraphPage.Text = "Show Graphs";
            }

            // New Object getting the row and column names
            GenFunc gf = new GenFunc();
            label2.Text = gf.columnNames[e.ColumnIndex];

            // Lable the Axis and that
            Tuple<string[], int[]> XYaxis = gf.getSpecificAxis(dt, e.ColumnIndex);
            string[] xAxis = XYaxis.Item1;
            int[] yAxis = XYaxis.Item2;

            // Set up Graph and that
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series[0].Points.DataBindXY(xAxis, yAxis);
            chart1.Legends[0].Enabled = true;
        }

        // Add Report Button
        private void button1_Click(object sender, EventArgs e)
        {
            (new addReportF()).Show();
            this.Close();
        }

        // The Button that switches between the Table and the Graph
        private void DispGraphPage_Click(object sender, EventArgs e)
        {
            // Switch Boolean
            Graphs.Visible = !Graphs.Visible;

            // Change the Button text, and run the graphSetup method
            if (Graphs.Visible)
            {
                graphSetup();
                DispGraphPage.Text = "Show Table";
            }
            else
            {
                DispGraphPage.Text = "Show Graphs";
            }
        }

        // List Report Button 
        private void Button2_Click(object sender, EventArgs e)
        {
            (new musk_reports.ListReports()).Show();
            this.Close();
        }



        // Remove Report Button
        private void Button3_Click(object sender, EventArgs e)
        {
            (new RemoveReport()).Show();
            this.Close();
        }

        // Admin Button
        private void button4_Click(object sender, EventArgs e)
        {
            (new musk_reports.AdminForm()).Show();
            this.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}