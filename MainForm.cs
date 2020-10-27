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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnDisplayCaffeine_Click(object sender, EventArgs e)
        {
            //Create an instance of the other form
            CaffeineForm otherForm = new CaffeineForm();

            // Determine the button that is selected
            // Assign corresponding info & facts to labels
            if (RdoBtnCoffeeBrewed.Checked)
            {
                otherForm.LblDrink.Text = "Brewed Coffee";
                otherForm.LblMiligrams.Text = "96";
            }
            else
                if (RdoBtnCoffeeExpresso.Checked)
            {
                otherForm.LblDrink.Text = "Expreso Coffee";
                otherForm.LblMiligrams.Text = "64";
            }
            else
                if (RdoBtnCoffeeInstant.Checked)
            {
                otherForm.LblDrink.Text = "Instant Coffee";
                otherForm.LblMiligrams.Text = "62";
            }
            else
                if (RdoBtnTeaBlack.Checked)
            {
                otherForm.LblDrink.Text = "Black Tea";
                otherForm.LblMiligrams.Text = "47";
            }
            else
                if (RdoBtnTeaGreen.Checked)
            {
                otherForm.LblDrink.Text = "Green Tea";
                otherForm.LblMiligrams.Text = "28";
            }
            else
                if (RdoBtnSodaCola.Checked)
            {
                otherForm.LblDrink.Text = "Cola Soda";
                otherForm.LblMiligrams.Text = "22";
            }
            else
                if (RdoBtnEnergyDrink.Checked)
            {
                otherForm.LblDrink.Text = "Energy Drink";
                otherForm.LblMiligrams.Text = "29";
            }
            else
                if (RdoBtnEnergyShot.Checked)
            {
                otherForm.LblDrink.Text = "Energy Shot";
                otherForm.LblMiligrams.Text = "215";

            }

            // Display the other from
            otherForm.ShowDialog();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
