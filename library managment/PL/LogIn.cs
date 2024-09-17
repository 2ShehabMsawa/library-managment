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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            comUser.DisplayMember = "user";
            comUser.ValueMember = "password";
            comUser.DataSource =  DBMethods.getData("get_all_users", null);
        }


        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == comUser.SelectedValue.ToString()) {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
