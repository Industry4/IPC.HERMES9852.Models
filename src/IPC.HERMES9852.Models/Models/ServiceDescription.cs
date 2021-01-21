using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "ServiceDescription")]
    public class ServiceDescription
    {
        [DataMember]
        [XmlElement(ElementName = "SupportedFeatures")]
        public SupportedFeatures SupportedFeatures { get; set; }
        [DataMember]
        [XmlAttribute(AttributeName = "LaneId")]
        public string LaneId { get; set; }
        [DataMember]
        [XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }
        [DataMember]
        [XmlAttribute(AttributeName = "InterfaceId")]
        public string InterfaceId { get; set; }
        [DataMember]
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; } = "1.1";
        [DataMember]
        [XmlIgnore]
        public bool ModeSMEMAAdaptor { get; set; } = false;
    }
}
