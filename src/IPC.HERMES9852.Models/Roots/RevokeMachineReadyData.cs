using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class RevokeMachineReadyData : IRevokeMachineReadyData
    {
        [XmlElement(ElementName = "RevokeMachineReady")]
        public RevokeMachineReady RevokeMachineReady { get; set; }
    }
}
