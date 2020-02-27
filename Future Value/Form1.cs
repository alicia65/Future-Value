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
            try //prevent errors and informs users to enter proper data
            {
                if (IsValidData())
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
            }
            /*catch (FormatException) 
            {
                MessageBox.Show("Invalid numeric format. Please check all entries.", "Entry Error");
            }
            catch (OverflowException) 
            {
                MessageBox.Show("An overflow exception has occurred. Please enter smaller values.", "Entry Error");
            }
            */
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                throw ex;
            }
            
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt32(TextBox textBox, string name) 
        {
            int number = 0;
            if(int.TryParse(textBox.Text, out number)) 
            {
                return true;
            }
            else 
            {
                MessageBox.Show(name + "must be a number.", " Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsDecimal(TextBox textBox, string name) 
        {
            decimal number = 0m;
            if(Decimal.TryParse(textBox.Text, out number)) 
            {
                return true;
            }
            else 
            {
                MessageBox.Show(name + "must be a decimal value. ", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max) 
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if( number < min || number > max) 
            {
                MessageBox.Show(name + "must be between " + min.ToString()
                    + " and" + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsValidData() 
        {
            // Validate the Monthly Investment text box
            if (!IsPresent(txtMonthlyInvestment, "Monthly Investment"))
                return false;
            if(!IsDecimal(txtMonthlyInvestment, "Monthly Investment"))
                return false;
            if (!IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 20))
                return false;

            // Validate the Interest Rate text box
            if (!IsPresent(txtInterestRate, "Interest Rate"))
                return false;
            if (!IsDecimal(txtInterestRate, "Interest Rate"))
                return false;
            if (!IsWithinRange(txtInterestRate, "Interest Rate", 1, 20))
                return false;
            return true;
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
