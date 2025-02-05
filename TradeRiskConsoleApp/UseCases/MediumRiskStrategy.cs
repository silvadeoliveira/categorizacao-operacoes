using TradeRiskConsoleApp.Interfaces;

namespace TradeRiskConsoleApp.UseCases;

public class MediumRiskStrategy : ICategoryStrategy
{
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        if (trade.Value > 1000000 && trade.ClientSector == "Public")
        {
            return "MEDIUMRISK";
        }
        return "NoCategory";
    }
}
