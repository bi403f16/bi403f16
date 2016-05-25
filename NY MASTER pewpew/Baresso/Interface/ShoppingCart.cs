using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_interface;
using System.Windows.Forms;

namespace App_interface
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

       /*#region NotImplementedException HUSK AT SLETTE
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        #endregion
        */

        private void Remove_Click(object sender, EventArgs e)
        {
            // Content.Clear();
        }

        private void BrowseProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_interface.Products name = new App_interface.Products();
            name.ShowDialog();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            /*this.hide
            navnpånyform var=new navnpånyform();
            var.ShowDialog();
            */
        }
    }
}
