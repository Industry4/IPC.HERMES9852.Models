namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CheckAlive")]
    public class CheckAlive
    {
        /// <summary>
        /// Ping / Pong message type. 
        /// Type may be one of the following values:
        /// 1 Ping: CheckAlive request.
        /// 2 Pong:CheckAlive response.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? Type { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLTypeSpecified { get { return Type.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Type")]
        public int XMLType
        {
            get { return (Type.HasValue) ? Type.Value : 0; }
            set { Type = value; }
        }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }
}
