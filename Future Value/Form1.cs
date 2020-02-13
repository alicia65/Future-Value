using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumberOfYears_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);//declare monthly investment variable and ToDecimal() method converts string to decimal number.
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;// calculate year by 12 and store this value in months variable
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = CalculateFutureValue(monthlyInvestment, months, monthlyInterestRate);

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private static decimal CalculateFutureValue(decimal monthlyInvestment, int months, decimal monthlyInterestRate)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)//generating new futureValue by looping through each month
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//end program
        }
    }
};
