﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Customer_Master.Interface
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void LabelKR_Click(object sender, EventArgs e)
        {

        }

        private void labFornavn_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpdater_Click(object sender, EventArgs e)
        {

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

        private void BoxFornavn_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static void Main(string[] args)
    {
        string connStr = "server=localhost;user=root;database=conntest;port=3306;password=Ec2lW&B1Ag;charset=latin1;";
        MySQLConnection conn = new MySQLConnection(connStr);
        try
        {
            Console.WriteLine("Forbinder til databasen");
            conn.Open();
            string sql = "SELECT First_name, Last_name, Email, Password, Balance FROM customer_table";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1]);   // [] kan ikke huske om det er array plads?!
            }
            rdr.Close();
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
}
