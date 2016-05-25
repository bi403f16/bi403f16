using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App_interface
{
    public partial class Choose_shop : Form
    {
        DataTable dt;
        private int Shop_name;

        public Choose_shop()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM shop_table order by Shop_name";
            string connStr = "server=localhost;user=root;database=p4;port=3306;password=fordgt40;charset=latin1;";
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable dt = new DataTable(sql);
            int count = dt.Rows.Count;
            if (count > 0)
            {
                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {
                    listBox1.Items.Add(dt.Rows[i][Shop_name].ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p4DataSet.shop_table' table. You can move, or remove it, as needed.
            this.shop_tableTableAdapter.Fill(this.p4_projektDataSet.shop_table);

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                this.Hide();
                Products pList = new Products();
                pList.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Hide();
                LogintoProfile profile = new LogintoProfile();
                profile.ShowDialog();
        }
    }
}