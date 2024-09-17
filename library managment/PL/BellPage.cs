using System;
using System.Collections;
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
using AForge.Video.DirectShow;
using ZXing;
using library_managment.Reports;
using DevExpress.XtraReports.UI;
using System.Media;
namespace library_managment.PL
{
    public partial class BellPage : Form
    {
        SoundPlayer player = new SoundPlayer(library_managment.Properties.Resources.scan);
        FilterInfoCollection filterinfcoll;
        VideoCaptureDevice videocapture;

        public BellPage()
        {
            InitializeComponent();
            load();
            comType.Focus();
            
        }
        void load()
        {
            comCustomer.DisplayMember = "name";
            comCustomer.ValueMember = "id";
            comCustomer.DataSource = DBMethods.getData("get_all_customer", null);
            comEmployee.DisplayMember = "name";
            comEmployee.ValueMember = "id";
            comEmployee.DataSource = DBMethods.getData("get_all_employees", null);
            comBook.DisplayMember = "name";
            comBook.ValueMember = "id";
            comBook.DataSource = DBMethods.getData("get_all_books", null);
            filterinfcoll = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterinfcoll)
                comCamera.Items.Add(device.Name);
            comCamera.SelectedIndex = 0;
           

        }

        private void BellPage_Load(object sender, EventArgs e)
        {
            comType.Focus();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد اضافة هذه الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                double amount = Convert.ToDouble(txtPrice.Text) * (double)nudQuantity.Value;
                string[] row = new string[4];
                row[0] = comBook.SelectedValue.ToString();
                row[1] = comBook.Text;
                row[3] = amount.ToString();
                row[2] = nudQuantity.Value.ToString();
                dgvbooks.Rows.Add(row);
                total();
            }
            
        }

        private void comBook_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("id", comBook.SelectedValue);
            DataTable dt = DBMethods.getData("get_price_book", sp);
            DataRow r  = dt.Rows[0];
            txtPrice.Text = r["prise"].ToString();
        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                comBook.SelectedValue = txtBookId.Text;
            }
            catch (Exception ex) { }
                
                

        }
        void total()
        {
            double sum = 0;
            for(int i = 0; i < dgvbooks.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvbooks.Rows[i].Cells[3].Value);
            }
            lblTotal.Text = sum.ToString();
        }

        private void dgvbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4){
                dgvbooks.Rows.RemoveAt(e.RowIndex);
                total();
            }
        }

        private void comType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comType.SelectedIndex == 0 || comType.SelectedIndex == 2) {
                comCustomer.DisplayMember = "name";
                comCustomer.ValueMember = "id";
                comCustomer.DataSource = DBMethods.getData("get_all_customer", null);
                lblCSName.Text = "اسم العميل";
            }
            else
            {
                comCustomer.DisplayMember = "name";
                comCustomer.ValueMember = "id";
                comCustomer.DataSource = DBMethods.getData("get_all_suppliers", null);
                lblCSName.Text = "اسم المورد";

            }
        }

        private void txtBar_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(videocapture == null)
            {
                videocapture = new VideoCaptureDevice(filterinfcoll[comCamera.SelectedIndex].MonikerString);
                videocapture.NewFrame += Videocapture_NewFrame;
            }
            if (videocapture != null && !videocapture.IsRunning)
            {
                btnRun.Text = "إيقاف مسح BarCode";
                videocapture.Start();
            }
            else if (videocapture != null && videocapture.IsRunning)
            {
                btnRun.Text = "مسح BarCode";

                videocapture.Stop();
            }
        }
        private void Videocapture_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            BarcodeReader reader = new BarcodeReader();
            try
            {
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    player.Play();
                    txtBarCode.Invoke(new MethodInvoker(delegate ()
                    {
                        txtBarCode.Text = result.ToString();
                        SqlParameter[] sp = new SqlParameter[1];
                        sp[0] = new SqlParameter("bar_code", result.ToString());
                        DataTable dataTable = DBMethods.getData("get_book_by_code", sp);
                        DataRow r = dataTable.Rows[0];
                        txtBookId.Text = r["id"].ToString();
                    }));
                    
                }
            }
            catch (Exception)
            {


            }

            picScan.Image = bitmap;
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dataRow;
            DialogResult result = MessageBox.Show("هل تريد حفظ هذه الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                
                if (comType.SelectedIndex == 0)
                {
                    SqlParameter[] sp = new SqlParameter[6];
                    sp[0] = new SqlParameter("id_customer", comCustomer.SelectedValue);
                    sp[1] = new SqlParameter("id_employee", comEmployee.SelectedValue);
                    sp[2] = new SqlParameter("date", DateTime.Now.Date);
                    sp[3] = new SqlParameter("type", comType.SelectedIndex);
                    sp[4] = new SqlParameter("tpay", comPType.SelectedIndex);
                    sp[5] = new SqlParameter("price", txtPrice.Text);
                    DBMethods.implementQuery("add_buy_bell", sp);
                    dt = DBMethods.getData("get_last_bell", null);
                    dataRow = dt.Rows[0];
                    for (int i = 0; i < dgvbooks.Rows.Count; i++)
                    {
                        SqlParameter[] sp1 = new SqlParameter[4];
                        sp1[0] = new SqlParameter("id_book", dgvbooks.Rows[i].Cells[0].Value);
                        sp1[1] = new SqlParameter("prise", dgvbooks.Rows[i].Cells[3].Value);
                        sp1[2] = new SqlParameter("quantity", dgvbooks.Rows[i].Cells[2].Value);
                        sp1[3] = new SqlParameter("id_bell", dataRow["id"]);
                        DBMethods.implementQuery("add_puy", sp1);
                    }

                }
                else if (comType.SelectedIndex == 1)
                {
                    SqlParameter[] sp = new SqlParameter[6];
                    sp[0] = new SqlParameter("id_supplier", comCustomer.SelectedValue);
                    sp[1] = new SqlParameter("id_employee", comEmployee.SelectedValue);
                    sp[2] = new SqlParameter("date", DateTime.Now.Date);
                    sp[3] = new SqlParameter("type", comType.SelectedIndex);
                    sp[4] = new SqlParameter("tpay", comPType.SelectedIndex);
                    sp[5] = new SqlParameter("price", txtPrice.Text);
                    DBMethods.implementQuery("add_sell_bell", sp);
                    dt = DBMethods.getData("get_last_bell", null);
                    dataRow = dt.Rows[0];
                    for (int i = 0; i < dgvbooks.Rows.Count; i++)
                    {
                        SqlParameter[] sp1 = new SqlParameter[4];
                        sp1[0] = new SqlParameter("id_book", dgvbooks.Rows[i].Cells[0].Value);
                        sp1[1] = new SqlParameter("prise", dgvbooks.Rows[i].Cells[3].Value);
                        sp1[2] = new SqlParameter("quantity", dgvbooks.Rows[i].Cells[2].Value);
                        sp1[3] = new SqlParameter("id_bell", dataRow["id"]);
                        DBMethods.implementQuery("add_sell", sp1);
                    }
                }
                else
                {
                    SqlParameter[] sp = new SqlParameter[6];
                    sp[0] = new SqlParameter("id_customer", comCustomer.SelectedValue);
                    sp[1] = new SqlParameter("id_employee", comEmployee.SelectedValue);
                    sp[2] = new SqlParameter("date", DateTime.Now.Date);
                    sp[3] = new SqlParameter("type", comType.SelectedIndex);
                    sp[4] = new SqlParameter("tpay", comPType.SelectedIndex);
                    sp[5] = new SqlParameter("price", txtPrice.Text);
                    DBMethods.implementQuery("add_buy_bell", sp);
                    dt = DBMethods.getData("get_last_bell", null);
                    dataRow = dt.Rows[0];
                    for (int i = 0; i < dgvbooks.Rows.Count; i++)
                    {
                        SqlParameter[] sp1 = new SqlParameter[4];
                        sp1[0] = new SqlParameter("id_book", dgvbooks.Rows[i].Cells[0].Value);
                        sp1[1] = new SqlParameter("prise", dgvbooks.Rows[i].Cells[3].Value);
                        sp1[2] = new SqlParameter("quantity", dgvbooks.Rows[i].Cells[2].Value);
                        sp1[3] = new SqlParameter("id_bell", dataRow["id"]);
                        DBMethods.implementQuery("add_borrow", sp1);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter ("type", comType.SelectedIndex);
            DataTable dt = DBMethods.getData("get_last_cbell", sp);
            DataRow dataRow = dt.Rows[0];
            if (comType.SelectedIndex == 0)
            {
                RBuyBell rBuyBell = new RBuyBell();
                rBuyBell.Parameters[0].Value = dataRow["id"];
                rBuyBell.ShowPreview();
            }
            else if(comType.SelectedIndex == 2)
            {
                RBorrowBell rBorrowBell = new RBorrowBell();
                rBorrowBell.Parameters[0].Value = dataRow["id"];
                rBorrowBell.ShowPreview();
            }
            else
            {
                RSellBell rRSell = new RSellBell();
                rRSell.Parameters[0].Value = dataRow["id"];
                rRSell.ShowPreview();
            }
            
        }

        private void comType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comPType.Focus();
            }
        }

        private void comPType_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                
                comCustomer.Focus();
            }
        }
        
    }
}
