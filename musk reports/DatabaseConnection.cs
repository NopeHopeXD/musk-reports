using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace musk_reports
{
    class DatabaseConnection


    {
        //
        //attrs
        //
        
        private static DatabaseConnection _instance;
        private static string connStr;

        //SQL conn obj to stor db connection
        private SqlConnection connToDB;

        public List<Data> data = new List<Data>();

        //constructors

        public DatabaseConnection(){
            connStr = Properties.Settings.Default.DBConnStr;
        }



        //Methods
        /*
        public static DatabaseConnection getDBconn() {
            if (_instance == null) {
                _instance = new DatabaseConnection();
            }
            return _instance;
        }
        
        public DataSet GetDataSet(string sqlComand) {
            DataSet dataset = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlComand, connToDB);

                dataAdapter.Fill(dataset);

                connToDB.Close();
            }

            return dataset;
        }
        */
        public DataTable dtGet(string Command)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(Command, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }


        public List<Data> generalGetData(string command, params string[] attrs) {

            List<Data> d = new List<Data>();
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                cn.Open();

                SqlCommand sqlCommand = new SqlCommand(command, cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Data data = new Data();
                    for (int i = 0; i < attrs.Length; i++)
                    {
                        data.setVars(attrs[i], (string)reader[attrs[i]]);
                    }
                    d.Add(data);
                }
                cn.Close();
            }
            return d;

        }

        public void getData(string SQLCommand)
        {
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                cn.Open();

                SqlCommand sqlCommand = new SqlCommand(SQLCommand, cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Data d = new Data();
                    d.DataID = (int)reader["DataID"];
                    d.DataSetID = (int)reader["DataSetID"];
                    d.InterventionNo = (int)reader["InterventionNo"];
                    d.Interventions = (int)reader["Interventions"];
                    d.Comment = (string)reader["Comment"];
                    d.ActionTaken = (string)reader["ActionTaken"];
                    d.Positive = (bool)reader["Positive"];
                    d.Completed = (bool)reader["Completed"];
                    data.Add(d);
                }
                cn.Close();
            }
            
        }

        public void RemoveReportData(int tempReportID)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // The reportID will be received from the form once the user selects it
                string tempSql = "DELETE FROM report WHERE reportID = @reportID";
                SqlCommand tempSqlCommand = new SqlCommand(tempSql, conn);
                // IMPORTANT - Adding the parameters like this helps against SQL injections
                tempSqlCommand.Parameters.AddWithValue("@reportID", tempReportID);

                conn.Open();

                try {
                    int temp = tempSqlCommand.ExecuteNonQuery();
                }
                catch(Exception error) {
                    Console.WriteLine(error.Message);
                }
                
                conn.Close();
            }
        }

        public List<Report> GetReportData()
        {
            List<Report> tempReportList = new List<Report>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string tempSql = "SELECT * FROM report";
                SqlCommand tempSqlCommand = new SqlCommand(tempSql, conn);
                conn.Open();
                try
                {
                    using (SqlDataReader tempReader = tempSqlCommand.ExecuteReader())
                    {
                        while(tempReader.Read())
                        {
                            Report tempReport = new Report();
                            tempReport.ReportID = (int)tempReader["ReportID"];
                            tempReport.StaffID = (int)tempReader["StaffID"];
                            tempReport.HeaderID = (int)tempReader["HeaderID"];
                            tempReport.DataSetID = (int)tempReader["DataSetID"];
                            tempReportList.Add(tempReport);
                        }
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                conn.Close();
            }

            return tempReportList;
        }

        public string GetStaffNameFromID(int staffID)
        {
            string temp = "";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string tempSql = "SELECT Name FROM Staff WHERE StaffID = @StaffID";
                SqlCommand tempSqlCommand = new SqlCommand(tempSql, conn);
                tempSqlCommand.Parameters.AddWithValue("@StaffID", staffID);

                conn.Open();
                try
                {
                    using (SqlDataReader tempReader = tempSqlCommand.ExecuteReader())
                    {
                        while (tempReader.Read())
                        {
                            temp = (string)tempReader["Name"];
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                conn.Close();
            }

            return temp;
        }

        // Saving the data from the 'AddReport.cs' or 'AddNewReport.cs' - idk which one we're using
        public void dataTableToDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // I tried lots of stuff here, couldn't work it out

                /** Adam - it's nothing too problematic, just the conn variable missing the actual connection (connStr), should work fine now
                 *  As for the actual saving to the database, the general format should be the same as for the data read functions
                 *  Instead of the reader, the SqlCommand needs to be prepared, connection opened and then the query executed using something like .ExecuteNonQuery()
                 *  You can look at RemoveReportData() as an example, though warning I haven't tested it yet lol
                 **/
                conn.Close();
            }
        }
    }

    class Data
    {
        //
        //attrs
        //

        public int DataID;
        public int DataSetID;
        public int InterventionNo;
        public int Interventions;
        public string Comment;
        public string ActionTaken;
        public bool Positive;
        public bool Completed;


        public void setVars(string str, string data)
        {
            if (str == "DataID")
            {
                this.DataID = Int16.Parse(data);
            }
            else if (str == "DataSetID")
            {
                this.DataSetID = Int16.Parse(data);
            }
            else if (str == "InterventionNo")
            {
                this.InterventionNo = Int16.Parse(data);
            }
            else if (str == "Interventions")
            {
                this.Interventions = Int16.Parse(data);
            }
            else if (str == "Comment")
            {
                this.Comment = data;
            }
            else if (str == "ActionTaken")
            {
                this.ActionTaken = data;
            }
        }
    }

    class Report
    {
        public int ReportID;
        public int StaffID;
        public int HeaderID;
        public int DataSetID;
    }
}
