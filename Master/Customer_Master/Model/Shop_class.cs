using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Windows.Forms;
>>>>>>> fe474f9695f4da1350c24db7fb8563f3aa26fe9e
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Shop
    {
        //Properties
        public int Shop_id { get; set; }
        public string Shop_name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Zip_code { get; set; }
        public int Phone_number { get; set; }
        public bool Type { get; set; }

        // Instance Constructor.
        protected Shop() { }
        public Shop(int shop_id, string shop_name, string city, string address, int zip_code, int phone_number, bool type)
        {
            // 'NIKS KODE';
            Shop_id = shop_id;
            Shop_name = shop_name;
            City = city;
            Address = address;
            Zip_code = zip_code;
            Phone_number = phone_number;
            Type = type;
        }

        //DB connection
        private readonly string _connectionString;
        public Shop(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Shop GetByShopID(string Shop_id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT ...";
                connection.Open();
                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(...);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Shop
                            {
                                Shop_id = reader[0].ToString(),
                                Shop_name = reader[1].ToString(),
                                City = reader[2].ToString(),
                                Address = reader[3].ToString(),
                                Zip_code = reader[4].ToString(),
                                Phone_number = reader[5].ToString(),
                                Type = reader[6].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        /*public override string ToString()
        {
            return "Navn: " + Name + " By: " + City + " Adresse:" + Address + 
                    " Postnummer: " + Zip_Code + " Telefon: " + Phone; 
        }*/

    }
}