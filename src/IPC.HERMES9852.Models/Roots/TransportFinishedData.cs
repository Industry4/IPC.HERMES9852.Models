using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class TransportFinishedData : ITransportFinishedData
    {
        [XmlElement(ElementName = "TransportFinished")]
        public TransportFinished TransportFinished { get; set; }
    }
}
