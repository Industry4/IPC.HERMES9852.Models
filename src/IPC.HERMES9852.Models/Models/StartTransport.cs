using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "StartTransport")]
    public class StartTransport
    {
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }
        [XmlAttribute(AttributeName = "ConveyorSpeed")]
        public string ConveyorSpeed { get; set; }
    }
}
