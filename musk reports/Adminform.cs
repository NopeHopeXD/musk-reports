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
	public partial class AdminForm : Form
	{
		/* Attributes - - - - - - - - - - - - - - - - - - - - */

		String chosenPeriod;
		String comboBox1Text;
		String currentYear;
		String[] monthNamesArray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



		/* Methods  - - - - - - - - - - - - - - - - - - - - - */

		public AdminForm()
		{
			InitializeComponent();
		}

		
		private void label3_Click(object sender, EventArgs e)
		{

		}

		// Number of periods selector
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Adminform_Load(object sender, EventArgs e)
		{

		}

		
		
		// Period Selector
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Enables the second drop down, once the first drop down has been interacted with.
			comboBox1.Enabled = true;

			// Set text of the lower drop list.
			chosenPeriod = comboBox2.SelectedItem.ToString();
			comboBox1Text = String.Format("Number of {0}", chosenPeriod);
			comboBox1.Text = comboBox1Text;

			// Switch-Case for the values in the lower drop list.
			switch (chosenPeriod)
            {
				case "Day/s":
					comboBox1.Items.Clear();
					for (int i = 0; i < 31; i++) { comboBox1.Items.Add(i+1); }
					break;

				case "Week/s":
					comboBox1.Items.Clear();
					for (int i = 0; i < 52; i++) { comboBox1.Items.Add(i + 1); }
					break;

				case "Month/s":
					comboBox1.Items.Clear();
					//for (int i = 0; i < 12; i++) { comboBox1.Items.Add(i + 1); }		// Print the month number.
					foreach (var monthName in monthNamesArray) { comboBox1.Items.Add(monthName); }		// Print the month name.
					break;

				case "Year/s":
					comboBox1.Items.Clear();
					for (int i = 2000; i <= 2030; i++) { comboBox1.Items.Add(i); }
					
					// Set the current year to be selected by default.
					currentYear = DateTime.Now.Year.ToString();
					comboBox1.Text = currentYear;
					break;
			}
		}

		//List Reports
        private void ListReportsButton_Click(object sender, EventArgs e)
        {
			//this displays the List Reports form

			(new musk_reports.ListReports()).Show();
		}

		//Add Report 
        private void AddReportButton_Click(object sender, EventArgs e)
        {
			//this displays the add reports form
			(new musk_reports.addReportF()).Show();
		}

		//Remove Report 
        private void RemoveReportButton_Click(object sender, EventArgs e)
        {
			//this displaysthe rmove reports form
			(new musk_reports.RemoveReport()).Show();
		}

		//YTD Reports
        private void YTDReportButton_Click(object sender, EventArgs e)
        {
			//this displays the YTD Reports form
			(new musk_reports.Form1()).Show();
		}

		//Set Reporting Period
        private void SetReportingPeriodButton_Click(object sender, EventArgs e)
        {
			//Set the global variables to be used on forms.
			Musk_ReportsGlobalVariables.GlobalVarReportingPeriod = comboBox1.SelectedItem + " " + "(" + comboBox2.SelectedItem + ")";
		}
    }
}
