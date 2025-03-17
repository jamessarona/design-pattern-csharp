using StockDataConverter.Base;

namespace StockDataConverter.Analytics;

public class AnalyticsLibrary
{
    public void ProcessStockData(IStockData stockData)
    {
        Console.WriteLine("Processing Data: " + stockData.GetStockData());
    }
}