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
using DevExpress.ClipboardSource.SpreadsheetML;
using library_managment.DAL;
using library_managment.PL.Dialogs;

namespace library_managment.PL
{
    public partial class EmployeePage : Form
    {
        
        public EmployeePage()
        {
            InitializeComponent();

            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditEmplo addEditEmplo = new AddEditEmplo();
            addEditEmplo.ShowDialog();
            load();
        }
        void load()
        {
           
            dgvEmployee.DataSource = DBMethods.getData("get_all_employees", null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEditEmplo addEditEmplo = new AddEditEmplo();
            addEditEmplo.id = (int) dgvEmployee.SelectedRows[0].Cells[0].Value;
            addEditEmplo.txtName.Text = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
            addEditEmplo.txtPhone.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
            addEditEmplo.txtJob.Text = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
            addEditEmplo.txtSalary.Text = dgvEmployee.SelectedRows[0].Cells[3].Value.ToString();
            addEditEmplo.txtAddress.Text = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();
            addEditEmplo.dtbDateTime.Value =Convert.ToDateTime( dgvEmployee.SelectedRows[0].Cells[6].Value);
            addEditEmplo.txtGuearantee.Text = dgvEmployee.SelectedRows[0].Cells[7].Value.ToString();
            addEditEmplo.comGender.SelectedIndex =Convert.ToInt32( dgvEmployee.SelectedRows[0].Cells[8].Value);
            addEditEmplo.btnAddEdit.Text = "تعديل";
            addEditEmplo.ShowDialog();
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("id",SqlDbType.Int);
            sp[0].Value = dgvEmployee.SelectedRows[0].Cells[0].Value;
            DBMethods.implementQuery("delete_employee",sp);
            load();
        }
    }
}
