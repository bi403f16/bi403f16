using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace Customer_Master
{
    public partial class LogintoProfile : Form
    {
        public LogintoProfile()
        {
            InitializeComponent();
        }

        private void BoxPawo_TextChanged(object sender, EventArgs e)
        {
            //Boxen viser stjerner i stedet for text
            BoxPawo.PasswordChar = '*';
            //Maxlængde på Password
            BoxPawo.MaxLength = 36;
            //Valg af text i box
            BoxPawo.Text = "test";
        }

        private void BoxCopawo_TextChanged(object sender, EventArgs e)
        {
            //Boxen viser stjerner i stedet for text
            BoxPawo.PasswordChar = '*';
            //Maxlængde på Password
            BoxPawo.MaxLength = 36;
            //Valg af text i box
            BoxPawo.Text = "test";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=p4_projekt;port=3306;password=Jeppesen95;charset=latin1;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Forbinder til databasen");
                conn.Open();
                string sql = "UPDATE p4_projekt.customer_table set First_name='" + BoxFornavn.Text + "',Last_name='" + BoxEfternavn.Text + "',Email='" + textBoxEmail.Text + "',Password=" + BoxPawo.Text + "WHERE Customer_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);   // [] kan ikke huske om det er array plads?!
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            Console.ReadLine();
        }

        private void TankOp_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=p4_projekt;port=3306;password=Jeppesen95;charset=latin1;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Forbinder til databasen");
                conn.Open();
                string sql = "UPDATE p4_projekt.customer_table set Balance'" + Balance.Text + "WHERE Customer_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);   // [] kan ikke huske om det er array plads?!
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}

