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
            QRCODELBL form = new QRCODELBL();
            form.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeeDataRecodsbtn_Click(object sender, EventArgs e)
        {
            RecordsForm form = new RecordsForm();
            form.Show();
        }
    }
}