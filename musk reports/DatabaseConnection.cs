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

        public void RemoveData(string tempReportID)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                
                string tempSQL = "DELETE FROM report WHERE reportID = @reportID";
                SqlCommand tempSqlCommand = new SqlCommand(tempSQL, conn);
                tempSqlCommand.Parameters.AddWithValue("@reportID", tempReportID);
                
                try {
                    int temp = tempSqlCommand.ExecuteNonQuery();
                }
                catch(Exception error) {
                    Console.WriteLine(error.Message);
                }
                
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
}
