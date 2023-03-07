namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CurrentConfiguration")]
    public class CurrentConfiguration
    {
        /// <summary>
        /// ID / name of this machine for identifying it in a Hermes enabled production line.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        /// <summary>
        /// Port number on which connections from supervisory systems shall be established
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? SupervisorySystemPort { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLSupervisorySystemPortSpecified { get { return SupervisorySystemPort.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SupervisorySystemPort")]
        public int XMLSupervisorySystemPort
        {
            get { return (SupervisorySystemPort.HasValue) ? SupervisorySystemPort.Value : 0; }
            set { SupervisorySystemPort = value; }
        }

        /// <summary>
        /// Configuration of upstream lanes.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("UpstreamConfigurations")]
        [System.Xml.Serialization.XmlArrayItem("UpstreamConfiguration")]
        public UpstreamConfiguration[] UpstreamConfigurations { get; set; }

        /// <summary>
        /// Configuration of downstream lanes.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("DownstreamConfigurations")]
        [System.Xml.Serialization.XmlArrayItem("DownstreamConfiguration")]
        public DownstreamConfiguration[] DownstreamConfigurations { get; set; }
    }
}
