using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public interface ISendBoardInfoData
    {
        [XmlAttribute(AttributeName = "SendBoardInfo")]
        Board SendBoardInfo { get; set; }
    }
}
