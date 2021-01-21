using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface IServiceDescriptionData
    {
        [XmlElement(ElementName = "ServiceDescription")]
        ServiceDescription ServiceDescription { get; set; }
    }
}
