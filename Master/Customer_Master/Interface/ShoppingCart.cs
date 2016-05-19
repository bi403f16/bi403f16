using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt;
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
            Projekt.Menu name = new Projekt.Menu();
            name.ShowDialog();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            /*this.hide
            navnpånyform var=new navnpånyform();
            var.ShowDialog();
            */
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogintoProfile name = new LogintoProfile();
            name.ShowDialog();
        }
    }
}
