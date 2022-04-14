
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "DownstreamConfiguration")]
    public class DownstreamConfiguration
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DownstreamLaneId")]
        public int DownstreamLaneId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DownstreamInterfaceId")]
        public string DownstreamInterfaceId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ClientAddress")]
        public string ClientAddress { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Port")]
        public int Port { get; set; }
    }
}
