namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "SendBoardInfo")]
    public class SendBoardInfo
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FailedBoard")]
        public int FailedBoard { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FlippedBoard")]
        public int FlippedBoard { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Length")]
        public float Length { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")]
        public float Width { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Thickness")]
        public float Thickness { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float TopClearanceHeight { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float BottomClearanceHeight { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }
    }
}
