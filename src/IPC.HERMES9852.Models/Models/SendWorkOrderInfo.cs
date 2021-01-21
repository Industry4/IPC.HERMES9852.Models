using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "SendWorkOrderInfo")]
    public class SendWorkOrderInfo
    {
        [XmlAttribute(AttributeName = "QueryId")]
        public string QueryId { get; set; }
        [XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }
        [XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }
        [XmlAttribute(AttributeName = "FailedBoard")]
        public string FailedBoard { get; set; }
        [XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }
        [XmlAttribute(AttributeName = "FlippedBoard")]
        public string FlippedBoard { get; set; }
        [XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }
        [XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }
        [XmlAttribute(AttributeName = "Length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "Width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "Thickness")]
        public string Thickness { get; set; }
        [XmlAttribute(AttributeName = "ConveyorSpeed")]
        public string ConveyorSpeed { get; set; }
        [XmlAttribute(AttributeName = "TopClearanceHeight")]
        public string TopClearanceHeight { get; set; }
        [XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public string BottomClearanceHeight { get; set; }
        [XmlAttribute(AttributeName = "Weight")]
        public string Weight { get; set; }
    }
}
