using System;
using System.Collections.Generic;
using System.Linq;

namespace Stock_Purchase_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("APL", "Apple");
            stocks.Add("AMZ", "Amazon");
            stocks.Add("DSN", "Disney");


            var portfolio = new Dictionary<string, List<double>>()
            {
                {"GM", new List<double>(){4892.12}},
                {"APL", new List<double>(){1214.90, 2881.95}},
                {"AMZ", new List<double>(){180.44, 298.01, 9092.45}},
                {"DSN", new List<double>(){934.21, 9025.23, 4013.89}}
            };


            foreach (var stock in portfolio)
            {
                var totals = stock.Value.Sum();
                Console.WriteLine($"Investor has spent a total of {totals} on the stock for {stocks[stock.Key]}");
            }
        }
    }
}
