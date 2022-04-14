
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "SupervisoryServiceDescription")]
    public class SupervisoryServiceDescription
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SystemId")]
        public string SystemId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "SupportedFeatures")]
        public SupvervisoryFeatures SupportedFeatures { get; set; }
    }
}
