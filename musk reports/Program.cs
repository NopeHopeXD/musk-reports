using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musk_reports
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            (new musk_reports.Login()).Show();       // Possibly change to Adminform, depends what you chaps think is a better first screen.
            Application.Run();
        }
    }

    //Destiny - sourced from stackoverflow. To set the global reporting peruiod to be used on forms and in queries.

    static class Musk_ReportsGlobalVariables
    {
        private static string _globalVarReportingPeriod = "";

        public static string GlobalVarReportingPeriod
        {
            get { return _globalVarReportingPeriod; }
            set { _globalVarReportingPeriod = value; }
        }
    }
}