using TradeRiskConsoleApp.Interfaces;

namespace TradeRiskConsoleApp.UseCases
{
    public class Trade(double value, string clientSector, DateTime ReferenceDate) : ITrade
    {
        public double Value { get; } = value;
        public string ClientSector { get; } = clientSector;
        public DateTime NextPaymentDate { get; } = ReferenceDate;
    }
}
