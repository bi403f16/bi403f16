using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLConnection
{
    public class Connection
    {
        private string connStr;

        public MySqlConnection(string connStr)
        {
            this.connStr = connStr;
        }

        public static void ConnectToDB()
        {
            string connStr = "server=localhost;user=root;database=conntest;port=3306;password=¤¤¤¤¤¤;charset=latin1;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                // Tilpas nedenstående query til hvad den skal bruges til!
                /*
                    string sql = "SELECT name, age FROM tableinfo";     // Denne kan bruges til insert, delete etc.
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                      {
                        Console.WriteLine(rdr[0]+" -- " +rdr[1]);   // [] kan ikke huske om det er array plads?!
                      }
                        rdr.Close(); 
                */

            }
            catch (Exception ex)       //Fjern MySql fra Exception hvis det giver problemer.
            {

                // Fjern nedenstående kommentar i Forms!

                /* switch (ex.Number)
               {
                   case 0:
                       MessageBox.Show("Kan ikke skabe forbindelse til serveren. Kontakt administrator.");
                       break;
                   case 1045:
                       MessageBox.Show("Forkert brugernavn eller adgangskode, prøv venligst igen");
                       break;
               } */

                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");     //Skal nok fjernes!
            Console.ReadLine();             //Skal nok fjernes!
        }

    }
}


/*
¤¤¤¤¤
HUSK AT ADD MySql.Data.dll til refernces
¤¤¤¤¤
*/
