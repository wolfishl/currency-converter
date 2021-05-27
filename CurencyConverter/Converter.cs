using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurencyConverter
{
    /* Allows the following conversion
     * GBP/EUR
     * ILS/EUR
     * USD/EUR
     * LBP/EUR
     */
    class Converter
    {
        public double Convert(double startingAmount, string startingCurrency, string finalCurrency)
        {
            double finalAmount;
            if (startingCurrency == finalCurrency)
            {
                finalAmount = startingAmount;
            }
            else
            {
                // convert starting currency to euro
                double euroAmount = startingCurrency.Equals("EUR") ? startingAmount : AnyToEuro(startingAmount, startingCurrency);
                //convert euro start amount to chosen currency
                switch (finalCurrency)
                {
                    case "GBP":
                        finalAmount = EuroToGBP(euroAmount);
                        break;
                    case "ILS":
                        finalAmount = EuroToILS(euroAmount);
                        break;
                    case "USD":
                        finalAmount = EuroToUSD(euroAmount);
                        break;
                    case "LBP":
                        finalAmount = EuroToLBP(euroAmount);
                        break;
                    case "EUR":
                        finalAmount = startingAmount;
                        break;
                    default:
                        finalAmount = 0;
                        break;
                }
            }
            return finalAmount;
        }

        private double AnyToEuro(double startingAmount, String startingCurrency)
        {
            double euroAmount;
            double rate;
            switch (startingCurrency)
            {
                case "GBP":
                    rate = Service.getGBP();
                    euroAmount = startingAmount / rate;
                    break;
                case "ILS":
                    rate = Service.getILS();
                    euroAmount = startingAmount / rate;
                    break;
                case "USD":
                    rate = Service.getUSD();
                    euroAmount = startingAmount / rate;
                    break;
                case "LBP":
                    rate = Service.getLBP();
                    euroAmount = startingAmount / rate;
                    break;
                default:
                    euroAmount = 0;
                    break;
            }
            return euroAmount;
        }

        private double EuroToGBP(double amount)
        {
            double rate = Service.getGBP();
            return amount * rate;
        }

        private double EuroToILS(double amount)
        {
            double rate = Service.getILS();
            return amount * rate;
        }

        private double EuroToUSD(double amount)
        {
            double rate = Service.getUSD();
            return amount * rate;
        }

        private double EuroToLBP(double amount)
        {
            double rate = Service.getLBP();
            return amount * rate;
        }
    }
}
