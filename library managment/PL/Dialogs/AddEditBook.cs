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
using library_managment.PL.Dialogs;
using System.IO;
using AForge.Video.DirectShow;
using ZXing;
using System.Media;
namespace library_managment.PL.Dialogs
{
    
    public partial class AddEditBook : Form
    {
        SoundPlayer player = new SoundPlayer(library_managment.Properties.Resources.scan);
        FilterInfoCollection filterinfcoll;
        VideoCaptureDevice videocapture;
        public int bookID = 0;
        public AddEditBook()
        {
            InitializeComponent();
            load();
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            AddEditCat addEditCat = new AddEditCat();
            addEditCat.ShowDialog();
            load();

        }
        void load()
        {
            comCats.DisplayMember = "name";
            comCats.ValueMember = "id";
            comCats.DataSource = DBMethods.getData("get_all_cat", null);
            filterinfcoll = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterinfcoll)
                comCamera.Items.Add(device.Name);
            comCamera.SelectedIndex = 0;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if(bookID == 0)
            {
                MemoryStream ma = new MemoryStream();
                picCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                var _cover = ma.ToArray();
                SqlParameter[] sp = new SqlParameter[9];
                sp[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
                sp[0].Value = txtName.Text;
                sp[1] = new SqlParameter("author", SqlDbType.NVarChar, 50);
                sp[1].Value = txtAuthor.Text;
                sp[2] = new SqlParameter("publisher", SqlDbType.NVarChar, 50);
                sp[2].Value = txtPublisher.Text;
                sp[3] = new SqlParameter("prise", SqlDbType.SmallMoney);
                sp[3].Value = txtPrise.Text;
                sp[4] = new SqlParameter("id_cat", SqlDbType.Int);
                sp[4].Value = comCats.SelectedValue;
                sp[5] = new SqlParameter("quantity", SqlDbType.Int);
                sp[5].Value = nudQuantity.Value;
                sp[6] = new SqlParameter("nopage", SqlDbType.Int);
                sp[6].Value = nudNoPages.Value;
                sp[7] = new SqlParameter("cover", SqlDbType.Image);
                sp[7].Value = _cover;
                sp[8] = new SqlParameter("bar_code", SqlDbType.NVarChar, 50);
                sp[8].Value = txtBarCode.Text;
                DBMethods.implementQuery("add_book", sp);
            }
            else
            {
                MemoryStream ma = new MemoryStream();
                picCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                var _cover = ma.ToArray();
                SqlParameter[] sp = new SqlParameter[10];
                sp[0] = new SqlParameter("name", SqlDbType.NVarChar, 50);
                sp[0].Value = txtName.Text;
                sp[1] = new SqlParameter("author", SqlDbType.NVarChar, 50);
                sp[1].Value = txtAuthor.Text;
                sp[2] = new SqlParameter("publisher", SqlDbType.NVarChar, 50);
                sp[2].Value = txtPublisher.Text;
                sp[3] = new SqlParameter("prise", SqlDbType.SmallMoney);
                sp[3].Value = txtPrise.Text;
                sp[4] = new SqlParameter("id_cat", SqlDbType.Int);
                sp[4].Value = comCats.SelectedValue;
                sp[5] = new SqlParameter("quantity", SqlDbType.Int);
                sp[5].Value = nudQuantity.Value;
                sp[6] = new SqlParameter("nopage", SqlDbType.Int);
                sp[6].Value = nudNoPages.Value;
                sp[7] = new SqlParameter("cover", SqlDbType.Image);
                sp[7].Value = _cover;
                sp[8] = new SqlParameter("bar_code", SqlDbType.NVarChar, 50);
                sp[8].Value = txtBarCode.Text;
                sp[9] = new SqlParameter("id", SqlDbType.Int);
                sp[9].Value = bookID;
                DBMethods.implementQuery("edit_book", sp);
            }
            

        }

        private void picCover_Click(object sender, EventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if (result == DialogResult.OK)
            {
                picCover.Image = Image.FromFile(dia.FileName);
            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            if (videocapture != null && videocapture.IsRunning)
            {
                try
                {
                    videocapture.Stop();

                }catch(Exception ex) { }
            }
            player.Stop();
            this.Close();
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

                    txtBarCode.Invoke(new MethodInvoker(delegate ()
                    {
                        player.Play();
                        txtBarCode.Text = result.ToString();

                    }));
                }
            }
            catch (Exception)
            {


            }

            picScan.Image = bitmap;
        }

        private void txtPrise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.' && !txtPrise.Text.Contains(".")))
            {

                e.Handled = true;
            }
        }
        //bool InputValid()
        //{
        //    if(txtPrise.Text=="")
        //    {

        //    }
        //}
    }
}
