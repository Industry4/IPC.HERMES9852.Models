using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "CheckAlive")]
    public class CheckAlive
    {
        [XmlAttribute(AttributeName = "Type")]
        public int Type { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }
}
