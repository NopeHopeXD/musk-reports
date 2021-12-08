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
            (new AdminForm()).Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using Musk Reports.");
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
