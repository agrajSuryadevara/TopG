using System;
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

        public void SaveToDB(string sqlQuery, string Name, string Surname, string Portfolio, string EMail)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(new SqlParameter("Name", Name));
                sqlCommand.Parameters.Add(new SqlParameter("Surname", Surname));
                sqlCommand.Parameters.Add(new SqlParameter("Portfolio", Portfolio));
                sqlCommand.Parameters.Add(new SqlParameter("EMail", EMail));
                //sqlCommand.Parameters.Add(new SqlParameter("Phonenumber", Phonenumber));
               // sqlCommand.Parameters.Add(new SqlParameter("Riskpreference", Riskpreference));

                sqlCommand.ExecuteNonQuery();

            }
        }

        public DataTable searchData(string sqlQuery)
        {
            DataTable dt = new DataTable();

            using(SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();

                SqlCommand com = connToDB.CreateCommand();

                com.CommandType = CommandType.Text;
                com.CommandText = sqlQuery;

                com.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(dt);
                
            }

            return dt;
        }
        public void addIdeaToDB(string sqlQuery, int Idea_ID, string Title, string Abstract, int Publish_date, int Expiry_date, string Author, string Content, int Risk_rating, string Product_type,
               string Instrument, string Currency, string Major_sector, string Minor_sector, string Region, string Country)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(new SqlParameter("Idea_ID", Idea_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Title", Title));
                sqlCommand.Parameters.Add(new SqlParameter("Abstract", Abstract));
                sqlCommand.Parameters.Add(new SqlParameter("Publish_date", Publish_date));
                sqlCommand.Parameters.Add(new SqlParameter("Expiry_date", Expiry_date));
                sqlCommand.Parameters.Add(new SqlParameter("Author", Author));
                sqlCommand.Parameters.Add(new SqlParameter("Content", Content));
                sqlCommand.Parameters.Add(new SqlParameter("Risk_rating", Risk_rating));
                sqlCommand.Parameters.Add(new SqlParameter("Product_type", Product_type));
                sqlCommand.Parameters.Add(new SqlParameter("Instrument", Instrument));
                sqlCommand.Parameters.Add(new SqlParameter("Currency", Currency));
                sqlCommand.Parameters.Add(new SqlParameter("Major_sector", Major_sector));
                sqlCommand.Parameters.Add(new SqlParameter("Minor_sector", Minor_sector));
                sqlCommand.Parameters.Add(new SqlParameter("Region", Region));
                sqlCommand.Parameters.Add(new SqlParameter("Country", Country));

                //sqlCommand.Parameters.Add(new SqlParameter("Phonenumber", Phonenumber));
                // sqlCommand.Parameters.Add(new SqlParameter("Riskpreference", Riskpreference));

                sqlCommand.ExecuteNonQuery();

            }
        }
    }
}




    //string w = client.Tables[0]Columns[0]["order_id"]ToString();