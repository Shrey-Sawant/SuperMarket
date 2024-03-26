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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shrey\OneDrive\Documents\SuperMarketDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ProdName,ProdQty from ProductTbl";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Prod_dataGridView.DataSource = dt;
            conn.Close();

        }
        private void populateBill()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SellingTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Bill_dataGridView.DataSource = dt;
            conn.Close();

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBill();
        }

        int flag = 0;

        private void Prod_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdQty_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice_txtBox.Text = Prod_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
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
                    conn.Open();
                    string query = "insert into SellingTable values(" + int.Parse(BillId_txtBox.Text) + ",'" + SELLER_label.Text + "','" + Date_lb.Text + "','" + RS_label.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added SuccesFully");
                    conn.Close();
                    populateBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Bill_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SUPERMARKET", new Font("Century Gothic", 25, FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Bill ID:"+Bill_dataGridView.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold),Brushes.Red,new Point(100,70));
            e.Graphics.DrawString("Seller Name:"+Bill_dataGridView.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold),Brushes.Red,new Point(100,100));
            e.Graphics.DrawString("Date:"+Bill_dataGridView.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold),Brushes.Red,new Point(100,130));
            e.Graphics.DrawString("Total Amount:"+Bill_dataGridView.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold),Brushes.Red,new Point(100,160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(230,230));
        }

        private void ADD_Pro_button_Click(object sender, EventArgs e)
        {
            if (ProdName_txtBox.Text == "" || ProdQty_txtBox.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int  total = Convert.ToInt32(ProdPrice_txtBox.Text) * Convert.ToInt32(ProdQty_txtBox.Text);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Order_dataGridView);
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = ProdName_txtBox.Text;
                row.Cells[2].Value = ProdPrice_txtBox.Text;
                row.Cells[3].Value = ProdQty_txtBox.Text;
                row.Cells[4].Value = Convert.ToInt32(ProdPrice_txtBox.Text) * Convert.ToInt32(ProdQty_txtBox.Text);
                Order_dataGridView.Rows.Add(row);
                n++;
                GrandTotal = GrandTotal + total;
                RS_label.Text = "RS " + GrandTotal.ToString();
            }
        }
    }
}
