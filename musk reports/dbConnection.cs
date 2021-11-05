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

        public void getData(string company)
        {
            /*

            List<Data> data = new List<Data>();

            HeaderIDs = FROM Header SELECT HeaderID WHERE 'Work Area# == company
            for j in HeaderIDs
                DataSets = FROM DataSet SELECT DataSetID WHERE HeaderID = j
                for k in DataSets
                    Data d = new Data();
                    d.add...
                    ...
                    data.add(d);
            return data
             
             */
            

            /* Notes about below, I've tried changing it a lot in order to get 
             * the program to run and successfully load the database, however
             * this has not been successful :/
             * So yeah I've reverted it back to how it was before, still not working.
             *  -- Lloyd
             *  
             *  I think the code here is fine but DBConnStr was set to a specific directory under the H: drive, so it couldn't locate the database.
             *  I've changed that so hopefully it should work for everyone? 
             *  -Adam
             *  
             */
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                cn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Data Where DataSetID = 1", cn);
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

    }
}
