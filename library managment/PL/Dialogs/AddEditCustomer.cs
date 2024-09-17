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
using library_managment.DAL;
namespace library_managment.PL.Dialogs
{
    public partial class AddEditCustomer : Form
    {
        public int id = 0;
        public AddEditCustomer()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                SqlParameter[] sp = new SqlParameter[3];
                sp[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
                sp[0].Value = txtName.Text;
                sp[1] = new SqlParameter("phone", SqlDbType.NVarChar, 13);
                sp[1].Value = txtPhone.Text;
                sp[2] = new SqlParameter("address", SqlDbType.NVarChar, 200);
                sp[2].Value = txtAddress.Text;
                DBMethods.implementQuery("add_customer",sp);

            }
            else
            {
                SqlParameter[] sp = new SqlParameter[4];
                sp[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
                sp[0].Value = txtName.Text;
                sp[1] = new SqlParameter("phone", SqlDbType.NVarChar, 13);
                sp[1].Value = txtPhone.Text;
                sp[2] = new SqlParameter("address", SqlDbType.NVarChar, 200);
                sp[2].Value = txtAddress.Text;
                sp[3] = new SqlParameter("id", SqlDbType.Int);
                sp[3].Value = id;
                DBMethods.implementQuery("edit_customer", sp);
            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
