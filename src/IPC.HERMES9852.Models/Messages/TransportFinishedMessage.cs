namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class TransportFinishedMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "TransportFinished")]
        public TransportFinished TransportFinished { get; set; }
    }
}
