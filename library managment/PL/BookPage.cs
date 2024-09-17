using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_managment.PL.Dialogs;
using library_managment.DAL;
using library_managment.MyControls;
using System.Data.SqlClient;
using System.IO;
namespace library_managment.PL
{
    public partial class BookPage : Form
    {
        int currentID = 0;
        int currentIndex = -1;
        DataTable dataTable = new DataTable();
        public BookPage()
        {
            InitializeComponent();
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد اضافة هذه الكتاب", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                AddEditBook addEditBook = new AddEditBook();
                addEditBook.ShowDialog();
                load();
                
            }

        }
        void load()
        {
            pnlDisplay.Controls.Clear();
            currentID = 0;
            BookItem.i = 0;
            dataTable = DBMethods.getData("get_all_books", null);
            foreach(DataRow row in dataTable.Rows)
            {
                BookItem bookItem = new BookItem();
                byte[] bytes = (byte[])row["cover"];
                bookItem.setData(bytes, row["name"].ToString());
                pnlDisplay.Controls.Add(bookItem);
                bookItem.Size = new Size(170, 210);
                bookItem.picCover.Click += (ss, ee) =>
                {
                    currentID = (int)row["id"];
                    currentIndex = bookItem.index;
                    foreach(BookItem book in pnlDisplay.Controls)
                    {
                        book.pnlBack.BorderColor = Color.White;
                    }
                    bookItem.pnlBack.BorderColor = Color.FromArgb(100, 88, 255);
                };
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(currentID != 0)
            {
                SqlParameter[] sp = new SqlParameter[1];
                sp[0] = new SqlParameter("id", currentID);
                DBMethods.implementQuery("delete_book", sp);
                load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentIndex != -1)
            {
                AddEditBook addEditBook = new AddEditBook();
                addEditBook.btnAddEdit.Text = "تعديل";
                addEditBook.bookID = currentID;
                addEditBook.txtName .Text= dataTable.Rows[currentIndex]["name"].ToString();
                addEditBook.txtAuthor.Text = dataTable.Rows[currentIndex]["author"].ToString();
                addEditBook.txtPublisher.Text = dataTable.Rows[currentIndex]["publisher"].ToString();
                addEditBook.txtPrise.Text = dataTable.Rows[currentIndex]["prise"].ToString();
                addEditBook.nudQuantity.Value =(int) dataTable.Rows[currentIndex]["quantity"];
                addEditBook.nudNoPages.Value = (int)dataTable.Rows[currentIndex]["nopage"];
                addEditBook.txtBarCode.Text = dataTable.Rows[currentIndex]["bar_code"].ToString();
                addEditBook.txtName.Text = dataTable.Rows[currentIndex]["name"].ToString();
                byte[] bytes = (byte[])dataTable.Rows[currentIndex]["cover"];
                MemoryStream ma = new MemoryStream();
                ma.Write(bytes, 0, bytes.Length);
                addEditBook.picCover.Image = Image.FromStream(ma);
                addEditBook.ShowDialog();
                load();

            }

        }
    }
}
