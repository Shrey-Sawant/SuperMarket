using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (user_textBox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (user_textBox.Text == "Admin" && password_txtbox.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct User Name and password");
                        }
                        else
                        {
                            MessageBox.Show("You are In Seller Section");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            user_textBox.Clear();
            password_txtbox.Clear();
        }
    }
}
