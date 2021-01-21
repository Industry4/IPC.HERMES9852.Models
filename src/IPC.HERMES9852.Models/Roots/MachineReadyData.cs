using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class MachineReadyData : IMachineReadyData
    {
        [XmlElement(ElementName = "MachineReady")]
        public MachineReady MachineReady { get; set; }
    }
}
