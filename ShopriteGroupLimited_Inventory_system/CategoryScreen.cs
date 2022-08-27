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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
