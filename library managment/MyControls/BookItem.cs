using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace library_managment.MyControls
{
    public partial class BookItem : UserControl
    {
        public static int i = 0;
        public int index;
        public BookItem()
        {
            InitializeComponent();
        }
        public void setData(byte[] bytes,string name)
        {
            index = i;
            MemoryStream ma = new MemoryStream();
            ma.Write(bytes, 0, bytes.Length);
            picCover.Image = Image.FromStream(ma);
            lblName.Text = name;
            i++;
        }
    }
}
