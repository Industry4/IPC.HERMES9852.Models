using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class RevokeBoardAvailableData : IRevokeBoardAvailableData
    {
        [XmlElement(ElementName = "RevokeBoardAvailable")]
        public RevokeBoardAvailable RevokeBoardAvailable { get; set; }
    }
}
