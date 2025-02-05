using TradeRiskConsoleApp.Interfaces;

namespace TradeRiskConsoleApp.UseCases;

public class ExpiredStrategy : ICategoryStrategy
{
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        if ((referenceDate - trade.NextPaymentDate).Days > 30)
        {
            return "EXPIRED";
        }
        return "NoCategory";
    }
}
