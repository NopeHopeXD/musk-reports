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

        DataTable dt = new GenFunc().datatableSetup();

        public Form1()
        {
            InitializeComponent();
            Grid.DataSource = dt;
            //graphSetup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void graphSetup()
        {
            //make a doughnut graph that displays the total infractions, split on the subsections

            GenFunc gf = new GenFunc();
            Tuple<string[], int[]> XYaxis = gf.getAxis(dt);
            string[] xAxis = XYaxis.Item1;
            int[] yAxis = XYaxis.Item2;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series[0].Points.DataBindXY(xAxis, yAxis);
            chart1.Legends[0].Enabled = true;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.BackColor = Color.Transparent;

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Graphs.Visible = !Graphs.Visible;
            if (Graphs.Visible)
            {
                graphSetup();
                DispGraphPage.Text = "Show Table";
            }
            else
            {
                DispGraphPage.Text = "Show Graphs";
            }

            GenFunc gf = new GenFunc();
            label2.Text = gf.columnNames[e.ColumnIndex];

            Tuple<string[], int[]> XYaxis = gf.getSpecificAxis(dt, e.ColumnIndex);
            string[] xAxis = XYaxis.Item1;
            int[] yAxis = XYaxis.Item2;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series[0].Points.DataBindXY(xAxis, yAxis);
            chart1.Legends[0].Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new createR.addReportF()).Show(); this.Close();
        }

        private void DispGraphPage_Click(object sender, EventArgs e)
        {
            Graphs.Visible = !Graphs.Visible;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            (new musk_reports.RemoveReport()).Show(); this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}