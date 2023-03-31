using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class StockPortfolio
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }
        public string GetStockReport()
        {
            double totalValue = 0;
            string report = "";
            foreach (Stock stock in stocks)
            {
                double value = stock.GetValue();
                totalValue += value;
                report += $"{stock.Name}: {stock.NumShares} shares worth {value}\n";
            }
            report += $"Total value of all stocks: {totalValue}";
            return report;
        }
    }
}

