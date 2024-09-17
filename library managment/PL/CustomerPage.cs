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
using library_managment.PL.Dialogs;
using System.Data.SqlClient;

namespace library_managment.PL
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dgvCustomer.DataSource = DBMethods.getData("get_all_customer",null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditCustomer addEditCustomer = new AddEditCustomer();
            addEditCustomer.ShowDialog();
            load();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEditCustomer addEditCustomer = new AddEditCustomer();
            addEditCustomer.id = (int)dgvCustomer.SelectedRows[0].Cells[0].Value;
            addEditCustomer.txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            addEditCustomer.txtPhone.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            addEditCustomer.txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
            addEditCustomer.btnAddEdit.Text = "تعديل";
            addEditCustomer.ShowDialog();
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("id", SqlDbType.Int);
            sp[0].Value = dgvCustomer.SelectedRows[0].Cells[0].Value;
            DBMethods.implementQuery("delete_customer", sp);
            load();
        }
    }
}
