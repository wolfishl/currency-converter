using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurencyConverter
{
    /* 
     * This class accesses echangeRatesAPI.io 
     * and returns the rate for the currencies and the 
     * History of a specific currency
     */
         
    class Service
    {

        /*
         * rate is returned as GBP/EUR
         */
        public double getGBP()
        {
            //TODO write this code
            double rate = 0.0;
            return rate; 
        }

        /*
         * rate is returned as ILS/EUR
         */
        public double getILS()
        {
            //TODO write this code
            double rate = 0.0;
            return rate;
        }

        /*
         * rate is returned as USD/EUR
         */
        public double getUSD()
        {
            //TODO write this code
            double rate = 0.0;
            return rate;
        }

        /*
         * rate is returned as LBP/EUR
         */
        public double getLBP()
        {
            //TODO write this code
            double rate = 0.0;
            return rate;
        }


        /*
         * Takes a specific curency and returns a list of the daily rates of that currency for the past 30 days
         */
        public List<double> getHistory(String currency)
        {
            //TODO write this code
            List<double> history = new List<double>();
            return history;
        }
    }
}
