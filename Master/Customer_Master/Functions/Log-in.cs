using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Customer_Master;

namespace Login
{
    public partial class Login : Form
    {
        private string connStr;
        private MySqlConnection conn;
        public static int CurrentUserID = -1;
        public Login()
        {
            InitializeComponent();
        }
        private void connect_to_DB()
        {
            try
            {
                connStr = "server=localhost;user=root;database=p4_projekt;port=3306;password=Jeppesen95;charset=latin1;";
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private bool login_validation(string email, string pass)
        {
            connect_to_DB();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from customer_table where Email=@email and Password=@pass";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = conn;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                CurrentUserID = login.GetInt32(login.GetOrdinal("Customer_id"));
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string pass = textBoxPass.Text;
            if (email == "" || pass == "")
            {
                MessageBox.Show("Tomme felter, udfyld venligst begge felter");
                return;
            }
            bool r = login_validation(email, pass);
            if (r)
            {
                MessageBox.Show("Korrekte oplysninger");
                this.Hide();
                LogintoProfile name = new LogintoProfile();
                name.ShowDialog();  
            }

            else
                MessageBox.Show("Forkerte oplysninger");
        }
    }
}
