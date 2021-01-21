using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public class SetConfiguration
    {
        [XmlArray("UpstreamConfigurations")]
        [XmlArrayItem("UpstreamConfiguration")]
        public UpstreamConfiguration[] UpstreamConfigurations { get; set; }

        [XmlArray("DownstreamConfigurations")]
        [XmlArrayItem("DownstreamConfiguration")]
        public DownstreamConfiguration[] DownstreamConfigurations { get; set; }
        [XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }
    }
}
