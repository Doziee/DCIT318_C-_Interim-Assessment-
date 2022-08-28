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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\shopritedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (UName.Text == "" || PSword.Text == "")
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                if(RoleCombo.SelectedIndex>-1)
                {
                    if (RoleCombo.SelectedItem.ToString() == "Admin")
                    {
                          if (UName.Text == "Admin" && PSword.Text == "12345")
                          {
                                    ProductScreen productScreen = new ProductScreen();
                                    productScreen.Show();
                                    this.Hide();
                          }
                          else
                          {
                                    MessageBox.Show("Enter correct username and password, if you are the admin");
                          }
                    }
                    else
                    {
                        //MessageBox.Show("You are registered as a seller");
                        Con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("Select Count(8) from SellerTbl where SellerName = '"+ UName.Text +"' and SellerPass = '"+PSword.Text+"'", Con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellingScreen sell = new SellingScreen();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select Role");
                }
            }
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            UName.Text = "";
            PSword.Text = "";
        }

        private void gunaLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void PSword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
