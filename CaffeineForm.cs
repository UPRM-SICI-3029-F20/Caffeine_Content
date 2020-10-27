using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffeine_Content
{
    public partial class CaffeineForm : Form
    {
        public CaffeineForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close()
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://www.mayoclinic.org/healthy-lifestyle/nutrition-and-healthy-eating/in-depth/caffeine/art-20049372");
            //MessageBox.Show("Please wear a mask", "Covid-19",
                            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
