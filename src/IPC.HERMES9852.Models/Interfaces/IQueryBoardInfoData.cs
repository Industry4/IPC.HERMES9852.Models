using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface IQueryBoardInfoData
    {
        [XmlAttribute(AttributeName = "QueryBoardInfo")]
        QueryBoardInfo QueryBoardInfo { get; set; }
    }
}
