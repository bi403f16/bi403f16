using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DB_connection;
using System.Windows.Forms;

namespace App_model
{
    public class Customer : User
    {

        public int Customer_id { get; protected set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZIP_code { get; set; }
        public char Phone_number { get; set; }
        public int Balance { get; set; }
        

        #region Adding Customers
        //- Full constructor if needed
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

        //- Create customer from input
        public Customer(string email, string password)
        {
            Email = email;
            Password = password;
        }
        #endregion

        #region Deleting Customers
        //- Delete customer
        public void DeleteCustomer(int Customer_id)
        {
            var cmd = Connection.RdyQuery();
            cmd.CommandText = "DELETE FROM customer_table WHERE Customer_id = @Customer_id;";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Customer_id", Customer_id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        #endregion

        //- Edit profile? måske ikke her, ikke prioritet
        public void SetFN(string newFN)
        {
            First_name = newFN;
        }
    }
}
