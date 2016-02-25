using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TestMySQL.Models.Database_Models;

namespace TestMySQL
{
    class MySQLRepository
    {

        private MySqlConnection connection;

        public void GetCompanyNames()
        {
            OpenConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT company_name FROM companies";
            
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["company_name"].ToString());
            }
            connection.Close();
            
        }

        public void CreateCompany()
        {
            OpenConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText =
                "INSERT INTO companies (company_name, address, phone) VALUES('test','4444 who knows', 555-555-5555)";
            // "insert into test_db.users (fname,lname,age) values('"+textFname.Text+"','"+textLname.Text+"',"+textAge.Text+")"; This will come in handy when we need user input

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["company_name"].ToString());
            }
            connection.Close();
        }

        public MySqlConnection OpenConnection()
        {
          
            //string myConnection;

            string myConnection = "connection string";

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = myConnection;
                connection.Open();
                MessageBox.Show("Working!");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return new MySqlConnection(myConnection);
        }

        public void UpdateCompanies()
        {
            OpenConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText =
                           "UPDATE companies SET address='the boss house', phone='222-222-2222' WHERE company_name='test'";

            // "insert into test_db.users (fname,lname,age) values('"+textFname.Text+"','"+textLname.Text+"',"+textAge.Text+")"; This will come in handy when we need user input

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["company_name"].ToString());
            }
            connection.Close();
        }
    }
 }

