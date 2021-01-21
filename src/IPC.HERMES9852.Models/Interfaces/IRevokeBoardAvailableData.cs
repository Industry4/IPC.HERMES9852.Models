using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    interface IRevokeBoardAvailableData
    {
        [XmlElement(ElementName = "RevokeBoardAvailable")]
        RevokeBoardAvailable RevokeBoardAvailable { get; set; }
    }
}
