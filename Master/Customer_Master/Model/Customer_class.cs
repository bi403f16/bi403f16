using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySQLConnection;


namespace Classes
{
    public class Customer : User
    {
        /*
        //- Instance variables
        private int customer_id = "N/A";
        private string first_name = "N/A";
        private string last_name = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private int zip_code = "N/A";
        private char phone_number = "N/A";
        private int balance = "0";
        */

        //- Properties
        public int Customer_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZIP_code { get; set; }
        public char Phone_number { get; set; }
        public int Balance { get; set; }

        //- Constructor
        public Customer(int id, string first, string last, string address, string city, int zip, char phone, int balance)
        {
            Customer_id = id;
            First_name = first;
            Last_name = last;
            Address = address;
            City = city;
            ZIP_code = zip;
            Phone_number = phone;
            Balance = balance;
        }

        //- Delete customer
        public void DeleteCustomer(int Customer_id)
        {
            try
            {
                string sql = "DELETE * FROM Customers WHERE Customer_id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn); //connection til db mangler
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);   // [] kan ikke huske om det er array plads?!
                }
                rdr.Close();

            }
        }

        //- Edit profile? måske ikke her
        public void SetFN(string newFN)
        {
            First_name = newFN;
        }
    }
}