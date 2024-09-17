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
using library_managment.Reports;
using DevExpress.XtraReports.UI;
namespace library_managment.PL
{
    public partial class ReportsPage : Form
    {
        public ReportsPage()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            comCustomer.DisplayMember = "name";
            comCustomer.ValueMember = "id";
            comCustomer.DataSource = DBMethods.getData("get_all_customer", null);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            RCusBell rCusBell = new RCusBell();
            rCusBell.Parameters[0].Value = comCustomer.SelectedValue;
            rCusBell.Parameters[1].Value = comType.SelectedIndex;
            rCusBell.ShowPreview();
            
        }

        private void ReportsPage_Activated(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
