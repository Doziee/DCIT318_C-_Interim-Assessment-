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
    public partial class SellerScreen : Form
    {
        public SellerScreen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populateIntoSellViewGrid()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SellerScreen_Load(object sender, EventArgs e)
        {
            populateIntoSellViewGrid();
        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sid.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            SPhone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SPass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into SellerTbl values(" + Sid.Text + ", '" + SName.Text + "', " + SAge.Text + ", " + SPhone.Text + ", '" + SPass.Text + "') ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added successfully");
                Con.Close();
                populateIntoSellViewGrid();
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
                if (Sid.Text == "" || SName.Text == "" || SAge.Text == "" || SPhone.Text == "" || SPass.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName = '" + SName.Text + "', SellerAge = '" + SAge.Text + "', SellerPhone = '" + SPhone.Text + "', SellerPassword = '" + SPass.Text + "' where Sellerid = " + Sid.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller updated successfully");
                    Con.Close();
                    populateIntoSellViewGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
