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

namespace SuperMarket
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }
        public static string SellerName = "";

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDB.mdf;Integrated Security=True;Connect Timeout=30");

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
                            SellerName=user_textBox.Text.ToString();
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct User Name and password");
                        }
                    }
                    else
                    {
                        conn.Open();
                        SqlDataAdapter sda=new SqlDataAdapter("Select count(8) from Tbl where SellerName='"+user_textBox.Text+"'and SellerPass='"+password_txtbox.Text+"'",conn);
                        DataTable dt=new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellerName = user_textBox.Text.ToString();
                            SellingForm sellingForm = new SellingForm();
                            sellingForm.Show();
                            this.Hide();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct User Name and password");
                        }
                        conn.Close();   
                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }

            }
          
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            user_textBox.Clear();
            password_txtbox.Clear();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (password_txtbox.PasswordChar=='*')
            {
                password_txtbox.PasswordChar = '\0';
            }
            else
            {
                password_txtbox.PasswordChar = '*';
            }
        }

        private void user_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
