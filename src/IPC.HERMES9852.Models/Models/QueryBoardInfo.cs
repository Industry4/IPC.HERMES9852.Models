using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "QueryBoardInfo")]
    public class QueryBoardInfo
    {
        [XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }
        [XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }
    }
}
