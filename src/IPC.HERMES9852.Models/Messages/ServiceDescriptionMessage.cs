namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class ServiceDescriptionMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "ServiceDescription")]
        public ServiceDescription ServiceDescription { get; set; }
    }
}
