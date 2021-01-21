using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "TransportFinished")]
    public class TransportFinished
    {
        [XmlAttribute(AttributeName = "TransferState")]
        public int TransferState { get; set; }
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }
    }
}
