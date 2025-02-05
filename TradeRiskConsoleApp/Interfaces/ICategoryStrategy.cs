namespace TradeRiskConsoleApp.Interfaces;

public interface ICategoryStrategy
{
     string GetCategory(ITrade trade, DateTime referenceDate);
}
