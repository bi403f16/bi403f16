using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public class Shop
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    

    public string Name { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public int Zip_Code { get; set; }
    public int Phone { get; set; }
    public bool Type { get; set; }


    // Method.

    // Instance Constructor.
    public Shop(string name, string city, string address, int zip_code, int phone, bool type)
    {
        // 'NIKS KODE';
        Name = name;
        City = city;
        Address = address;
        Zip_Code = zip_code;
        Phone = phone;
        Type = type;

    }
    public override string ToString()
    {
        return "Navn: " + Name + " By: " + City + " Adresse:" + Address + 
                " Postnummer: " + Zip_Code + " Telefon: " + Phone; 
    }

}
}