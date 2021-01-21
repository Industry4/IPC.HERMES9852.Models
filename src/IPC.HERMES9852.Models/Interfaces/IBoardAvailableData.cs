using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface IBoardAvailableData
    {
        [XmlElement(ElementName = "BoardAvailable")]
        Board BoardAvailable { get; set; }
    }
}
