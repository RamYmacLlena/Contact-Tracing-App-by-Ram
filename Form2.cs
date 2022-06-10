using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class ContactTracingAppScreeningInfo : Form
    {
        public ContactTracingAppScreeningInfo()
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
                        StreamWriter file = File.AppendText("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");
                        file.WriteLine("Name : " + nametxtbox.Text);
                        file.WriteLine("Address : " + addresstxtbox.Text);
                        file.WriteLine("Contact Number: " + contactnotxtbox.Text);
                        file.WriteLine("Age : " + agetxtbox.Text);
                        file.WriteLine("Sex : " + sextxtbox.Text);
                        file.WriteLine("Temperature : " + temperaturetxtbox.Text);
                        file.WriteLine("First Dose : " + FirstDoseAnswer);
                        file.WriteLine("Second Dose : " + SecondDoseAnswer);
                        file.WriteLine("Have had contact with someone who tested postive? " + TestPositiveAnswer);
                        file.WriteLine(haveyouexprnlbl.Text + " ");
                        file.WriteLine("1. Fever? " + FeverAnswer);
                        file.WriteLine("2. Loss of Taste? " + LossofTasteAnswer);
                        file.WriteLine("3. Loss of Smell? " + LossofSmellAnswer);
                        file.Close();
            }
            {
                MessageBox.Show("Registration Successful!");
            }
            ContactTracingAppScreeningInfo NewForm = new ContactTracingAppScreeningInfo();
            NewForm.Show();
            this.Dispose(false);

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
    }
}
