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
        /* Attributes - - - - - - - - - - - - - - - - - - - - */
        
        private static DatabaseConnection _instance;
        private static string connStr;

        //SQL conn obj to stor db connection
        private SqlConnection connToDB;

        // Create List from 
        public List<Data> data = new List<Data>();

        //constructors

        public DatabaseConnection() {
            connStr = Properties.Settings.Default.DBConnStr;
        }



        /* Methods  - - - - - - - - - - - - - - - - - - - - - */
         
        // ! - Get Data from the Database - NOT USED
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

        // ! - Get Data from the Database - NOT USED
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


        // ! - Get Data from the Database
        public void getData(string SQLCommand)
        {
            // Create new SQL Connection
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                // Connect to Database
                cn.Open();

                // Run the SQL Command...
                SqlCommand sqlCommand = new SqlCommand(SQLCommand, cn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                
                // ... and read through each line
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
                    
                    // Add Data (d) to the Data List
                    data.Add(d);
                }

                // Close the Connection
                cn.Close();
            }
            
        }


        // ! - Remove the Report Data
        public void RemoveReportData(int tempReportID)
        {
            // Create new SQL Connection
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // The reportID will be received from the form once the user selects it
                string tempSql = "DELETE FROM report WHERE reportID = @reportID";
                SqlCommand tempSqlCommand = new SqlCommand(tempSql, conn);

                // Adding the parameters manually helps against SQL injections
                tempSqlCommand.Parameters.AddWithValue("@reportID", tempReportID);

                // Connect to Database
                conn.Open();


                try {
                    // Try to Execute the Command
                    int temp = tempSqlCommand.ExecuteNonQuery();
                }
                catch (Exception error) {
                    // Failing shows an error
                    Console.WriteLine(error.Message);
                }
                
                // Close the Connection
                conn.Close();
            }
        }


        // ! - Get Data from the Report
        public List<Report> GetReportData()
        {
            // Create List to put Data
            List<Report> tempReportList = new List<Report>();
            
            // Create new SQL Connection
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Prepare the SQL Command
                string tempSql = "SELECT * FROM report";
                SqlCommand tempSqlCommand = new SqlCommand(tempSql, conn);

                // Connect to Database
                conn.Open();

                // Try to...
                try
                {
                    // ... execute the SQL command...
                    using (SqlDataReader tempReader = tempSqlCommand.ExecuteReader())
                    {
                        // ... and read through each line
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
                    // Else say error.
                    Console.WriteLine(error.Message);
                }

                // Close connection
                conn.Close();
            }

            // Return the List containing the Report's Data
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
    }

class Data
    {
        /* Attributes - - - - - - - - - - - - - - - - - - - - */

        public int DataID;
        public int DataSetID;
        public int InterventionNo;
        public int Interventions;
        public string Comment;
        public string ActionTaken;
        public bool Positive;
        public bool Completed;


        /* Methods  - - - - - - - - - - - - - - - - - - - - - */

        // Set Variables for Data
        public void setVars(string str, string data)
        {

            // Switch-Case for setting up variables
            switch (str)
            {
                case "DataID":
                    this.DataID = Int16.Parse(data);
                    break;
                case "DataSetID":
                    this.DataSetID = Int16.Parse(data);
                    break;
                case "InterventionNo":
                    this.InterventionNo = Int16.Parse(data);
                    break;
                case "Interventions":
                    this.Interventions = Int16.Parse(data);
                    break;
                case "Comment": 
                    this.Comment = data;
                    break;
                case "ActionTaken":
                    this.ActionTaken = data;
                    break;
            }
        }
    }

    class Report
    {
        
        /* Attributes - - - - - - - - - - - - - - - - - - - - */

        public int ReportID;
        public int StaffID;
        public int HeaderID;
        public int DataSetID;
    }

    class Header
    {
        /* Attributes - - - - - - - - - - - - - - - - - - - - */


        public int HeaderID;
        public string Site;
        public string WorkArea;
        public string Supervisor;
        public string JobDesc;
        public DateTime Date;
        public string Type;


        /* Methods  - - - - - - - - - - - - - - - - - - - - - */

        // Set Variables for Header
        public void setVars(string str, string header)
        {

            // Switch-Case for setting up variables
            switch (str)
            {
                case "HeaderID":
                    this.HeaderID = Int16.Parse(header);
                    break;
                case "Comment":
                    this.Site = header;
                    break;
                /*case "ActionTaken":
                    this.ActionTaken = header;
                    break;*/
            }
        }
    }
}



// ! - Notes / Code Dump:
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



 // ! - Saving the data from the 'AddReport.cs' or 'AddNewReport.cs' - idk which one we're using
public void dataTableToDatabase() {
    
    using (SqlConnection conn = new SqlConnection(connStr))
    {
        conn.Open();
        // I tried lots of stuff here, couldn't work it out

        // Adam - it's nothing too problematic, just the conn variable missing the actual connection (connStr), should work fine now
        // As for the actual saving to the database, the general format should be the same as for the data read functions
        //  Instead of the reader, the SqlCommand needs to be prepared, connection opened and then the query executed using something like .ExecuteNonQuery()
        //  You can look at RemoveReportData() as an example, though warning I haven't tested it yet lol
                 
        conn.Close();
    }
}

*/