using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    public class Board
    {
        /// <summary>
        /// Represents the empty Board.
        /// </summary>
        public static Board Empty
        {
            get
            {
                return new Board
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
                    BottomClearanceHeight = 0,
                    Weight = 0
                };
            }
        }

        [XmlIgnore]
        public string Guid { get; set; }

        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }
        [XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }
        [XmlAttribute(AttributeName = "FailedBoard")]
        public int FailedBoard { get; set; }
        [XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }
        [XmlAttribute(AttributeName = "FlippedBoard")]
        public int FlippedBoard { get; set; }
        [XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }
        [XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }
        [XmlAttribute(AttributeName = "Length")]
        public float Length { get; set; }
        [XmlAttribute(AttributeName = "Width")]
        public float Width { get; set; }
        [XmlAttribute(AttributeName = "Thickness")]
        public float Thickness { get; set; }
        [XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float ConveyorSpeed { get; set; }
        [XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float TopClearanceHeight { get; set; }
        [XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float BottomClearanceHeight { get; set; }
        [XmlAttribute(AttributeName = "Weight")]
        public float Weight { get; set; }
        [XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }
    }
}
