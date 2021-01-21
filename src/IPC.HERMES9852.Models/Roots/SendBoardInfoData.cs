using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class SendBoardInfoData : ISendBoardInfoData
    {
        [XmlElement(ElementName = "SendBoardInfo")]
        public Board SendBoardInfo { get; set; }
    }
}
