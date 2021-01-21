using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface ICheckAliveData
    {
        [XmlElement(ElementName = "CheckAlive")]
        CheckAlive CheckAlive { get; set; }
    }
}
