﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class DBConnection
    {
        //attributes
        //private object of the class itself
        private  static DBConnection _instance;
        //connection string
        private  string dBConnectionString;
        //constructor
        private DBConnection()
        {
            //initialise the connection string
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods
        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public string validateLogin(string email, string password)
        {
            
            SqlCommand command = new SqlCommand();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                command.Connection = connToDB;
                command.CommandText = "SELECT * FROM Account WHERE email = '" + email + "' AND password = '" + password + "'";

                SqlDataReader dr = command.ExecuteReader();
         
                if (dr.Read())
                {
                    return dr["Role"].ToString();
                }
            }

            return " ";

        }
        public DataSet getDataSet(string sqlQuery)
        {
            //create the dataset object
            DataSet dataset = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();

                //send sql query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                adapter.Fill(dataset);
            }
            return dataset;
        }
    }
}
