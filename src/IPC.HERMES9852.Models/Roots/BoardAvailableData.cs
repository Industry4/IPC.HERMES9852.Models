using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class BoardAvailableData : IBoardAvailableData
    {
        [XmlElement(ElementName = "BoardAvailable")]
        public Board BoardAvailable { get; set; }
    }
}
