namespace Contact_Tracing_App
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ContactTracingAppScreeningInfo form = new ContactTracingAppScreeningInfo();
            form.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}