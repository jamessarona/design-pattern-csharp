using StockDataConverter.Base;
using StockDataConverter.Data;
using System.Xml;
using Newtonsoft.Json;

namespace StockDataConverter.Adapter;

public class XmlToJsonAdapter : IStockData
{
    private readonly StockDataXml _xmlStockData;

    public XmlToJsonAdapter(StockDataXml xmlStockData)
    {
        _xmlStockData = xmlStockData;
    }

    public string GetStockData()
    {
        string xmlData = _xmlStockData.GetStockData();
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xmlData);

        string jsonData = JsonConvert.SerializeXmlNode(xmlDocument);
        return jsonData;

    }
}