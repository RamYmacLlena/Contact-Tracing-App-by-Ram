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
                new DataColumn("UUID", typeof(string))
            }); 
            foreach (var row in list)
            {
                var trace = new[]
                {
                    row,
                };
                for (int j = 0; j < trace.Length; j++)
                {
                    var newRow = dt.NewRow();
                    dt.Rows.Add(trace[j]);
                    
                }
                   
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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader("D:\\DESKTOP\\Ram Ymac\\EDUCATION\\OOP\\Contact Tracing App Infos\\Contact Tracing Information.txt");

            label1.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }
    }
}
