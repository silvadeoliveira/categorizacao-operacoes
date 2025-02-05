using System.Globalization;
using TradeRiskConsoleApp.Interfaces;
using TradeRiskConsoleApp.UseCases;

class Program
{
    static void Main()
    {
        DateTime referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
        int n = int.Parse(Console.ReadLine());

        var trades = new List<ITrade>();

        for (int i = 0; i < n; i++)
        {
            var tradeData = Console.ReadLine().Split();
            double value = double.Parse(tradeData[0]);
            string clientSector = tradeData[1];
            DateTime nextPaymentDate = DateTime.ParseExact(tradeData[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);

            trades.Add(new Trade(value, clientSector, nextPaymentDate));
        }
        var strategies = new List<ICategoryStrategy>
        {
            new ExpiredStrategy(),
            new HighRiskStrategy(),
            new MediumRiskStrategy()
        };

        var context = new CategoryContext(strategies);

        // Exibir as categorias de cada operação
        foreach (var trade in trades)
        {
            string category = context.GetCategory(trade, referenceDate);
            Console.WriteLine(category);
        }
    }
}
