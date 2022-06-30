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
            else
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


        }



        private void clearbtn_Click(object sender, EventArgs e)
        {
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
            string UUIDtag = UUIDtxtbox.Text;
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
                TxtBoxinfo.AppendText("Name: " + nametxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Address: " + addresstxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Contact Number: " + contactnotxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Contact Number: " + contactnotxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Age: " + agetxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Sex: " + sextxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Temperature: " + temperaturetxtbox.Text);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("First Dose: " + FirstDoseAnswer);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Second Dose: " + SecondDoseAnswer);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Have you had contact with someone who tested positive? " + TestPositiveAnswer);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Fever? " + FeverAnswer);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Loss of Taste? " + LossofTasteAnswer);
                TxtBoxinfo.AppendText(Environment.NewLine);
                TxtBoxinfo.AppendText("Loss of Smell? " + LossofSmellAnswer);
                TxtBoxinfo.AppendText(Environment.NewLine);

                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(TxtBoxinfo.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                QRPICBOXGNRTR.Image = code.GetGraphic(3);


                UUIDtxtbox.Text = UUIDtag ;

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
                nametxtbox.Text = ("");
                addresstxtbox.Text = ("");
                contactnotxtbox.Text = ("");
                agetxtbox.Text = ("");
                sextxtbox.Text = ("");
                temperaturetxtbox.Text = ("");
                UUIDtxtbox.Text = ("");
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
            }
        }

        private void UUIDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
