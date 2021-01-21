using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class NotificationData : INotificationData
    {
        [XmlElement(ElementName = "Notification")]
        public Notification Notification { get; set; }
    }
}
