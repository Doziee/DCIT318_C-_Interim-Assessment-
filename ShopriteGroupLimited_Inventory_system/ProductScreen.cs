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

namespace ShopriteGroupLimited_Inventory_system
{
    public partial class ProductScreen : Form
    {
        public ProductScreen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateIntoProdViewGrid()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void forPCatCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CatName from CategoryTbl", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(reader);
            PCatCombo.ValueMember = "CatName";
            PCatCombo.DataSource = dt;
            Con.Close();
        }
        private void ProductScreen_Load(object sender, EventArgs e)
        {
            forPCatCombo();
            populateIntoProdViewGrid();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            CategoryScreen categoryScreen = new CategoryScreen();
            categoryScreen.Show();
            this.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into ProductTbl values(" + ProdId.Text + ", '" + ProdName.Text + "', " + ProdQty.Text + ", " + ProdPrice.Text + ", '" + PCatCombo.SelectedValue.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                Con.Close();
                populateIntoProdViewGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            PCatCombo.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProdId =" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    Con.Close();
                    populateIntoProdViewGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set ProdName = '" + ProdName.Text + "', ProdPrice = '" + ProdPrice.Text + "', ProdQty = '" + ProdQty.Text + "' where ProdId = " + ProdId.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully");
                    Con.Close();
                    populateIntoProdViewGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            populateIntoProdViewGrid();
        }
        private void PCatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
