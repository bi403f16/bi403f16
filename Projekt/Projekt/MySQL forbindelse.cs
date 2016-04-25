using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        public static void DatabaseConnection()
        {
            MySqlConnection conn = null;
            string myConnectionString;
            myConnectionString =
                  "server=127.0.0.1;uid=root;pwd=root;database=P4_projekt;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Clone();
            }
        }
        public static MySqlConnection GetConnection(string host,
                                                    string user,
                                                    string pwd,
                                                    string db)
        {
            string conStr = String.Format("server={0};uid={1};pwd={2};database={3}",
                                           host, user, pwd, db);
            var con = new MySqlConnection();
            con.ConnectionString = conStr;
            con.Open();
            return con;
        }
        public static MySqlConnection GetDefaultConnection()
        {
            return GetConnection("127.0.0.1", "root", "root", "P4_projekt");
        }
        //Returnerer kun strenge
        public static void RunQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = GetDefaultConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader[i]);
                Console.WriteLine();
            }
        }
        //For alle typer data
        public static void Query/*table_name*/()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select something from something";
            cmd.Connection = GetDefaultConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int phone_number = reader.GetInt32(0);
                string name = reader.GetString(1);
                //osv//
                var tmp = String.Format("{0}\t{1}", phone_number, name);/*column names*/
                Console.WriteLine(tmp);
            }
            reader.Close();
        }
        //Insert
        public static void Add/*table_name*/(int id, string name)
        {
            var con = GetDefaultConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into *table* values (@id,@name)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            if (con != null) { con.Close(); }
        }
        //Delete//
        public static void DeleteBy/*row_name*/(int dr)
        {
            var con = GetDefaultConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from *table* where id=@1";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@1", 1);
            cmd.ExecuteNonQuery();
            if (con != null) { con.Close(); }
        }
        //Update
        public static void UpdateName(int id,string newName)
        {
            var con = GetDefaultConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update *table* set name=@name where id=@1";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@1", 1);
            cmd.Parameters.AddWithValue("@name", newName);
            cmd.ExecuteNonQuery();
            if (con != null) { con.Close(); }
        }
        static void Main(string[] args)
        {
            //Kald metoder//
        }
    }
}
