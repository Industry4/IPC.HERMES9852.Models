
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "StartTransport")]
    public class StartTransport
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float ConveyorSpeed { get; set; }
    }
}
