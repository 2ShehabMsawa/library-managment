using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_managment.PL;
//using library_managment.PL.Dialogs;
namespace library_managment.PL
{
    public partial class Home : Form
    {
        MainPage mainPage = new MainPage();
        EmployeePage employeePage = new EmployeePage();
        CustomerPage customerPage = new CustomerPage();
        BookPage bookPage = new BookPage();
        BellPage bellPage = new BellPage();
        ReportsPage ReportsPage = new ReportsPage();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(mainPage.pnlMain);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(employeePage.pnlMine);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(customerPage.pnlMine);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(bookPage.pnlMine);
        }

        private void btnBells_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(bellPage.pnlMain);
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();
            pnlView.Controls.Add(ReportsPage.pnlMain);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnMain.PerformClick();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(pnlNav.Size.Width== 249)
            {
                pnlNav.Width = 60;
                guna2Panel1.Width = 60;
                btnBells.RightToLeft = RightToLeft.Yes;
                btnBells.Text = "";
                btnBook.RightToLeft = RightToLeft.Yes;
                btnBook.Text = "";
                btnCustomer.RightToLeft = RightToLeft.Yes;
                btnCustomer.Text = "";
                btnEmployee.RightToLeft = RightToLeft.Yes;
                btnEmployee.Text = "";
                btnMain.RightToLeft = RightToLeft.Yes;
                btnMain.Text ="";
                btnReports.RightToLeft = RightToLeft.Yes;
                btnReports.Text = "";
                btnSrudent.RightToLeft = RightToLeft.Yes;
                btnSrudent.Text = "";
                btnBorrow.RightToLeft = RightToLeft.Yes;
                
            }
            else
            {
                pnlNav.Width = 249;
                guna2Panel1.Width = 249;
                btnBells.RightToLeft = RightToLeft.No;
                btnBells.Text = "الفواتير";
                btnBook.RightToLeft = RightToLeft.No;
                btnBook.Text = "الكتب";
                btnCustomer.RightToLeft = RightToLeft.No;
                btnCustomer.Text = "العملاء";
                btnEmployee.RightToLeft = RightToLeft.No;
                btnEmployee.Text = "الموظفين";
                btnMain.RightToLeft = RightToLeft.No;
                btnMain.Text = "الرئيسية";
                btnReports.RightToLeft = RightToLeft.No;
                btnReports.Text = "التقارير";
                btnBorrow.RightToLeft= RightToLeft.No;
                btnBorrow.Text = "الاستعارة";
                btnSrudent.RightToLeft= RightToLeft.No;
                btnSrudent.Text = "الطلاب";
            }
        }

        private void pnlView_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
