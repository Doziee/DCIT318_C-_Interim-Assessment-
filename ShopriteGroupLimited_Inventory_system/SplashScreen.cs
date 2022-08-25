using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopriteGroupLimited_Inventory_system
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            SplashProgress.Value = startpoint;
            if (SplashProgress.Value == 100)
            {
                SplashProgress.Value = 0;
                timer1.Stop();
                LoginScreen log = new LoginScreen();
                this.Hide();
                log.Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
