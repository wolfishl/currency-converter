using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CurencyConverter
{
    /* 
     * This class accesses echangeRatesAPI.io 
     * and returns the rate for the currencies and the 
     * History of a specific currency
     */
         
    class Service
    {

        static String CURRENCIES = "GBP,ILS,USD,LBP";

        /*
         * Takes a string of currencies and returns 
         * a JSON response as a string with the current 
         * rates of the currencies compared to EUR.
         */
        private static String getRateResponse(String currencies)
        {
            RestClient client = new RestClient
                        ("http://api.exchangeratesapi.io/v1/latest" +
                         "?access_key=6d903b0ffe71f9ea1811ebeb6d6d4a68" +
                         $"&symbols={currencies}");

            RestRequest request = new RestRequest(Method.GET);
            String response = (client.Execute(request)).Content;
            return response;
        }

        /*
         * Takes a day and a string of currencies and returns a 
         * JSON respnse as a string with the historical rates of the
         * currencies on that day compared to EUR.
         */
        private static String getHistoryResponse(String day, String currencies)
        {
            RestClient client = new RestClient
                        ($"http://api.exchangeratesapi.io/v1/{day}" +
                         "?access_key=6d903b0ffe71f9ea1811ebeb6d6d4a68" +
                         $"&symbols={currencies}");

            RestRequest request = new RestRequest(Method.GET);
            String response = (client.Execute(request)).Content;
            Console.WriteLine(response);
            return response;
        }

        /*
         * Takes a currency and a JSON response as a string.
         * Finds retuns the rate of that currency in the response.
         */
        private static double getRate(String currency, String currencies)
        {
            String response = getRateResponse(currencies);
            int digitsAfterSymbol = 5;
            int precision = 10;
            double rate = double.Parse(turnNumeric
                        (response.Substring
                        (response.IndexOf(currency) +
                        digitsAfterSymbol, precision)));
            return rate;
        }

        /*
         * rate is returned as GBP/EUR
         */
        public static double getGBP()
        {
            return getRate("GBP", CURRENCIES);
        }

        /*
         * rate is returned as ILS/EUR
         */
        public static double getILS()
        {
            return getRate("ILS", CURRENCIES);
        }

        /*
         * rate is returned as USD/EUR
         */
        public static double getUSD()
        {
            return getRate("USD", CURRENCIES);
        }

        /*
         * rate is returned as LBP/EUR
         */
        public static double getLBP()
        {
            return getRate("LBP", CURRENCIES);
        }

        /*
         * Takes a specific curency and returns a list of the daily rates of that currency for the past 30 days
         */
        public static List<double> getHistory(String currency)
        {
            List<double> history = new List<double>();
            int digitsAfterSymbol = 5;
            int precision = 10;

            for (int day = 0; day < 30; day++)
            {
                DateTime today = DateTime.Today.AddDays(-day);
                String response = getHistoryResponse(today.ToString("yyyy-MM-dd"), CURRENCIES);
                history.Add(double.Parse(turnNumeric(response.Substring
                    (response.IndexOf(currency) + digitsAfterSymbol, precision))));
            }

            return history;
        }

        /*
         * Takes a currency and prints a list of the daily 
         * rates of that currency for the past 30 days.
         */
        public static void printHistory(String currency)
        {
            List<double> history = getHistory(currency);

            for (int day = 0; day < history.Count; day++)
            {
                DateTime today = DateTime.Today.AddDays(-day);
                Console.WriteLine(today.ToString("yyyy-MM-dd") + ": " + history[day]);
            }
        }

        /*
         * Ensures that all substrings of rates are completely
         * numeric before trying to parse them as doubles.
         */
        private static String turnNumeric(String str)
        {
            foreach (char c in str)
            {
                if (!c.Equals('.') && !char.IsNumber(c))
                {
                    str = str.Replace(c, '0');
                }
            }

            return str;
        }
    }
}
