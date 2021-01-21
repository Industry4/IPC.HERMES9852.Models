using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface IStartTransportData
    {
        [XmlElement(ElementName = "StartTransport")]
        StartTransport StartTransport { get; set; }
    }
}
