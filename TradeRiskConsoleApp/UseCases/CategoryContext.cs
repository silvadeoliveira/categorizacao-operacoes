using TradeRiskConsoleApp.Interfaces;

namespace TradeRiskConsoleApp.UseCases;

public class CategoryContext
{
    private List<ICategoryStrategy> _strategies;
    public CategoryContext(List<ICategoryStrategy> strategies)
    {
        _strategies = strategies;
    }
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        foreach (var strategy in _strategies)
        {
            var category = strategy.GetCategory(trade, referenceDate);
            if (category != "NoCategory")
            {
                return category;
            }
        }
        return "UNKNOWN";
    }
}
