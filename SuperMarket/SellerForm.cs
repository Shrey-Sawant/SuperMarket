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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Seller_dataGridView.DataSource = dt;
            conn.Close();

        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void category_button_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void Selling_Click(object sender, EventArgs e)
        {

        }


        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerId_txtBox.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string query = "delete from Tbl where SellerId=" + SellerId_txtBox.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    conn.Close();
                    populate();
                    SellerId_txtBox.Text = "";
                    SellerName_txtBox.Text = "";
                    SellerAge_txtBox.Text = "";
                    SellerPhone_txtBox.Text = "";
                    SellerPass_txtBox.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string query = "insert into Tbl values(" + int.Parse(SellerId_txtBox.Text) + ",'" + SellerName_txtBox.Text + "','" + SellerAge_txtBox.Text + "','" + int.Parse(SellerPhone_txtBox.Text )+ "','" + SellerPass_txtBox.Text + "," + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added SuccesFully");
                conn.Close();
                populate();
                SellerId_txtBox.Text = "";
                SellerName_txtBox.Text = "";
                SellerAge_txtBox.Text = "";
                SellerPhone_txtBox.Text = "";
                SellerPass_txtBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerId_txtBox.Text == "" || SellerName_txtBox.Text == "" || SellerAge_txtBox.Text == "" ||SellerPhone_txtBox.Text == "" || SellerPass_txtBox.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string query = "Update Tbl set SellerName='" + SellerName_txtBox.Text + "',SellerAge='" + SellerAge_txtBox.Text + "',SellerPhone='" + SellerPhone_txtBox.Text + "',SellerPass='" + SellerPass_txtBox.Text+ "'where SellerId="+SellerId_txtBox.Text+";";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    conn.Close();
                    populate();
                    SellerId_txtBox.Text = "";
                    SellerName_txtBox.Text = "";
                    SellerAge_txtBox.Text = "";
                    SellerPhone_txtBox.Text = "";
                    SellerPass_txtBox.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_page login = new Login_page();
            login.Show();
        }

        private void Seller_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SellerId_txtBox.Text = Seller_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            SellerName_txtBox.Text = Seller_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            SellerAge_txtBox.Text = Seller_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhone_txtBox.Text = Seller_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SellerPass_txtBox.Text = Seller_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Seller_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
