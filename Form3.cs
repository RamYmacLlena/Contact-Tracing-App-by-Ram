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
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");
            var lines = File.ReadAllLines("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");

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
                //var trace = new[]
                //{
                //    row,
                //};
                //for (int j = 0; j < trace.Length; j++)
                //{
                //   var newRow = dt.NewRow();
                // dt.Rows.Add(trace[j]);

                //}

                //var values = row.Split(',');
                //dt.Rows.Add(row);
            }
            for (int i = 0; i < list.Count; i++)
            {
                
            }
            dataGridView1.DataSource = dt;
            //string details = string.Join(",", list);
            //label1.Text = dt[0].Item2;
            inputFile.Close();
            //dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
            //    + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");

            label1.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }
    }
}
