namespace Police_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            
        }

        private void report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report rp = new Report();
            rp.ShowDialog();
            this.Close();
        }

        private void upload_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {

        }

        private void info_Click(object sender, EventArgs e)
        {

        }
    }
}