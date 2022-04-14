namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class RevokeMachineReadyMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "RevokeMachineReady")]
        public RevokeMachineReady RevokeMachineReady { get; set; }
    }
}
