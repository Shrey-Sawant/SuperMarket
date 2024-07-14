using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace SuperMarket
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDB.mdf;Integrated Security=True;Connect Timeout=30");
        int index,gtTotal;
        Bitmap bitmap;
        String name;
        private void populate()
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ProdName,ProdPrice,ProdQty,ProdStock from ProductTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Prod_dataGridView1.DataSource = dt;
            conn.Close();

        }

        int billId;
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
            SELLER_label.Text = Login_page.SellerName;
            generate();

        }

        private void generate()
        {
            conn.Close();
            conn.Open();
            string qu = "SELECT max(BillId) From SellingTable ;";
            SqlCommand cmd = new SqlCommand(qu, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    billId = reader.GetInt32(0);
                    billId += 1;
                }
                BillId_txtBox.Text = billId.ToString();
            }
        }

        private void Prod_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName_txtBox.Text = Prod_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProdQty_txtBox.Text = Prod_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date_lb.Text=DateTime.Today.Day.ToString()+"/"+ DateTime.Today.Month.ToString() + "/"+ DateTime.Today.Year.ToString();
        }
        int GrandTotal = 0, n = 0;

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (BillId_txtBox.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    conn.Close();
                    conn.Open();
                    string query = "insert into SellingTable values(" + int.Parse(BillId_txtBox.Text) + ",'" + SELLER_label.Text + "','" + Date_lb.Text + "','" + RS_label.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added SuccesFully");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Order_dataGridView.Height = Order_dataGridView.RowCount * Order_dataGridView.RowTemplate.Height ;
            bitmap=new Bitmap(Order_dataGridView.Width,Order_dataGridView.Height);
            Order_dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, Order_dataGridView.Width, Order_dataGridView.Height));
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.PrintPreviewControl.Zoom = 2;
               printDocument1.Print();
            }
        }

        private void Bill_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SuperMarket", new Font("Century Gothic", 30, FontStyle.Bold), Brushes.DarkRed, new Point(300, 30));
            e.Graphics.DrawImage(bitmap, 100 , 100);  
            e.Graphics.DrawString("Powered By CresentMoon.Ltd", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.AntiqueWhite, new Point(200,500));
            e.Graphics.DrawString("Total Amount:Rs" + gtTotal, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(300, 600));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Prod_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              ProdName_txtBox.Text = Prod_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
              ProdPrice_txtBox.Text = Prod_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fillcombo()
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CatName from CategoryTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            Cat_comboBox.ValueMember = "CatName";
            Cat_comboBox.DataSource = dt;
            conn.Close();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Cat_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string query = "Select * from ProductTbl  where ProdCat=" + Cat_comboBox.SelectedValue.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Prod_dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_page login=new Login_page();
            login.Show();
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            Seller_Info_Form s=new Seller_Info_Form();
            s.Show();
            this.Hide();
        }


        private void Order_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             index = e.RowIndex;
            DataGridViewRow row = Order_dataGridView.Rows[index];
            BillId_txtBox.Text = row.Cells[0].Value.ToString();
            ProdName_txtBox.Text = row.Cells[1].Value.ToString();
            ProdPrice_txtBox.Text = row.Cells[2].Value.ToString();
            ProdQty_txtBox.Text = row.Cells[3].Value.ToString();
        }
        int stk;
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            
            name = ProdName_txtBox.Text.ToString();
            int total = Convert.ToInt32(ProdPrice_txtBox.Text) * Convert.ToInt32(ProdQty_txtBox.Text);
            Order_dataGridView.Rows.RemoveAt(index);
            conn.Close();
            conn.Open();
            int qty = Convert.ToInt32(ProdQty_txtBox.Text);
                string query = "UPDATE ProductTbl SET ProdStock = ProdStock + @qty WHERE ProdName = @prodName;";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("qty", qty);
                sqlCommand.Parameters.AddWithValue("prodname", name);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                ProdName_txtBox.Text = "";
                ProdPrice_txtBox.Text = "";
                ProdQty_txtBox.Text = "";
                GrandTotal = GrandTotal - total;
                gtTotal = GrandTotal;
                RS_label.Text = " " + GrandTotal.ToString();
                populate();
        }


        private void Order_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ADD_Pro_button_Click(object sender, EventArgs e)
        {
            if (ProdName_txtBox.Text == "" || ProdQty_txtBox.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                name = ProdName_txtBox.Text.ToString();
                int total = Convert.ToInt32(ProdPrice_txtBox.Text) * Convert.ToInt32(ProdQty_txtBox.Text);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Order_dataGridView);
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = ProdName_txtBox.Text;
                row.Cells[2].Value = ProdPrice_txtBox.Text;
                row.Cells[3].Value = ProdQty_txtBox.Text;
                row.Cells[4].Value = Convert.ToInt32(ProdPrice_txtBox.Text) * Convert.ToInt32(ProdQty_txtBox.Text);
                conn.Close();
                conn.Open();
                string qu = "SELECT ProdStock From ProductTbl WHERE ProdName = @prodName;";
                SqlCommand cmd = new SqlCommand(qu, conn);
                cmd.Parameters.AddWithValue("prodname", name);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        stk = reader.GetInt32(0);
                    }
                }
                int qty = Convert.ToInt32(ProdQty_txtBox.Text);
                if (stk > qty)
                {
                    string query = "UPDATE ProductTbl SET ProdStock = ProdStock - @qty WHERE ProdName = @prodName;";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("qty", qty);
                    sqlCommand.Parameters.AddWithValue("prodname", name);
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();
                    populate();
                    ProdName_txtBox.Text = "";
                    ProdPrice_txtBox.Text = "";
                    ProdQty_txtBox.Text = "";
                    Order_dataGridView.Rows.Add(row);
                    n++;
                    GrandTotal = GrandTotal + total;
                    gtTotal = GrandTotal;
                    RS_label.Text = " " + GrandTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Number Of Items Are Unavailable");
                }
            }
        }
    }
}
