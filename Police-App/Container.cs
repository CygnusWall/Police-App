namespace Police_App
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            loadForm(new Home());
        }

        private void report_Click(object sender, EventArgs e)
        {
            loadForm(new Report());

        }

        private void upload_Click(object sender, EventArgs e)
        {
            loadForm(new Upload());
        }

        private void help_Click(object sender, EventArgs e)
        {
            //Help help = new Help() { TopLevel = false, TopMost = true };
            //help.FormBorderStyle = FormBorderStyle.None;
            //panelMain.Controls.Add(help);
            //help.Show();

            loadForm(new Help());
        }

        private void info_Click(object sender, EventArgs e)
        {
            loadForm(new Info());
        }

        public void loadForm(object Form)
        {
            if(this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);  
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle= FormBorderStyle.None;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag= f;
            f.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadForm(new Home());
        }
    }
}