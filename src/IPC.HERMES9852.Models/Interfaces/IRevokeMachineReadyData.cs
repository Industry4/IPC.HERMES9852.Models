using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    interface IRevokeMachineReadyData
    {
        [XmlElement(ElementName = "RevokeMachineReady")]
        RevokeMachineReady RevokeMachineReady { get; set; }
    }
}
