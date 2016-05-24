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

namespace App_interface
{
    public partial class LogintoProfile : Form
    {
        public LogintoProfile()
        {
            InitializeComponent();
        }

        private void TankOp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connStr = "server=localhost;user=root;database=p4_projekt;port=3306;password=Jeppesen95;charset=latin1;";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    MessageBox.Show("Forbinder til databasen");
                    conn.Open();
                    string sql = @"UPDATE p4_projekt.customer_table set Balance=@balance WHERE Customer_id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.Add("@balance", MySqlDbType.Int32).Value = Balance.Text;
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = App_interface.Login.CurrentUserID;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + " -- " + rdr[1]);   // [] kan ikke huske om det er array plads?!
                    }
                    rdr.Close();
                    MessageBox.Show("Balance opdateret");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_interface.Login name = new App_interface.Login();
            name.ShowDialog();
        }

        private void LogintoProfile_Load(object sender, EventArgs e)
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
                    BoxFornavn.Text = rdr["First_name"].ToString();
                    BoxEfternavn.Text = rdr["Last_name"].ToString();
                    BoxAdresse.Text = rdr["Address"].ToString();
                    BoxCity.Text = rdr["City"].ToString();
                    BoxZip.Text = rdr["ZIP_code"].ToString();
                    BoxPhone.Text = rdr["Phone_number"].ToString();
                    textBoxEmail.Text = rdr["Email"].ToString();
                    BoxPawo.Text = rdr["Password"].ToString();
                    BoxBalance.Text = rdr["Balance"].ToString();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile name = new Edit_Profile();
            name.ShowDialog();
        }
    }
}

