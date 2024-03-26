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

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDB.mdf;Integrated Security=True;Connect Timeout=30");

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into CategoryTbl values(" + int.Parse(CatId_txtbx.Text) + ",'" + CatName_txtbx.Text + "','" + CatDesc_txtbx.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added SuccesFully");
                conn.Close();
                populate();
                CatId_txtbx.Text = "";
                CatName_txtbx.Text = "";
                CatDesc_txtbx.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void populate()
         {
              conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select * from CategoryTbl";
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da=new  SqlDataAdapter(cmd);
             da.Fill(dt);
            Cat_dataGridView.DataSource = dt;
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

        private void Cat_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId_txtbx.Text = Cat_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            CatName_txtbx.Text = Cat_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            CatDesc_txtbx.Text = Cat_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try {
                if (CatId_txtbx.Text == "" || CatName_txtbx.Text == "" || CatDesc_txtbx.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string query = "Update from CategoryTbl set CatName='" + CatName_txtbx.Text + "',CatDesc='" + CatDesc_txtbx.Text + "'where CatId=" + CatId_txtbx.Text + ";";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    conn.Close();
                    populate();
                    CatId_txtbx.Text = "";
                    CatName_txtbx.Text = "";
                    CatDesc_txtbx.Text = "";

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId_txtbx.Text=="")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from CategoryTbl where CatId=" + CatId_txtbx.Text + "";
                    SqlCommand cmd=new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    conn.Close();
                    populate();
                    CatId_txtbx.Text = "";
                    CatName_txtbx.Text = "";
                    CatDesc_txtbx.Text = "";
                }
            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
