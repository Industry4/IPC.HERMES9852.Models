namespace IPC.HERMES9852.Models
{
    public class QueryBoardInfoMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "QueryBoardInfo")]
        public QueryBoardInfo QueryBoardInfo { get; set; }
    }
}
