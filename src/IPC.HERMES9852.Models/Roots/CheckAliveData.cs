using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class CheckAliveData : ICheckAliveData
    {
        [XmlElement(ElementName = "CheckAlive")]
        public CheckAlive CheckAlive { get; set; }
    }
}
