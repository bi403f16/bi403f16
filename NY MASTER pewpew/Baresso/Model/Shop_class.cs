using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace App_model
{
    public class Shop_class
    {
        private string v;

        public int Shop_id { get; protected set; }
        public string Shop_name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip_code { get; set; }
        public int Phone_number { get; set; }
        public bool Type { get; set; }

        //Full constructor
        public Shop_class(int shop_id, string shop_name, string city, string address, int zip_code, int phone_number, bool type)
        {
            Shop_id = shop_id;
            Shop_name = shop_name;
            City = city;
            Address = address;
            Zip_code = zip_code;
            Phone_number = phone_number;
            Type = type;
        }

        public Shop_class(string v)
        {
            this.v = v;
        }

        //Empty constructor
        public Shop_class() { }

        #region TIDLIGERE CONNECTION

        class myConnection
        {
            public MySqlConnection Getconnection()
            {
                var shop = new Shop_class();
                string str = "server=localhost;user=root;database=conntest;port=3306;password=pollebo1;charset=latin1;";

                MySqlConnection conn = new MySqlConnection(str);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM shop_table WHERE Shop_id = 1", conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    shop.Shop_id = Convert.ToInt32(reader["Shop_id"]);
                    shop.Shop_name = reader["Name"].ToString();
                    shop.Address = reader["Address"].ToString();
                    shop.City = reader["City"].ToString();
                    shop.Zip_code = Convert.ToInt32(reader["Zip_code"]);
                    shop.Phone_number = Convert.ToInt32(reader["Phone_number"]);
                    shop.Type = Convert.ToBoolean(reader["Type"]);
                }
                return null;
            }
            
#endregion
    }
    }

}



// Method.

//        Instance Constructor.
//        public Shop(string name, string city, string address, int zip_code, int phone, bool type)
//        {
//            'NIKS KODE';
//            Name = name;
//            City = city;
//            Address = address;
//            Zip_Code = zip_code;
//            Phone = phone;
//            Type = type;

//        }
//        public override string ToString()
//        {
//            return "Navn:" + Name + "By:" + City + "Adresse:" + Address;
//        }

//    }
//}
//Another class definition. This one contains

// the Main method, the entry point for the program.