namespace OopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockPortfolio portfolio = new StockPortfolio();

            // Read input from user
            Console.Write("Enter the number of stocks: ");
            int numStocks = int.Parse(Console.ReadLine());
            for (int i = 0; i < numStocks; i++)
            {
                Console.Write("Enter stock name: ");
                string name = Console.ReadLine();
                Console.Write("Enter number of shares: ");
                int numShares = int.Parse(Console.ReadLine());
                Console.Write("Enter share price: ");
                double price = double.Parse(Console.ReadLine());
                Stock stock = new Stock { Name = name, NumShares = numShares, Price = price };
                portfolio.AddStock(stock);
            }

            // Print stock report
            Console.WriteLine(portfolio.GetStockReport());
        }
    }
}
