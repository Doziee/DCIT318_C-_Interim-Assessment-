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
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            CategoryScreen categoryScreen = new CategoryScreen();
            categoryScreen.Show();
            this.Hide();
        }
    }
}
