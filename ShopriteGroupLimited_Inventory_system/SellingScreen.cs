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

namespace ShopriteGroupLimited_Inventory_system
{
    public partial class SellingScreen : Form
    {
        public SellingScreen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void CatNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateLb.Text =  DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        private void populateIntoSellViewGrid()
        {
            Con.Open();
            string query = "select ProdName, ProdPrice from ProductTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            SellDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populateIntoBillViewGrid()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellingScreen_Load(object sender, EventArgs e)
        {
            populateIntoSellViewGrid();
            populateIntoBillViewGrid();
        }

        int flag = 0;
        private void SellDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = SellDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = SellDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void DateLb_Click(object sender, EventArgs e)
        {

        }

        int GrdTotal = 0, n = 0;

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (Billid.Text == "")
            {
                MessageBox.Show("BillID is missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into BillTbl values(" + Billid.Text + ", '" + SellerNameLb.Text + "', ' " + DateLb.Text + " ', " + AmtLb.Text + ") ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully");
                    Con.Close();
                    populateIntoBillViewGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void AmtLb_Click(object sender, EventArgs e)
        {

        }

        private void AddPB_Click(object sender, EventArgs e)
        {
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                AmtLb.Text = " " + GrdTotal;
            }
        }
    }
}
