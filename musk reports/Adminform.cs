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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            (new musk_reports.ListReports()).Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new musk_reports.addReportF()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Musk_ReportsGlobalVariables.GlobalVarReportingPeriod = comboBox1.SelectedItem + " " + comboBox2.SelectedItem;

        }
    }
}
