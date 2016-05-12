using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BaressoApp

{

    // Class definition.

    public class Shop


    {
        private string v;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        // Class members:



        // Property.


        public int Shop_id { get; set; }
        public string Shop_name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip_code { get; set; }
        public int Phone_number { get; set; }
        public bool Type { get; set; }

        protected Shop() { }
        public Shop (int shop_id, string shop_name, string city, string address, int zip_code, int phone_number, bool type)
        {
            Shop_id = shop_id;
            Shop_name = "shop_name";
            City = city;
            Address = address;
            Zip_code = zip_code;
            Phone_number = phone_number;
            Type = type;
        }

        public Shop(string v)
        {
            this.v = v;
        }

        class myConnection
        {
            public static MySqlConnection Getconnection()
            
            {
                var Shop = new Shop();
                string str = "server=localhost;user=root;database=conntest;port=3306;password=;charset=latin1;";

                MySqlConnection conn = new MySqlConnection(str);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Company WHERE CompanyID = 1", conn);
           
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Shop.Shop_id = Convert.ToInt32(reader["Shop_id"]);
                    Shop.Shop_name = reader["Name"].ToString();
                    Shop.Address = reader["Address"].ToString();
                    Shop.City = reader["City"].ToString();
                    Shop.Zip_code = Convert.ToInt32(reader["Zip_code"]);
                    Shop.Phone_number = Convert.ToInt32(reader["Phone_number"]);
                    Shop.Type = Convert.ToBoolean(reader["Type"]);
                    
                }
            }
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