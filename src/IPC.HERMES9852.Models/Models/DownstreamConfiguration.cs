using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "DownstreamConfiguration")]
    public class DownstreamConfiguration
    {
        [XmlAttribute(AttributeName = "DownstreamLaneId")]
        public string DownstreamLaneId { get; set; }
        [XmlAttribute(AttributeName = "ClientAddress")]
        public string ClientAddress { get; set; }
        [XmlAttribute(AttributeName = "Port")]
        public string Port { get; set; }
    }
}
