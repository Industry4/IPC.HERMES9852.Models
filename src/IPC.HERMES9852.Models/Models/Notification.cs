using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Notification")]
    public class Notification
    {
        [XmlAttribute(AttributeName = "NotificationCode")]
        public int NotificationCode { get; set; }
        [XmlAttribute(AttributeName = "Severity")]
        public int Severity { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
    }
}
