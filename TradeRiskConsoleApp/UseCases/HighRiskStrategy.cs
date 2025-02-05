using TradeRiskConsoleApp.Interfaces;

namespace TradeRiskConsoleApp.UseCases;

public class HighRiskStrategy : ICategoryStrategy
{
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        if (trade.Value > 1000000 && trade.ClientSector == "Private")
        {
            return "HIGHRISK";
        }
        return "NoCategory";
    }
}
