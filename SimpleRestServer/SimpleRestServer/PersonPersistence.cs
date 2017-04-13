using SimpleRestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using System.Collections;

namespace SimpleRestServer
{
    public class PersonPersistence
    {
        // using MySQL as it works across multiple languages in the easiest fashion
        // could also use NO SQL like MongoDB

        // connection
        private MySql.Data.MySqlClient.MySqlConnection conn;

        // constructor will store the connection
        // whenever instance of class instantiated - auto connects to DB
        public PersonPersistence()
        {
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=developeruser;pwd=developer;database=employeedb";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }
        public long savePerson(Person personToSave)
        {
            string sqlString = "INSERT INTO tblpersonnel (FirstName, LastName, PayRate, StartDate, EndDate) VALUES ('" + personToSave.FirstName + "','" + personToSave.LastName + "','" + personToSave.PayRate + "','" + personToSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + personToSave.EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
            return id;
        }
        public ArrayList getPersons()
        {
            ArrayList personArray = new ArrayList();

            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

            string sqlString = "SELECT * FROM tblpersonnel";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            while (mySQLReader.Read())
            {
                Person p = new Person();
                p.ID = mySQLReader.GetInt32(0);
                p.LastName = mySQLReader.GetString(1);
                p.FirstName = mySQLReader.GetString(2);
                p.PayRate = mySQLReader.GetDouble(3);
                p.StartDate = mySQLReader.GetDateTime(4);
                p.EndDate = mySQLReader.GetDateTime(5);
                personArray.Add(p);
            }
            return personArray;
        }
        public Person getPerson(long ID)
        {
            Person p = new Person();
            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

            string sqlString = "SELECT * FROM tblpersonnel where ID = " + ID.ToString();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            if (mySQLReader.Read())
            {
                p.ID = mySQLReader.GetInt32(0);
                p.LastName = mySQLReader.GetString(1);
                p.FirstName = mySQLReader.GetString(2);
                p.PayRate = mySQLReader.GetDouble(3);
                p.StartDate = mySQLReader.GetDateTime(4);
                p.EndDate = mySQLReader.GetDateTime(5);
                return p;
            }
            else
            {
                return null;
            }

        }
        public bool deletePerson(long ID)
        {
            Person p = new Models.Person();
            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;
            // checks to see if entry exists

            string sqlString = "SELECT * FROM tblpersonnel where ID = " + ID.ToString();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            if (mySQLReader.Read())
            {
                //closes reader
                mySQLReader.Close();

                sqlString = "DELETE FROM tblpersonnel where ID = " + ID.ToString();
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updatePerson(long ID, Person personToSave)
        {
            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;
            // checks to see if entry exists
            string sqlString = "SELECT * FROM tblpersonnel where ID = " + ID.ToString();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            if (mySQLReader.Read())
            {
                //closes reader
                mySQLReader.Close();

                sqlString = "UPDATE tblpersonnel SET FirstName='" + personToSave.FirstName + "', LastName='" + personToSave.LastName + "', PayRate=" + personToSave.PayRate + ", StartDate=" + personToSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "EndDate =" + personToSave.EndDate.ToString("yyyy-MM-dd HH:mm:ss");
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}