using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDwyerProj3A
{
    public partial class TdwyerProj3B : Form
    {
        public TdwyerProj3B()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TdwyerProj3B_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                decimal payment = decimal.Parse(txtPaymentAmt.Text, System.Globalization.NumberStyles.Currency);
                decimal principal = decimal.Parse(txtPrincipal.Text, System.Globalization.NumberStyles.Currency);
                int months = Int16.Parse(txtLength.Text, System.Globalization.NumberStyles.Currency);
                int monthsInYear = Convert.ToInt16(txtMnthsInYr.Text);

                int years = months / monthsInYear;

                decimal totalPayment = payment * months;
                decimal totalInterest = totalPayment - principal;


                txtTotalInterest.Text = Convert.ToString(totalInterest);

                if (payment>principal)
                {
                    MessageBox.Show(
                        "Monthly payment cannot be greater than principal. Please check values.",
                        "Entry Error");
                }

            }

            catch (FormatException)
            {
                MessageBox.Show(
                    "A format Exception has occurred.  Please check all entries.",
                    "Entry Error");

            }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "An overflow Exception has occurred.  Please enter smaller values.",
                    "Entry Error");

            }

            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Cannot be zero months in a year.  Please enter a valid value, such as 12.",
                    "Entry Error");

            }
        }
    }
}
