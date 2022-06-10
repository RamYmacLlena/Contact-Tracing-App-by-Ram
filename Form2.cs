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
                 (temperaturetxtbox.Text == "")  
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
                        file.WriteLine("First Dose : " + grpboxfirstdose.Text);
                        file.WriteLine("Second Dose : " + grpboxseconddose.Text);
                        file.WriteLine("Have had contact with someone who tested postive? " + grpboxtestedpstv.Text);
                        file.WriteLine(haveyouexprnlbl.Text + " ");
                        file.WriteLine("1. Fever? " + grpboxfever.Text);
                        file.WriteLine("2. Loss of Taste? " + grpboxlossoftaste.Text);
                        file.WriteLine("3. Loss of Smell? " + grpboxlossofsmell.Text);
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
