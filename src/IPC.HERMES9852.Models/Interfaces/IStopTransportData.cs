using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface IStopTransportData
    {
        [XmlElement(ElementName = "StopTransport")]
        StopTransport StopTransport { get; set; }
    }
}
