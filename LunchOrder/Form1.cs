using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        const double Tax = 7.75d;
        const double Hamburger = 6.95d;
        const double pizza = 5.95d;
        const double Salad = 4.95d;

        double AddOn = 0.0d; //To hold add on sum


        double AddOnPrice = 0.0d; //To hold Add On Price
        double Order_Total = 0.0d; //To Hold Order Total

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {


            if (radioHamburger.Checked)
                Order_Total += Hamburger; // similar to Order_Total= Order_Total + Hamburger
            if (radioPizza.Checked)
                Order_Total += pizza;
            if (radioSalad.Checked)
                Order_Total += Salad;

            Order_Total += AddOn;

            txtSubtotal.Text = "$" + String.Format("{0:0.00}", Order_Total);

            double tax = (Order_Total * 7.75d) / 100;

            txtSalesTax.Text = "$" + String.Format("{0:0.00}", tax);

            txtOrderTotal.Text = "$" + String.Format("{0:0.00}", (Order_Total + tax));


        }
        // Guy-leroc Ossebi

        private void checkLettuceTomatoOnion_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkLettuceTomatoOnion.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;

            ClearTotals();

        }
        // Guy-leroc Ossebi
        private void checkKetchupMustardMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKetchupMustardMayo.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }
        // Guy-leroc Ossebi
        private void checkFrenchfries_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFrenchfries.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }
        private void ClearTotals()
        {
            txtOrderTotal.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtSalesTax.Text = string.Empty;

            Order_Total = 0.0d;



        }
        
        private void ClearAddOns()
        {
            AddOn = 0.0d;
            checkFrenchfries.Checked = false;
            checkKetchupMustardMayo.Checked = false;
            checkLettuceTomatoOnion.Checked = false;
        }
        // Guy-leroc Ossebi
        private void radioHamburger_CheckedChanged_1(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radioHamburger.Checked)
            {
                groupBox1.Text = "Add-on items ($.75/each)";
                checkLettuceTomatoOnion.Text = "Lettuce, tomato and onions";
                checkKetchupMustardMayo.Text = "Ketchup, mustard and mayo";
                checkFrenchfries.Text = "French Fries";
                AddOnPrice = 0.75d;
            }

        }
        // Guy-leroc Ossebi
        private void radioPizza_CheckedChanged_1(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();

            if (radioPizza.Checked)
            {
                groupBox1.Text = "Add-on items ($.50/each)";

                checkLettuceTomatoOnion.Text = "Pepperoni";
                checkKetchupMustardMayo.Text = "Sausage";
                checkFrenchfries.Text = "Olives";
                AddOnPrice = 0.50d;
            }
        }
        // Guy-leroc Ossebi
        private void radioSalad_CheckedChanged_1(object sender, EventArgs e)
        {

            ClearTotals();
            ClearAddOns();

            if (radioSalad.Checked)
            {
                groupBox1.Text = "Add-on items ($.25/each)";
                checkLettuceTomatoOnion.Text = "Croutons";
                checkKetchupMustardMayo.Text = "Bacon bits";
                checkFrenchfries.Text = "Bread sticks ";
                AddOnPrice = 0.25d;
            }
        }
    }
}
