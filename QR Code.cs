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
using ZXing;
using System.IO;

namespace Contact_Tracing_App
{

    public partial class QR_Code : Form
    {
        public static DataTable dtbl;
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
            captureDevice.Start();
            timerscan.Start();

            string file = "D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text";
            if (Directory.Exists(Path.GetDirectoryName(file)))
            {
                File.Delete(file);
            }
            this.QRscannedinfoDatagridview.DataSource = null;
            this.QRscannedinfoDatagridview.Rows.Clear();
            //   if (System.IO.File.Exists("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text"))
            //      System.IO.File.Delete("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text"));
            //  if (File.Exists("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text"))
            // {
            //     File.Delete("QR Scan to Read.Text");
            // }
        }
        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            camerapicbox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }
        }

        private void TimerWebcam(object sender, EventArgs e)
        {
            if (camerapicbox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)camerapicbox.Image);
                if (result != null)
                {
                    StreamWriter file = File.AppendText("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text");
                    file.Write(result.ToString());
                    file.Close();

                    StreamReader inputFile = new StreamReader("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text");
                    var lines = File.ReadAllLines("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes Read\\QR Scan to Read.Text");

                    var list = new List<string>();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        //var values = lines[i].Split("/t");
                        list.Add(lines[i]);
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.AddRange(new DataColumn[]
                    {
                new DataColumn("UUID", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Address", typeof(string)),
                new DataColumn("Contact Number", typeof(string)),
                new DataColumn("Age", typeof(string)),
                new DataColumn("Sex", typeof(string)),
                new DataColumn("Temperature", typeof(string)),
                new DataColumn("First Dose", typeof(string)),
                new DataColumn("Second Dose", typeof(string)),
                new DataColumn("Have had contact with someone who tested postive", typeof(string)),
                new DataColumn("Fever", typeof(string)),
                new DataColumn("Loss of Taste", typeof(string)),
                new DataColumn("Loss of Smell", typeof(string)),
                new DataColumn("Date Track", typeof(string)),
                    }); ;
                    foreach (var row in list)
                    {
                        var values = row.Split("),(");
                        var output = new List<string>();
                        for (int j = 0; j < values.Length; j++)
                        {
                            var data = values[j].Substring(values[j].IndexOf(",") + 1);
                            values[j] = data;
                        }

                        dt.Rows.Add(values);
                    }

                    QRscannedinfoDatagridview.DataSource = dt;
                    convertDate();
                    inputFile.Close();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.SignalToStop();
                    }

                    timerscan.Stop();
                }

            }
        }
        private void convertDate()
        {
            int count = QRscannedinfoDatagridview.Rows.Count;
            count = count - 1;
            for (int i = 0; i < count; i++)
            {
                var date = QRscannedinfoDatagridview[13, i].Value;
                date = date.ToString().Replace(@"),", string.Empty);
                //var dateTrack = Convert.ToDateTime(date);
                QRscannedinfoDatagridview[13, i].Value = date;
            }
            dtbl = (DataTable)QRscannedinfoDatagridview.DataSource;
        }


        private void QRscannedinfoDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proceedbtn_Click(object sender, EventArgs e)
        {
            QRCODELBL form = new QRCODELBL();
            form.Show();
            QRscannedinfoDatagridview.Rows[0].Cells[0].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[1].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[2].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[3].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[4].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[5].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[6].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[7].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[8].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[9].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[10].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[11].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[12].Value.ToString();
        }
    }
}
