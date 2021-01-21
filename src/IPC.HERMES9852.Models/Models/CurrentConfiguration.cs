

using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public class CurrentConfiguration
    {
        [XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        [XmlAttribute(AttributeName = "SupervisorySystemPort")]
        public int SupervisorySystemPort { get; set; }

        [XmlArray("UpstreamConfigurations")]
        [XmlArrayItem("UpstreamConfiguration")]
        public UpstreamConfiguration[] UpstreamConfigurations { get; set; }

        [XmlArray("DownstreamConfigurations")]
        [XmlArrayItem("DownstreamConfiguration")]
        public DownstreamConfiguration[] DownstreamConfigurations { get; set; }
    }
}
