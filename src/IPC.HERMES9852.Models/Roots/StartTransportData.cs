using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class StartTransportData : IStartTransportData
    {
        [XmlElement(ElementName = "StartTransport")]
        public StartTransport StartTransport { get; set; }
    }
}
