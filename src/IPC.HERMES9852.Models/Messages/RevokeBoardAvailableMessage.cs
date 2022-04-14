namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class RevokeBoardAvailableMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "RevokeBoardAvailable")]
        public RevokeBoardAvailable RevokeBoardAvailable { get; set; }
    }
}
