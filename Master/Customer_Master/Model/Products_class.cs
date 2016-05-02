using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
             bool cartHasItems = false;       //Set if the cart contains items

    Cart shoppingCart = ShoppingCart(false);
    if (!shoppingCart.IsEmpty)
         { 
                if (!Page.IsValid)
         {
                    return;
         }
      //
      // reset the quanities for all the items in cart
      //
      DataRowCollection orderRows = shoppingCart.OrderItems.Rows;
      int i = 0;
      foreach (DataGridItem item in CartItemsDataGrid.Items)
         {
                    https://www.youtube.com/watch?v=VGiSmKYUedg
                    https://www.youtube.com/watch?v=zKVwJ7AK7ww
                    https://msdn.microsoft.com/en-us/library/aa288545(v=vs.71).aspx