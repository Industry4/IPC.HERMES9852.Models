namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CurrentConfiguration")]
    public class CurrentConfiguration
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SupervisorySystemPort")]
        public int SupervisorySystemPort { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("UpstreamConfigurations")]
        [System.Xml.Serialization.XmlArrayItem("UpstreamConfiguration")]
        public UpstreamConfiguration[] UpstreamConfigurations { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("DownstreamConfigurations")]
        [System.Xml.Serialization.XmlArrayItem("DownstreamConfiguration")]
        public DownstreamConfiguration[] DownstreamConfigurations { get; set; }
    }
}
