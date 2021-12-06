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
		/* Attributes - - - - - - - - - - - - - - - - - - - - */

		String chosenPeriod;
		String comboBox1Text;
		String currentYear;
		String[] monthNamesArray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



		/* Methods  - - - - - - - - - - - - - - - - - - - - - */
		
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
			(new musk_reports.Form1()).Show();
			this.Close();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		// Number of periods selector
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		   
		}

		// Set Reporting Button
		private void button5_Click(object sender, EventArgs e)
		{
			Musk_ReportsGlobalVariables.GlobalVarReportingPeriod = comboBox1.SelectedItem + " " + comboBox2.SelectedItem;
		}

		private void Adminform_Load(object sender, EventArgs e)
		{

		}

		// Remove Report Button
		private void button2_Click(object sender, EventArgs e)
		{
			(new musk_reports.RemoveReport()).Show();
			this.Close();
		}

		// Period Selector
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Enables the second drop down, once the first drop down has been interacted with.
			comboBox1.Enabled = true;

			// Set text of the lower drop list.
			chosenPeriod = comboBox2.SelectedItem.ToString();
			comboBox1Text = String.Format("Number of {0}s", chosenPeriod);
			comboBox1.Text = comboBox1Text;

			// Switch-Case for the values in the lower drop list.
			switch (chosenPeriod)
            {
				case "Day":
					comboBox1.Items.Clear();
					for (int i = 0; i < 31; i++) { comboBox1.Items.Add(i+1); }
					break;

				case "Week":
					comboBox1.Items.Clear();
					for (int i = 0; i < 52; i++) { comboBox1.Items.Add(i + 1); }
					break;

				case "Month":
					comboBox1.Items.Clear();
					//for (int i = 0; i < 12; i++) { comboBox1.Items.Add(i + 1); }		// Print the month number.
					foreach (var monthName in monthNamesArray) { comboBox1.Items.Add(monthName); }		// Print the month name.
					break;

				case "Year":
					comboBox1.Items.Clear();
					for (int i = 2000; i <= 2030; i++) { comboBox1.Items.Add(i); }
					
					// Set the current year to be selected by default.
					currentYear = DateTime.Now.Year.ToString();
					comboBox1.Text = currentYear;
					break;
			}
		}
	}
}
