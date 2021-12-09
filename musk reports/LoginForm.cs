using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace musk_reports
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {          

            //Check the username and password entered against entries in the Login table.
           
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Muskdata.mdf" +
            "\";Integrated Security=True;Connect Timeout=30");
            // Prepare the SQL Adapter
            SqlDataAdapter sqa = new SqlDataAdapter("Select Count(*) from Login where UserName ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable(); 
            sqa.Fill(dt);
           if (dt.Rows[0][0].ToString() == "1")
            {
                //Username and Password match the login table so proceed to load the adminform.
                (new AdminForm()).Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your username and password as that combination does not exist");
            }
            

           

           


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using Musk Reports.");
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginId_Click(object sender, EventArgs e)
        {

        }
    }
}
