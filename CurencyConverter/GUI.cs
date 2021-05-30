using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurencyConverter
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (validateAmount() && validateComboBoxes())
            {
                String startingAmountStr = tbAmount.Text;
                double startingAmount = Double.Parse(startingAmountStr);
                String startingCurrency = cbStartCurrency.Text;
                String finalCurrency = cbEndCurrency.Text;
                tbResult.Text = String.Format("{0:0,0.00}", Converter.Convert(startingAmount, startingCurrency, finalCurrency));
            }
        }

        private void tbAmount_MouseLeave(object sender, EventArgs e)
        {
            String amount = tbAmount.Text.ToString();
            try
            {
                Double.Parse(amount);
                lblError.Text = " ";
            }
            catch
            {
                lblError.Text = "Invalid entry";
            }
        }

        private Boolean validateAmount()
        {
            String amount = tbAmount.Text.ToString();
            try
            {
                Double.Parse(amount);
                lblError.Text = " ";
                return true;
            }
            catch
            {
                lblError.Text = "Invalid entry";
                return false;
            }
        }

        private Boolean validateComboBoxes()
        {
            String startCurr = cbStartCurrency.Text.ToString();
            String endCurr = cbEndCurrency.Text.ToString();

            if (startCurr.Equals(endCurr))
            {
                lblError2.Text = "starting and ending currency match";
                return false;
            }
            else
            {
                lblError2.Text = " ";
                return true;
            }
        }


    }
}
