using StockDataConverter.Adapter;
using StockDataConverter.Analytics;
using StockDataConverter.Base;
using StockDataConverter.Data;

// XML data source
StockDataXml xmlData = new StockDataXml();

// Adapter to convert to XML to JSON
IStockData adaptedData = new XmlToJsonAdapter(xmlData);

// Analytics system that requires JSON
AnalyticsLibrary analytics = new AnalyticsLibrary();
analytics.ProcessStockData(adaptedData); // Process JSON instead of XML

Console.ReadLine();