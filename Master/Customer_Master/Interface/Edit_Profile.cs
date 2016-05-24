using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace App_interface
{
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_interface.Login name = new App_interface.Login();
            name.ShowDialog();
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=p4_projekt;port=3306;password=Jeppesen95;charset=latin1;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT First_name, Last_name, Address, City, ZIP_code, Phone_number, Password, Email, Balance FROM p4_projekt.customer_table WHERE Customer_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = App_interface.Login.CurrentUserID;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Firstname.Text = rdr["First_name"].ToString();
                    Lastname.Text = rdr["Last_name"].ToString();
                    Address.Text = rdr["Address"].ToString();
                    City.Text = rdr["City"].ToString();
                    ZIP.Text = rdr["ZIP_code"].ToString();
                    Phone.Text = rdr["Phone_number"].ToString();
                    E_mail.Text = rdr["Email"].ToString();
                    CurrentPass.Text = rdr["Password"].ToString();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil gemme dine ændringer?", "Gem oplysninger", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connStr = "server=localhost;user=root;database=p4_projekt;port=3306;password=Jeppesen95;charset=latin1;";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = @"UPDATE p4_projekt.customer_table 
               set First_name=@firstname, Last_name=@lastname,
                   Email=@email,Password=@password
               WHERE Customer_id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = Firstname.Text;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = Lastname.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = E_mail.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text;
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = App_interface.Login.CurrentUserID;
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
            }
        }
    }
}
