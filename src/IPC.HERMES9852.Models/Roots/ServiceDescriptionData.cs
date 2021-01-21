using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class ServiceDescriptionData : IServiceDescriptionData
    {
        [XmlElement(ElementName = "ServiceDescription")]
        public ServiceDescription ServiceDescription { get; set; }
    }
}
