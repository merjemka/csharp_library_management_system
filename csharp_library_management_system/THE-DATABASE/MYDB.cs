using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace csharp_library_management_system.THE_DATABASE
{

    //open xampp
    //create the database
    //create table users
    //add the mysql connector
    class MYDB
    {
        // the connection
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_lms_db");

        // create a function to open the connection

        public void openConnection()
        {
        if (connection.State == System.Data.ConnectionState.Closed)
            {
            connection.Open();
            }
        }

         public void closeConnection()
        {
        if (connection.State == System.Data.ConnectionState.Open)
            {
            connection.Close();
            }
        }
// create a function to return the connection
// parameters = the parameters of the query
     public MySqlConnection getConnection()
     {
    return connection;
     }
        //create a function to return a table of data
        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                return table;
        }

        // create a function to set data and execute a query
        public void setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
        }
     }

}
