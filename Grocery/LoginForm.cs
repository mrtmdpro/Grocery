using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextbox.Text;
            string password = this.passwordTextbox.Text;
            using (var DB = new GroceryEntities()) 
            {
                var IsValid = DB.user.FirstOrDefault(item=>item.username == username && item.password == password);
                if (IsValid != null)
                {
                    var MainForm = new MainForm(username);
                    this.Hide();
                    MainForm.Show();
                }
                else { MessageBox.Show("Wrong information"); };
            }
        }
    }
}
