using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_managment.DAL;
using library_managment.PL;

namespace library_managment.PL
{
    public partial class splashScreen : Form
    {
        LogIn logIn = new LogIn();
        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            logIn.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
