using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
namespace library_managment.MyControls
{
    public partial class myScannercs : UserControl
    {
        FilterInfoCollection filterinfcoll;
        VideoCaptureDevice videocapture;
        
        public myScannercs()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            videocapture = new VideoCaptureDevice(filterinfcoll[comCamera.SelectedIndex].MonikerString);
            videocapture.NewFrame += Videocapture_NewFrame;
            videocapture.Start();
        }

        private void myScannercs_Load(object sender, EventArgs e)
        {
            filterinfcoll = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterinfcoll)
                comCamera.Items.Add(device.Name);
            comCamera.SelectedIndex = 0;
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
                        txtBarCode.Text = result.ToString();
                    }));
                    if (videocapture.IsRunning)
                    {
                        videocapture.Stop();
                    }
                }
            }
            catch (Exception)
            {


            }

            picScan.Image = bitmap;
        }

        public void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
