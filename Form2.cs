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
            if ((nametxtbox.Text == "") ||
                 (addresstxtbox.Text == "") ||
                 (contactnotxtbox.Text == "") ||
                 (agetxtbox.Text == "") ||
                 (sextxtbox.Text == "") ||
                 (temperaturetxtbox.Text == "") ||
                 ((!firstdoseyeschckbx.Checked) && (!firstdosenochckbx.Checked)) ||
                 ((!seconddoseyeschckbx.Checked) && (!seconddosenochckbx.Checked)) ||
                 ((!testpostyeschckbox.Checked) && (!testpostnochckbox.Checked)) ||
                 ((!feveryeschckbox.Checked) && (!fevernochckbox.Checked)) ||
                 ((!lossoftasteyeschckbox.Checked) && (!lossoftastenochckbox.Checked)) ||
                 ((!lossofsmellyeschckbox.Checked) && (!lossofsmellnochckbox.Checked))
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
                        file.WriteLine("First Dose : " + firstdoseyeschckbx.Text);
                        file.WriteLine("First Dose : " + firstdosenochckbx.Text);
                        file.WriteLine("Second Dose : " + seconddoseyeschckbx.Text);
                        file.WriteLine("Second Dose : " + seconddosenochckbx.Text);
                        file.WriteLine("Have had contact with someone who tested postive? " + testpostyeschckbox.Text);
                        file.WriteLine("Have had contact with someone who tested postive? " + testpostnochckbox.Text);
                        file.WriteLine(haveyouexprnlbl.Text + " ");
                        file.WriteLine("1. Fever? " + feveryeschckbox);
                        file.WriteLine("1. Fever? " + fevernochckbox);
                        file.WriteLine("2. Loss of Taste? " + lossoftasteyeschckbox);
                        file.WriteLine("2. Loss of Taste? " + lossoftastenochckbox);
                        file.WriteLine("3. Loss of Smell? " + lossofsmellyeschckbox);
                        file.WriteLine("3. Loss of Smell? " + lossofsmellnochckbox);
                        file.Close();
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
            firstdoseyeschckbx.Checked = false;
            firstdosenochckbx.Checked = false;
            seconddoseyeschckbx.Checked = false;
            seconddosenochckbx.Checked = false;
            testpostyeschckbox.Checked = false;
            testpostnochckbox.Checked = false;
            feveryeschckbox.Checked = false;
            fevernochckbox.Checked = false;
            lossoftasteyeschckbox.Checked = false;
            lossoftastenochckbox.Checked = false;
            lossofsmellyeschckbox.Checked = false;
            lossofsmellnochckbox.Checked = false;
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

        private void firstdoseyeschckbx_CheckedChanged(object sender, EventArgs e)
        {
            this.firstdosenochckbx.Enabled = !firstdoseyeschckbx.Checked;
        }

        private void firstdosenochckbx_CheckedChanged(object sender, EventArgs e)
        {
            this.firstdoseyeschckbx.Enabled = !firstdosenochckbx.Checked;
        }

        private void seconddoseyeschckbx_CheckedChanged(object sender, EventArgs e)
        {
            this.seconddosenochckbx.Enabled = !seconddoseyeschckbx.Checked;
        }

        private void seconddosenochckbx_CheckedChanged(object sender, EventArgs e)
        {
            this.seconddoseyeschckbx.Enabled = !seconddosenochckbx.Checked;
        }

        private void testpostyeschckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.testpostnochckbox.Enabled = !testpostyeschckbox.Checked;
        }

        private void testpostnochckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.testpostyeschckbox.Enabled = !testpostnochckbox.Checked;
        }

        private void feveryeschckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.fevernochckbox.Enabled = !feveryeschckbox.Checked;
        }

        private void fevernochckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.feveryeschckbox.Enabled = !fevernochckbox.Checked;
        }

        private void lossoftasteyeschckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.lossoftastenochckbox.Enabled = !lossoftasteyeschckbox.Checked;
        }

        private void lossoftastenochckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.lossoftasteyeschckbox.Enabled = !lossoftastenochckbox.Checked;
        }

        private void lossofsmellyeschckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.lossofsmellnochckbox.Enabled = !lossofsmellyeschckbox.Checked;
        }

        private void lossofsmellnochckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.lossofsmellyeschckbox.Enabled = !lossofsmellnochckbox.Checked;
        }
    }
}
