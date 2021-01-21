using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    interface ITransportFinishedData
    {
        [XmlElement(ElementName = "TransportFinished")]
        TransportFinished TransportFinished { get; set; }
    }
}
