using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery
{
    public partial class CheckoutForm : Form
    {
        bool bySelf;
        bool byCar;
        bool byTruck;
        int OrderID;
        int UserID;
        public CheckoutForm(string price, int orderID, int userID)
        {
            InitializeComponent();
            this.totalBox.Text = price;
            bySelf = true;
            this.radioButton1.Checked = true;
            OrderID = orderID;
            UserID = userID;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bySelf = true;
            if (byCar)
            {
                byCar = false;
                var deduction = GetShipPrice("Car delivery");
                var currentPrice = Convert.ToDouble(this.totalBox.Text);
                currentPrice -= deduction;
                this.totalBox.Text = currentPrice.ToString();
            }
            else if (byTruck)
            {
                byTruck = false;
                var deduction = GetShipPrice("Container delivery");
                var currentPrice = Convert.ToDouble(this.totalBox.Text);
                currentPrice -= deduction;
                this.totalBox.Text = currentPrice.ToString();
            }
        }

        private double GetShipPrice(string method)
        {
            var price = 0.0;
            using (var DB = new GroceryEntities())
            {
                var pricing = DB.shipping.FirstOrDefault(item => item.method == method);
                if (pricing != null)
                {
                    price = Decimal.ToDouble((decimal)pricing.cost);
                }

            }
            return price;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            byCar = true;
            var adduction = GetShipPrice("Car delivery");
            if (byTruck)
            {
                byTruck = false;
                var deduction = GetShipPrice("Container delivery");
                var currentPrice = Convert.ToDouble(this.totalBox.Text);
                currentPrice -= deduction;
                currentPrice += adduction;
                this.totalBox.Text = currentPrice.ToString();
            }
            else
            {
                var currentPrice = Convert.ToDouble(this.totalBox.Text);
                currentPrice += adduction;
                this.totalBox.Text = currentPrice.ToString();
                if (bySelf) { bySelf = false; }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            byTruck = true;
            var adduction = GetShipPrice("Container delivery");
            if (byCar)
            {
                byCar = false;
                var deduction = GetShipPrice("Car delivery");
                var currentPrice = Convert.ToDouble(this.totalBox.Text);
                currentPrice -= deduction;
                currentPrice += adduction;
                this.totalBox.Text = currentPrice.ToString();
            }
            else
            {
                var currentPrice = Convert.ToDouble(this.totalBox.Text);
                currentPrice += adduction;
                this.totalBox.Text = currentPrice.ToString();
                if (bySelf) { bySelf = false; }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            using (var DB = new GroceryEntities())
            {
                var order = DB.order.SingleOrDefault(item => item.order_id == OrderID);
                if (order != null)
                {
                    if (byCar)
                    {
                        order.shipping_id = 4;
                    }
                    else if (byTruck)
                    {
                        order.shipping_id = 5;
                    }
                    order.note = this.noteBox.Text;
                    order.total = Convert.ToDecimal(totalBox.Text);
                    DB.SaveChanges();
                    MessageBox.Show("Thanks for shopping");
                    this.Close();
                }
            }
        }
    }
}
