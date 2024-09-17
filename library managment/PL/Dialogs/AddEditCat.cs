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
    public partial class AddEditCat : Form
    {
        public AddEditCat()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dgvCatigory.DataSource = DBMethods.getData("get_all_cat",null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
            sp[0].Value = txtName.Text;
            DBMethods.implementQuery("add_cat", sp);
            load();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
            sp[0].Value = txtName.Text;
            sp[1] = new SqlParameter("id", SqlDbType.Int);
            sp[1].Value = dgvCatigory.SelectedRows[0].Cells[0].Value;
            DBMethods.implementQuery("edit_cat", sp);
            load();
        }

        private void dgvCatigory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCatigory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("id", SqlDbType.Int);
            sp[0].Value = dgvCatigory.SelectedRows[0].Cells[0].Value;
            DBMethods.implementQuery("delete_cat", sp);
            load();
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
