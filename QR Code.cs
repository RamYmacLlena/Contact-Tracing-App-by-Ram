using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Contact_Tracing_App
{
    public partial class QR_Code : Form
    {
        public QR_Code()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void QR_Code_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CameraComboBoxDevice.Items.Add(filterInfo.Name);
            CameraComboBoxDevice.SelectedIndex = 0;
        }

        private void Scanbtn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CameraComboBoxDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            camerapicbox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void TimerWebcam(object sender, EventArgs e)
        {
            if (camerapicbox.Image != null)
            {
                

            }
        }
    }
}
