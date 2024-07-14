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
using System.Net.NetworkInformation;

namespace SuperMarket
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int stock;

        private void populate()
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ProductTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Prod_dataGridView.DataSource = dt;
            conn.Close();

        }
        private void fillcombo()
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CatName from CategoryTbl", conn);
            SqlDataReader rdr;
            rdr=cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(rdr);
            Cat_comboBox.ValueMember = "CatName";
            Cat_comboBox.DataSource=dt;
            ProdCat_comboBox.ValueMember = "CatName";
            ProdCat_comboBox.DataSource = dt;
            conn.Close();

        }

        private void category_button_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string query = "insert into ProductTbl values(" + int.Parse(ProdId_txtBox.Text) + ",'" + ProdName_txtBox.Text + "','" + ProdQty_txtBox.Text + "'," + float.Parse(ProdPrice_txtBox.Text) +",'"+Cat_comboBox.SelectedValue.ToString()+ "','" + Stock_txtBox.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added SuccesFully");
                conn.Close();
                populate();
                ProdId_txtBox.Text = "";
                ProdName_txtBox.Text = "";
                ProdQty_txtBox.Text = "";
                ProdPrice_txtBox.Text = "";
                Stock_txtBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProdName_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Cat_comboBox.SelectedValue = Prod_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Stock_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            stock=Convert.ToInt32(Stock_txtBox.Text);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId_txtBox.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string query = "delete from ProductTbl where ProdId=" + ProdId_txtBox.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    conn.Close();
                    populate();
                    ProdId_txtBox.Text = "";
                    ProdName_txtBox.Text = "";
                    ProdQty_txtBox.Text = "";
                    ProdPrice_txtBox.Text = "";
                    Stock_txtBox.Text = "";
                    conn.Close();
                }
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
                if (ProdId_txtBox.Text == "" || ProdName_txtBox.Text == "" || ProdQty_txtBox.Text == ""||ProdPrice_txtBox.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    int qty = Convert.ToInt32(Stock_txtBox.Text);
                    int upd=stock+qty;
                    conn.Close();
                    conn.Open();
                    string query = "Update ProductTbl set ProdName='" + ProdName_txtBox.Text + "',ProdQty='" + ProdQty_txtBox.Text + "',ProdPrice='" + ProdPrice_txtBox.Text + "',ProdStock=" + upd + "where ProdId=" + ProdId_txtBox.Text + ";";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    conn.Close();
                    populate();
                    ProdId_txtBox.Text = "";
                    ProdName_txtBox.Text = "";
                    ProdQty_txtBox.Text = "";
                    ProdPrice_txtBox.Text = "";
                    Stock_txtBox.Text = "";
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void ProdCat_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ProductTbl where ProdCat='" + ProdCat_comboBox.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Prod_dataGridView.DataSource= null;
            Prod_dataGridView.DataSource = dt;
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_page login = new Login_page();
            login.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Prod_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProdName_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Cat_comboBox.SelectedValue = Prod_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Stock_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void ProdCat_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Close();
            conn.Open();
            string query = "Select * from ProductTbl  where ProdCat=" + Cat_comboBox.SelectedValue.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Prod_dataGridView.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
    }

