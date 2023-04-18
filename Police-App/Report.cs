using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Police_App
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();


        }

        public void HOME_Click(object sender, EventArgs e)
        {
            
                Container f = new Container(); // This is bad
                f.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
