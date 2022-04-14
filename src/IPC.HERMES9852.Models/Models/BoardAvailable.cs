namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "BoardAvailable")]
    public class BoardAvailable
    {
        /// <summary>
        /// Represents the empty Board.
        /// </summary>
        public static BoardAvailable Empty
        {
            get
            {
                return new BoardAvailable
                {
                    BoardId = string.Empty,
                    BoardIdCreatedBy = string.Empty,
                    FailedBoard = 0,
                    ProductTypeId = string.Empty,
                    FlippedBoard = 0,
                    TopBarcode = string.Empty,
                    BottomBarcode = string.Empty,
                    Length = 0,
                    Width = 0,
                    Thickness = 0,
                    ConveyorSpeed = 0,
                    TopClearanceHeight = 0,
                    BottomClearanceHeight = 0
                };
            }
        }

        /// <summary>
        /// Not Hermes Standard - Can be used for internal system use
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public string Guid { get; set; }

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
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float ConveyorSpeed { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float TopClearanceHeight { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float BottomClearanceHeight { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Weight")]
        public float Weight { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Route")]
        public int Route { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("SubBoards")]
        [System.Xml.Serialization.XmlArrayItem("SubBoard")]
        public SubBoard[] SubBoards { get; set; }

    }
}
