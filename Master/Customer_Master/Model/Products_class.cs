using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            SqlConnection sqlConnection1 =
            new SqlConnection("YOUR CONNECTION STRING");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Product (ProductID, ProductDescription) VALUES (6, 'Kaffe')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            {
                bool value = true;
                Console.WriteLine(value);

                value = !value;
                Console.WriteLine(value);

                value = false;
                Console.WriteLine(value);

                if (value)
                {
                    Console.WriteLine("Fuldt menukort");
                }
                {
                    if (!value)
                    { 
                        Console.WriteLine("Ikke fuldt menukort");
                    
                        public class productinfo
                        {
                                    public string ProductName;
                                    public string ProductImage;
                                    public string ProductDescription;
                                    public string ProductPrice;
    
            String ProductName();
            String ProductImage();
            String ProductDescription();
            int ProductPrice();
    }
}
}            
        
    

