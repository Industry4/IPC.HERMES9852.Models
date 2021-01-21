using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface INotificationData
    {
        [XmlElement(ElementName = "Notification")]
        Notification Notification { get; set; }
    }
}
