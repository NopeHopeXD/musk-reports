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
		String numberOfText;
		String currentYear;
		String[] monthNamesArray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



		/* Methods  - - - - - - - - - - - - - - - - - - - - - */

		public AdminForm()
		{
			InitializeComponent();
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
			Musk_ReportsGlobalVariables.GlobalVarReportingPeriod = NumberOfDaysWeeksMonthsYearsComboBox.SelectedItem + " " + "(" + PeriodComboBox.SelectedItem + ")";
		}

		//Period Selector

        private void PeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			// Enables the second drop down, once the first drop down has been interacted with.
			NumberOfDaysWeeksMonthsYearsComboBox.Enabled = true;

			// Set text of the lower drop list.
			chosenPeriod = PeriodComboBox.SelectedItem.ToString();
			numberOfText = String.Format("Number of {0}", chosenPeriod);
			NumberOfDaysWeeksMonthsYearsComboBox.Text = numberOfText;

			// Switch-Case for the values in the lower drop list.
			switch (chosenPeriod)
			{
				case "Day/s":
					NumberOfDaysWeeksMonthsYearsComboBox.Items.Clear();
					for (int i = 0; i < 31; i++) { NumberOfDaysWeeksMonthsYearsComboBox.Items.Add(i + 1); }
					break;

				case "Week/s":
					NumberOfDaysWeeksMonthsYearsComboBox.Items.Clear();
					for (int i = 0; i < 52; i++) { NumberOfDaysWeeksMonthsYearsComboBox.Items.Add(i + 1); }
					break;

				case "Month/s":
					NumberOfDaysWeeksMonthsYearsComboBox.Items.Clear();
					//for (int i = 0; i < 12; i++) { comboBox1.Items.Add(i + 1); }		// Print the month number.
					foreach (var monthName in monthNamesArray) { NumberOfDaysWeeksMonthsYearsComboBox.Items.Add(monthName); }      // Print the month name.
					break;

				case "Year/s":
					NumberOfDaysWeeksMonthsYearsComboBox.Items.Clear();
					for (int i = 2000; i <= 2030; i++) { NumberOfDaysWeeksMonthsYearsComboBox.Items.Add(i); }

					// Set the current year to be selected by default.
					currentYear = DateTime.Now.Year.ToString();
					NumberOfDaysWeeksMonthsYearsComboBox.Text = currentYear;
					break;
			}
		}

		// Number of periods selector
		private void NumberOfDaysWeeksMonthsYearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectFormLabel_Click(object sender, EventArgs e)
        {

        }

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Adminform_Load(object sender, EventArgs e)
		{

		}
	}
}
