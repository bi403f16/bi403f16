using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using App_interface;
using MySql.Data.MySqlClient;
using DB_connection;

namespace App_model
{
    class Products_class
    {
        private string v;

        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public string Category { get; set; }
        public DateTime Production_time { get; set; }
        public string Product_description { get; set; }
        public int Price { get; set; }
        public bool Reduced { get; set; }

        //Full constructor
        public void Products(int id, string name, string cat, DateTime time, string descr, int price, bool red)
        {
            Product_id = id;
            Product_name = name;
            Category = cat;
            Production_time = time;
            Product_description = descr;
            Price = price;
            Reduced = red;
        }

        public void Products(string v)
        {
            this.v = v;
        }

        //Empty constructor
        public void Products()
        {
            
        }
    }
}



