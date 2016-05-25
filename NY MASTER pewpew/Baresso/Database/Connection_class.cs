using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Ny_master.Database;

namespace DB_connection
{
    public class Connection
    {
        #region Insert + read from DB methods TO COPY FOR USE!
        public static void InsertToDB()
        {
            try
            {
                //gør klar til query
                var cmd = Connection.RdyQuery();
                //insert querry
                cmd.CommandText = "INSERT INTO........";
                cmd.Prepare();
                //insert parameters som skal ændres:
                //cmd.Parameters.AddWithValue("@parameter", value);
                //execute query
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public static void ReadFromDB(string parameter)
        {
            try
            {
                //prepare for query
                var cmd = Connection.RdyQuery();
                //insert din query
                cmd.CommandText = "SELECT * FROM * WHERE * LIKE * ";
                cmd.Prepare();
                //insert parameters som skal ændres
                cmd.Parameters.AddWithValue("@Email", parameter);

                //create reader objekt
                MySqlDataReader reader = cmd.ExecuteReader();

                //Do something with the reader


                //close connection
                cmd.Connection.Close();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Connection settings - indeholder generiske forbindelser + query
        //Sætter db standard
        private static string StdDB = "p4_projekt";
        private static MySqlConnection conn = null;

        //generisk metode som gør klar til at lave en query.
        public static MySqlCommand RdyQuery()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = ConnectToDB(StdDB);
                return cmd;
            }
            catch (MySqlException ex)
            {
                //gør noget vildt
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        //Generisk metode som laver en connection
        public static MySqlConnection ConnectToDB(string db)
        {
            //sæt connectorstring som skal indeholde server og PW.
            string connStr = string.Format("server=localhost;user=root;database={0};port=3306;password=pollebo1;charset=latin1;", db);

            //opret forbindelse
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connStr;
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null; //Blev nødt til at tilføje denne for at undgå fejl, ved ikke helt, hvilken effekt det har endnu
        }
        #endregion
    }
}

/*
¤¤¤¤¤
HUSK AT ADD MySql.Data.dll til references
¤¤¤¤¤
*/
