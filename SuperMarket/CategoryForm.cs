using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SuperMarket
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into CategoryTbl values("+CatId_txtbx.Text+","+CatName_txtbx.Text + "," + CatDesc_txtbx.Text + ","+")";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added SuccesFully");
                conn.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            conn.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);  
            var ds = new DataSet();
                adapter.Fill(ds);
            Cat_dataGridView.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void products_button_Click(object sender, EventArgs e)
        {
            ProductForm product=new ProductForm();
            product.Show();
            this.Hide();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }
    }
}
