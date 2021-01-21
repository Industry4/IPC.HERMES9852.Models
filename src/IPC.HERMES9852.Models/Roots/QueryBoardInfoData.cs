using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public class QueryBoardInfoData : IQueryBoardInfoData
    {
        [XmlAttribute(AttributeName = "QueryBoardInfo")]
        public QueryBoardInfo QueryBoardInfo { get; set; }
    }
}
