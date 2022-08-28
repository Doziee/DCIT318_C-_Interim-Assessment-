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
    public partial class CategoryScreen : Form
    {
        public CategoryScreen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into CategoryTbl values(" + CatidTb.Text + ", '" + CatNameTb.Text + "', '" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully");
                Con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populateIntoCatViewGrid()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryScreen_Load(object sender, EventArgs e)
        {
            populateIntoCatViewGrid();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatidTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTb.Text == "")
                {
                    MessageBox.Show("Select Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where Catid =" + CatidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully");
                    populateIntoCatViewGrid();
                    Con.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName = '" + CatNameTb.Text + "', CatDesc = '" + CatDescTb.Text + "' where Catid = " + CatidTb.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catergory updated successfully");
                    Con.Close();
                    populateIntoCatViewGrid();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
