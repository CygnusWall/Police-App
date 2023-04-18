using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            

        }



        private void btnChangeCountry_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnChangeCountry.Top = (ClientSize.Height - btnChangeCountry.Height) / 2;

            btnChangeCountry.Left = (ClientSize.Width - btnChangeCountry.Width) / 2;

            
        }

      
    }
}
