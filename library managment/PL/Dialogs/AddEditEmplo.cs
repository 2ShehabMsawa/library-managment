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
using System.Data.SqlClient;
namespace library_managment.PL.Dialogs
{
    public partial class AddEditEmplo : Form
    {
        public int id = 0;
        public AddEditEmplo()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                SqlParameter[] parameter = new SqlParameter[8];
                parameter[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
                parameter[0].Value = txtName.Text;
                parameter[1] = new SqlParameter("phone", SqlDbType.NVarChar, 13);
                parameter[1].Value = txtPhone.Text;
                parameter[2] = new SqlParameter("job", SqlDbType.NVarChar, 50);
                parameter[2].Value = txtJob.Text;
                parameter[3] = new SqlParameter("salary", SqlDbType.SmallMoney);
                parameter[3].Value = txtSalary.Text;
                parameter[4] = new SqlParameter("address", SqlDbType.NVarChar, 200);
                parameter[4].Value = txtAddress.Text;
                parameter[5] = new SqlParameter("bdate", SqlDbType.Date);
                parameter[5].Value = dtbDateTime.Value;
                parameter[6] = new SqlParameter("guearantee", SqlDbType.NVarChar, 80);
                parameter[6].Value = txtGuearantee.Text;
                parameter[7] = new SqlParameter("gender", SqlDbType.Bit);
                parameter[7].Value = comGender.SelectedIndex;
                DBMethods.implementQuery("add_employee", parameter);
            }
            else
            {
                SqlParameter[] parameter = new SqlParameter[9];
                parameter[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
                parameter[0].Value = txtName.Text;
                parameter[1] = new SqlParameter("phone", SqlDbType.NVarChar, 13);
                parameter[1].Value = txtPhone.Text;
                parameter[2] = new SqlParameter("job", SqlDbType.NVarChar, 50);
                parameter[2].Value = txtJob.Text;
                parameter[3] = new SqlParameter("salary", SqlDbType.SmallMoney);
                parameter[3].Value = txtSalary.Text;
                parameter[4] = new SqlParameter("address", SqlDbType.NVarChar, 200);
                parameter[4].Value = txtAddress.Text;
                parameter[5] = new SqlParameter("bdate", SqlDbType.Date);
                parameter[5].Value = dtbDateTime.Value;
                parameter[6] = new SqlParameter("guearantee", SqlDbType.NVarChar, 80);
                parameter[6].Value = txtGuearantee.Text;
                parameter[7] = new SqlParameter("gender", SqlDbType.Bit);
                parameter[7].Value = comGender.SelectedIndex;
                parameter[8] = new SqlParameter("id", SqlDbType.Int);
                parameter[8].Value = id;
                DBMethods.implementQuery("edit_employee", parameter);
            }
            
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
