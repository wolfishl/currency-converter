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
            String startingAmountStr = tbAmount.Text;
            double startingAmount = Double.Parse(startingAmountStr);
            String startingCurrency = cbStartCurrency.Text;
            String finalCurrency = cbEndCurrency.Text;
           tbResult.Text = String.Format("{0:0,0.00}", Converter.Convert(startingAmount, startingCurrency, finalCurrency));

        }

        private void cbStartCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
