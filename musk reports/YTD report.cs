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

        int screensize;

        public Form1()
        {
            InitializeComponent();
            this.screensize = this.Width;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Graphs_Click(object sender, EventArgs e)
        {
            GraphsPanel.Visible = !GraphsPanel.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllCompGraph_Click(object sender, EventArgs e)
        {
            
        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void GraphsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllReportsPage_Click(object sender, EventArgs e)
        {

        }
    }
}
