using Grocery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grocery
{
    public partial class MainForm : Form
    {
        string username;
        public MainForm(string usrname)
        {
            InitializeComponent();
            username = usrname;
        }
        private void productBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            string ProductName = btn.Text;
            ProductName = ProductName.Replace("Btn", "");
            var price = GetPrice(ProductName);
            var itemInCart = this.currentCart.FindItemWithText(ProductName);
            if (itemInCart != null)
            {
                var currentQuantity = Convert.ToInt32(itemInCart.SubItems[1].Text) + 1;
                price = price * currentQuantity;
                itemInCart.SubItems[1].Text = currentQuantity.ToString();
                itemInCart.SubItems[2].Text = price.ToString();
            }
            else
            {
                string[] row = { ProductName, "1", price.ToString() };
                var listViewItem = new ListViewItem(row);
                currentCart.Items.Add(listViewItem);
            }
            calculateTotal();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.currentCart.SelectedItems.Count > 0)
            {
                this.currentCart.SelectedItems[0].Remove();
            }
            else { MessageBox.Show("No item to remove."); }
            calculateTotal();
        }

        private void currentCart_ItemActivate(object sender, EventArgs e)
        {
            if (this.currentCart.SelectedItems.Count > 0)
            {
                this.UpDownBtn.Value = Convert.ToInt32(this.currentCart.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void UpDownBtn_ValueChanged(object sender, EventArgs e)
        {
            if (this.currentCart.SelectedItems.Count > 0)
            {
                if (Convert.ToInt32(this.currentCart.SelectedItems[0].SubItems[1].Text) > 0)
                {
                    var quantity = UpDownBtn.Value;
                    this.currentCart.SelectedItems[0].SubItems[1].Text = quantity.ToString();
                    var price = GetPrice(this.currentCart.SelectedItems[0].SubItems[0].Text);
                    price = price * Convert.ToInt32(quantity);
                    this.currentCart.SelectedItems[0].SubItems[2].Text = price.ToString();
                }
            }
            else
            {
                this.currentCart.SelectedItems[0].Remove();
            }
            calculateTotal();
        }

        private void UpDownBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.currentCart.SelectedItems.Count > 0)
            {
                if (Convert.ToInt32(this.currentCart.SelectedItems[0].SubItems[1].Text) > 0)
                {
                    this.currentCart.SelectedItems[0].SubItems[1].Text = UpDownBtn.Value.ToString();
                }
            }
            else
            {
                this.currentCart.SelectedItems[0].Remove();
            }
        }

        private double GetPrice(string productName)
        {
            var price = 0.0;
            using (var DB = new GroceryEntities())
            {
                var pricing = DB.product.FirstOrDefault(item => item.name == productName);
                if (pricing != null)
                {
                    price = Decimal.ToDouble(pricing.price);
                }
                
            }
            return price;
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            if (currentCart.Items.Count == 0)
            {
                MessageBox.Show("Nothing to be purchased.");
            }
            else
            {
                var totalPrice = Convert.ToDecimal(this.totalBox.Text);
                int OrderID;
                int UserID;
                using (var DB = new GroceryEntities())
                {
                    var user = DB.user.FirstOrDefault(item => item.username == username);
                    UserID = user.user_id;
                    var newOrder = new order { total = totalPrice, user_id = UserID, shipping_id = 3};
                    DB.order.Add(newOrder);
                    DB.SaveChanges();
                    OrderID = newOrder.order_id;
                    foreach (ListViewItem cartItem in currentCart.Items)
                    {
                        string productName = cartItem.SubItems[0].Text;
                        var product = DB.product.FirstOrDefault(item => item.name == productName);
                        int productID = product.product_id;
                        var amount = Convert.ToInt32(cartItem.SubItems[1].Text);
                        var newOrderItem = new order_item { order_id = newOrder.order_id, product_id = productID, amount = amount};
                        DB.order_item.Add(newOrderItem);
                        DB.SaveChanges();
                    }
                }
                string price = this.totalBox.Text;
                CheckoutForm checkout = new CheckoutForm(price, OrderID, UserID);
                checkout.Show(); 
            }
        }

        private void calculateTotal()
        {
            var price = 0.0;
            foreach (ListViewItem item in currentCart.Items)
            {
                price += Convert.ToDouble(item.SubItems[2].Text);
            }
            this.totalBox.Text = price.ToString();
        }
    }
}
