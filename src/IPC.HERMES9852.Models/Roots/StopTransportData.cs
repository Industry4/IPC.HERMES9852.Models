using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class StopTransportData : IStopTransportData
    {
        [XmlElement(ElementName = "StopTransport")]
        public StopTransport StopTransport { get; set; }
    }
}
