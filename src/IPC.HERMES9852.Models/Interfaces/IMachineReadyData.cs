using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface IMachineReadyData
    {
        [XmlElement(ElementName = "MachineReady")]
        MachineReady MachineReady { get; set; }
    }
}
