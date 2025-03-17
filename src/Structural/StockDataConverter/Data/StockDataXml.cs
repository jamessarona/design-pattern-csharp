using StockDataConverter.Base;
using System.Xml;

namespace StockDataConverter.Data;

public class StockDataXml : IStockData
{
    public string GetStockData()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml("<Stock><Price>150.75</Price><Volume>5000</Volume></Stock>"); // sample data
        return xmlDocument.OuterXml;                                                                                         
    }
}