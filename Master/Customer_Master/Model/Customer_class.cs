using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    public class Customer : User
    {
        //- Instance variables
        private int customer_id = "N/A";
        private string first_name = "N/A";
        private string last_name = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private int zip_code = "N/A";
        private char phone_number = "N/A";
        private int balance = "0";

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
        public Customer(int Customer_id, string First_name, string Last_name, string Address, string City, int ZIP_code, char Phone_number, int Balance)
        {

        }

        //- Edit profile, but how
        public void SetFN(string newFN)
        {
            First_name = newFN;
        }
        public void DeleteThis()
        {

        }
    }
}