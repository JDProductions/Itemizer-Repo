using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenConnection_Click(object sender, EventArgs e)
        {
            MySQLRepository repo = new MySQLRepository();
            repo.OpenConnection();
           
        }

        private void btnGetCompanyNames_Click(object sender, EventArgs e)
        {
            MySQLRepository repo = new MySQLRepository();
            repo.GetCompanyNames();

        }

        private void btnCreateCompany_Click(object sender, EventArgs e)
        {
            MySQLRepository repo = new MySQLRepository();
            repo.CreateCompany();
        }

        public void setCompanyName(string companyName)
        {
            txtCompanyName.Text = companyName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            MySQLRepository repo = new MySQLRepository();
            repo.UpdateCompanies();
        }
    }
}
