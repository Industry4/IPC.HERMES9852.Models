namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class NotificationMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "Notification")]
        public Notification Notification { get; set; }
    }
}
