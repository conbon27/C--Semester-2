using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.data;

namespace DataRestful.App_Code
{
    public class DataPersistence
    {
        // connection
        private MySqlConnection conn;

        public DataPersistence()
        {
            // create connection to DB
            string myConnectionString;
            myConnectionString = "Server = danu6.it.nuigalway.ie; Database = mydb2463; Uid = mydb2463ca; Pwd = mi3tax";
            try
            {
                // opens connection
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySqlException ex)
            {
                // outputs error message
                Console.WriteLine(ex.Message);
            }
        }

        public DataPoints getData(string Station)
        {

        }

    }
}