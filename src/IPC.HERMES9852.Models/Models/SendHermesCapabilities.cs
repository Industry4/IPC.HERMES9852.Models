
namespace IPC.HERMES9852.Models
{
    /// <summary>
    /// Introduced in 1.6
    /// </summary>
    [System.Xml.Serialization.XmlRoot(ElementName = "SendHermesCapabilities")]
    public class SendHermesCapabilities
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "Attributes")]
        public CapabilitiesAttributes Attributes { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "OptionalMessages")]
        public OptionalMessages OptionalMessages { get; set; }
    }
}
