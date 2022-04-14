
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "QueryBoardInfo")]
    public class QueryBoardInfo
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }
    }
}
