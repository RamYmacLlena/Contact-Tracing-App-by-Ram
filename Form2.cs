using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Contact_Tracing_App
{
    public partial class QRCODELBL : Form
    {
        public static DataTable dtbl;
        public QRCODELBL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vaccinebrandtxtbox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void submitbtn_Click(object sender, EventArgs e)
        {
            string FirstDoseAnswer = null;
            string SecondDoseAnswer = null;
            string TestPositiveAnswer = null;
            string FeverAnswer = null;
            string LossofTasteAnswer = null;
            string LossofSmellAnswer = null;

            if (rdbtnyesfrstdose.Checked)
            {
                FirstDoseAnswer = "YES";
            }
            else if (rdbtnnofrstdose.Checked)
            {
                FirstDoseAnswer = "NO";
            }

            if (rdbtnyesscnddose.Checked)
            {
                SecondDoseAnswer = "YES";
            }
            else if (rdbtnnoscnddose.Checked)
            {
                SecondDoseAnswer = "NO";
            }

            if (rdbtnyeststpstv.Checked)
            {
                TestPositiveAnswer = "YES";
            }
            else if (rdbtnnotstpstv.Checked)
            {
                TestPositiveAnswer = "NO";
            }

            if (rdbtnyesfever.Checked)
            {
                FeverAnswer = "YES";
            }
            else if (rdbtnnofever.Checked)
            {
                FeverAnswer = "NO";
            }

            if (rdbtnyeslossoftaste.Checked)
            {
                LossofTasteAnswer = "YES";
            }
            else if (rdbtnnolossoftaste.Checked)
            {
                LossofTasteAnswer = "NO";
            }

            if (rdbtnyeslossofsml.Checked)
            {
                LossofSmellAnswer = "YES";
            }
            else if (rdbtnnolossofsml.Checked)
            {
                LossofSmellAnswer = "NO";
            }


            if ((nametxtbox.Text == "") ||
                 (addresstxtbox.Text == "") ||
                 (contactnotxtbox.Text == "") ||
                 (agetxtbox.Text == "") ||
                 (sextxtbox.Text == "") ||
                 (temperaturetxtbox.Text == "") ||
                 ((!rdbtnyesfrstdose.Checked) && (!rdbtnnofrstdose.Checked)) ||
                 ((!rdbtnyesscnddose.Checked) && (!rdbtnnoscnddose.Checked)) ||
                 ((!rdbtnyeststpstv.Checked) && (!rdbtnnotstpstv.Checked)) ||
                 ((!rdbtnyesfever.Checked) && (!rdbtnnofever.Checked)) ||
                 ((!rdbtnyeslossoftaste.Checked) && (!rdbtnnolossoftaste.Checked)) ||
                 ((!rdbtnyeslossofsml.Checked) && (!rdbtnnolossofsml.Checked))
                 )
            {
                MessageBox.Show("Please answer the blank sections!");
            }
            else if (GenerateQRbtn.Enabled == false && Saveqrbtn.Enabled == false)
            {
                var tracing = new[]
            {
                    ("UUID", nametxtbox.Text + DateTime.Now.ToString("HHmmss")), ("Name", nametxtbox.Text), ("Address", addresstxtbox.Text),
                    ("Contact Number", contactnotxtbox.Text), ("Age", agetxtbox.Text),  ("Sex", sextxtbox.Text), ("Temperature", temperaturetxtbox.Text),
                    ("First Dose", FirstDoseAnswer), ("Second Dose", SecondDoseAnswer), ("Have had contact with someone who tested postive", TestPositiveAnswer),
                    ("Fever", FeverAnswer), ("Loss of Taste", LossofTasteAnswer), ("Loss of Smell", LossofSmellAnswer), ("Date", DTpicker.Text),
                };
                string details = string.Join(",", tracing);
                StreamWriter file = File.AppendText("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");
                file.WriteLine(details);

                file.Close();
                MessageBox.Show("Registration Successful!");
                QRCODELBL NewForm = new QRCODELBL();
                NewForm.Show();
                this.Dispose(false);
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Do you want to submit without a QR Code?", "OPTIONAL", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var tracing = new[]
                {
                    ("UUID", nametxtbox.Text + DateTime.Now.ToString("HHmmss")), ("Name", nametxtbox.Text), ("Address", addresstxtbox.Text),
                    ("Contact Number", contactnotxtbox.Text), ("Age", agetxtbox.Text),  ("Sex", sextxtbox.Text), ("Temperature", temperaturetxtbox.Text),
                    ("First Dose", FirstDoseAnswer), ("Second Dose", SecondDoseAnswer), ("Have had contact with someone who tested postive", TestPositiveAnswer),
                    ("Fever", FeverAnswer), ("Loss of Taste", LossofTasteAnswer), ("Loss of Smell", LossofSmellAnswer), ("Date", DTpicker.Text),
                };
                    string details = string.Join(",", tracing);
                    StreamWriter file = File.AppendText("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");
                    file.WriteLine(details);
                    //for (int i = 0; i < 14; i++)
                    //{
                    //    file.WriteLine(tracing[i]);
                    //}

                    file.Close();
                    MessageBox.Show("Registration Successful!");
                    QRCODELBL NewForm = new QRCODELBL();
                    NewForm.Show();
                    this.Dispose(false);


                }
                else if (dialogResult == DialogResult.No)
                {
                   
                }
            }


        }



        private void clearbtn_Click(object sender, EventArgs e)
        {
            UUIDtxtbox.Text = ("");
            nametxtbox.Text = ("");
            addresstxtbox.Text = ("");
            contactnotxtbox.Text = ("");
            agetxtbox.Text = ("");
            sextxtbox.Text = ("");
            temperaturetxtbox.Text = ("");
            rdbtnyesfrstdose.Checked = false;
            rdbtnnofrstdose.Checked = false;
            rdbtnyesscnddose.Checked = false;
            rdbtnnoscnddose.Checked = false;
            rdbtnyeststpstv.Checked = false;
            rdbtnnotstpstv.Checked = false;
            rdbtnyesfever.Checked = false;
            rdbtnnofever.Checked = false;
            rdbtnyeslossoftaste.Checked = false;
            rdbtnnolossoftaste.Checked = false;
            rdbtnyeslossofsml.Checked = false;
            rdbtnnolossofsml.Checked = false;
            GenerateQRbtn.Enabled = false;
            Saveqrbtn.Enabled = false;
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void firstdoselbl_Click(object sender, EventArgs e)
        {

        }

        private void ContactTracingAppScreeningInfo_Load(object sender, EventArgs e)
        {

        }

        private void MonthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void temperaturetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateQRbtn_Click(object sender, EventArgs e)
        {
            UUIDtxtbox.Text = nametxtbox.Text + DateTime.Now.ToString("HHmmss");
            string FirstDoseAnswer = null;
            string SecondDoseAnswer = null;
            string TestPositiveAnswer = null;
            string FeverAnswer = null;
            string LossofTasteAnswer = null;
            string LossofSmellAnswer = null;

            if (rdbtnyesfrstdose.Checked)
            {
                FirstDoseAnswer = "YES";
            }
            else if (rdbtnnofrstdose.Checked)
            {
                FirstDoseAnswer = "NO";
            }

            if (rdbtnyesscnddose.Checked)
            {
                SecondDoseAnswer = "YES";
            }
            else if (rdbtnnoscnddose.Checked)
            {
                SecondDoseAnswer = "NO";
            }

            if (rdbtnyeststpstv.Checked)
            {
                TestPositiveAnswer = "YES";
            }
            else if (rdbtnnotstpstv.Checked)
            {
                TestPositiveAnswer = "NO";
            }

            if (rdbtnyesfever.Checked)
            {
                FeverAnswer = "YES";
            }
            else if (rdbtnnofever.Checked)
            {
                FeverAnswer = "NO";
            }

            if (rdbtnyeslossoftaste.Checked)
            {
                LossofTasteAnswer = "YES";
            }
            else if (rdbtnnolossoftaste.Checked)
            {
                LossofTasteAnswer = "NO";
            }

            if (rdbtnyeslossofsml.Checked)
            {
                LossofSmellAnswer = "YES";
            }
            else if (rdbtnnolossofsml.Checked)
            {
                LossofSmellAnswer = "NO";
            }


            if ((nametxtbox.Text == "") ||
                 (addresstxtbox.Text == "") ||
                 (contactnotxtbox.Text == "") ||
                 (agetxtbox.Text == "") ||
                 (sextxtbox.Text == "") ||
                 (temperaturetxtbox.Text == "") ||
                 ((!rdbtnyesfrstdose.Checked) && (!rdbtnnofrstdose.Checked)) ||
                 ((!rdbtnyesscnddose.Checked) && (!rdbtnnoscnddose.Checked)) ||
                 ((!rdbtnyeststpstv.Checked) && (!rdbtnnotstpstv.Checked)) ||
                 ((!rdbtnyesfever.Checked) && (!rdbtnnofever.Checked)) ||
                 ((!rdbtnyeslossoftaste.Checked) && (!rdbtnnolossoftaste.Checked)) ||
                 ((!rdbtnyeslossofsml.Checked) && (!rdbtnnolossofsml.Checked))
                 )
            {
                MessageBox.Show("Please answer the blank sections!");
            }
            else
            {
               // ("UUID", nametxtbox.Text + DateTime.Now.ToString("HHmmss")), ("Name", nametxtbox.Text), ("Address", addresstxtbox.Text),
                //    ("Contact Number", contactnotxtbox.Text), ("Age", agetxtbox.Text),  ("Sex", sextxtbox.Text), ("Temperature", temperaturetxtbox.Text),
                //    ("First Dose", FirstDoseAnswer), ("Second Dose", SecondDoseAnswer), ("Have had contact with someone who tested postive", TestPositiveAnswer),
                 //   ("Fever", FeverAnswer), ("Loss of Taste", LossofTasteAnswer), ("Loss of Smell", LossofSmellAnswer), ("Date", DTpicker.Text),

                TxtBoxinfo.AppendText("(UUID, " + UUIDtxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(Name, " + nametxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(Address, " + addresstxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(Contact Number, " + contactnotxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(Age, " + agetxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(Sex, " + sextxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(Temperature, " + temperaturetxtbox.Text + ")");
                TxtBoxinfo.AppendText(",(First Dose, " + FirstDoseAnswer + ")");
                TxtBoxinfo.AppendText(",(Second Dose, " + SecondDoseAnswer + ")");
                TxtBoxinfo.AppendText(",(Have you had contact with someone who tested positive, " + TestPositiveAnswer + ")");
                TxtBoxinfo.AppendText(",(Fever, " + FeverAnswer + ")");
                TxtBoxinfo.AppendText(",(Loss of Taste, " + LossofTasteAnswer + ")");
                TxtBoxinfo.AppendText(",(Loss of Smell, " + LossofSmellAnswer + ")");
                TxtBoxinfo.AppendText(",(Date, " + DTpicker.Text + ")");

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(TxtBoxinfo.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                QRPICBOXGNRTR.Image = code.GetGraphic(3);

                Saveqrbtn.Enabled = true;
                GenerateQRbtn.Enabled = false;
            }
        }

        private void Saveqrbtn_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(QRPICBOXGNRTR.Width, QRPICBOXGNRTR.Height))
            {
                QRPICBOXGNRTR.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing QR Codes\\" + UUIDtxtbox.Text + ".jpeg");

                MessageBox.Show("QR Code has been saved.");
                Saveqrbtn.Enabled = false;
            }
        }

        private void UUIDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Autofillbtn_Click(object sender, EventArgs e)
        {
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

            UUIDtxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[0].Value.ToString();
            nametxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[1].Value.ToString();
            addresstxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[2].Value.ToString();
            contactnotxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[3].Value.ToString();
            agetxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[4].Value.ToString();
            sextxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[5].Value.ToString();
            temperaturetxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[6].Value.ToString();
            string FirstDoseAnswer = QRscannedinfoDatagridview.Rows[0].Cells[7].Value.ToString();
            string SecondDoseAnswer = QRscannedinfoDatagridview.Rows[0].Cells[8].Value.ToString();
            string TestPositiveAnswer = QRscannedinfoDatagridview.Rows[0].Cells[9].Value.ToString();
            string FeverAnswer = QRscannedinfoDatagridview.Rows[0].Cells[10].Value.ToString();
            string LossofTasteAnswer = QRscannedinfoDatagridview.Rows[0].Cells[11].Value.ToString();
            string LossofSmellAnswer = QRscannedinfoDatagridview.Rows[0].Cells[12].Value.ToString();

            QRscannedinfoDatagridview.Rows[0].Cells[0].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[1].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[2].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[3].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[4].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[5].Value.ToString();
            QRscannedinfoDatagridview.Rows[0].Cells[6].Value.ToString();

            if (QRscannedinfoDatagridview.Rows[0].Cells[7].Value.ToString() == "Yes")
            {
                rdbtnnofrstdose.Checked = true;
            } else
            {
                rdbtnyesfrstdose.Checked = true;
            }
            if (QRscannedinfoDatagridview.Rows[0].Cells[8].Value.ToString() == "Yes")
            {
                rdbtnnoscnddose.Checked = true;
            } else
            {
                rdbtnyesscnddose.Checked = true;
            }
            if (QRscannedinfoDatagridview.Rows[0].Cells[9].Value.ToString() == "Yes")
            {
                rdbtnyeststpstv.Checked = true;
            } else
            {
                rdbtnnotstpstv.Checked = true;
            }
            if (QRscannedinfoDatagridview.Rows[0].Cells[10].Value.ToString() == "Yes")
            {
                rdbtnyesfever.Checked = true;
            } else
            {
                rdbtnnofever.Checked = true;
            }
            if (QRscannedinfoDatagridview.Rows[0].Cells[11].Value.ToString() == "Yes")
            {
                rdbtnyeslossoftaste.Checked = true;
            } else
            {
                rdbtnnolossoftaste.Checked = true;
            }
            if (QRscannedinfoDatagridview.Rows[0].Cells[12].Value.ToString() == "Yes")
            {
                rdbtnyeslossofsml.Checked = true;
            } else
            {
                rdbtnnolossofsml.Checked = true;
            }

            GenerateQRbtn.Enabled = false;
            Saveqrbtn.Enabled = false;
        }

        private void QRscannedinfoDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            UUIDtxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[0].Value.ToString();
            nametxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[1].Value.ToString();
            addresstxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[2].Value.ToString();
            contactnotxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[3].Value.ToString();
            agetxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[4].Value.ToString();
            sextxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[5].Value.ToString();
            temperaturetxtbox.Text = QRscannedinfoDatagridview.Rows[0].Cells[6].Value.ToString();
            string FirstDoseAnswer = QRscannedinfoDatagridview.Rows[0].Cells[7].Value.ToString();
            string SecondDoseAnswer = QRscannedinfoDatagridview.Rows[0].Cells[8].Value.ToString();
            string TestPositiveAnswer = QRscannedinfoDatagridview.Rows[0].Cells[9].Value.ToString();
            string FeverAnswer = QRscannedinfoDatagridview.Rows[0].Cells[10].Value.ToString();
            string LossofTasteAnswer = QRscannedinfoDatagridview.Rows[0].Cells[11].Value.ToString();
            string LossofSmellAnswer = QRscannedinfoDatagridview.Rows[0].Cells[12].Value.ToString();

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
