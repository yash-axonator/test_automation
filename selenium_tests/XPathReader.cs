using System.Xml;

public class XPathReader
{
    private readonly XmlDocument xmlDoc;

    public XPathReader(string xmlFilePath)
    {
        xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);
    }

    public string GetXPath(string elementName)
    {
        XmlNode node = xmlDoc.SelectSingleNode($"//{elementName}");
        return node?.InnerText;
    }
}
