using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "UpstreamConfiguration")]
    public class UpstreamConfiguration
    {
        [XmlAttribute(AttributeName = "UpstreamLaneId")]
        public string UpstreamLaneId { get; set; }
        [XmlAttribute(AttributeName = "HostAddress")]
        public string HostAddress { get; set; }
        [XmlAttribute(AttributeName = "Port")]
        public string Port { get; set; }
    }
}
