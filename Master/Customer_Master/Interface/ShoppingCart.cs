using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;//Burde slette fejlen længere nede, da Browse_products ligger i dette namespace
using System.Windows.Forms;

namespace Customer_Master.Interface
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Content.Clear();
        }

        private void BrowseProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Browse_products name = new Browse_products;
            name.ShowDialog();
        }
    }
}
