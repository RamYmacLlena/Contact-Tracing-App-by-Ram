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
            StreamWriter file = File.AppendText("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");
            file.WriteLine("Name : " + nametxtbox.Text);
            file.WriteLine("Address : " + addresstxtbox.Text);
            file.WriteLine("Contact Number: " + contactnotxtbox.Text);
            file.WriteLine("Age : " + agetxtbox.Text);
            file.WriteLine("Sex : " + sextxtbox.Text);
            file.WriteLine("Temperature : " + temperaturetxtbox.Text);
            file.WriteLine("First Dose : " + yescheckbox1.Text);
            file.WriteLine("First Dose : " + nocheckbox1.Text);
            file.WriteLine("Second Dose : " + yescheckbox2.Text);
            file.WriteLine("Second Dose : " + nocheckbox2.Text);

            file.Close();
        }

        private void firstdoselbl_Click(object sender, EventArgs e)
        {

        }

        private void ContactTracingAppScreeningInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
