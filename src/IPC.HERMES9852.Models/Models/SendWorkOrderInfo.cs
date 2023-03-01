
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "SendWorkOrderInfo")]
    public class SendWorkOrderInfo
    {
        /// <summary>
        /// ID of QueryWorkOrderInfo this message refers to. This attribute is mandatory if it has been in the QueryWorkOrderInfo message.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "QueryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// Identifies the work order for production of the PCB.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        /// <summary>
        /// Identifies the Batch for production of the PCB within a splitted work order
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }

        /// <summary>
        /// Indicating the ID of the available board
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// MachineId of the machine which created the BoardId (the first machine in a
        /// consecutive row of machines implementing this protocol). The MachineId is
        /// part of the Hermes configuration
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        /// <summary>
        /// A value of the list below. This attribute will not be sent if the board information hasnot been found.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FailedBoard")]
        public int FailedBoard { get; set; }

        /// <summary>
        /// Identifies a collection of PCBs sharing common properties.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }

        /// <summary>
        /// A value of the list below. This attribute will not be sent if the board information has not been found.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FlippedBoard")]
        public int FlippedBoard { get; set; }

        /// <summary>
        /// The barcode of the top side of the PCB. This attribute is mandatory
        /// if it has been the barcode in the QueryWorkOrderInfo message.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        /// <summary>
        /// The barcode of the bottom side of the PCB.This attribute is mandatory if
        /// it has been the barcode in the QueryWorkOrderInfo message.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }

        /// <summary>
        /// The length of the PCB in millimeter
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Length")]
        public float Length { get; set; }

        /// <summary>
        /// The width of the PCB in millimeter
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")]
        public float Width { get; set; }

        /// <summary>
        /// The thickness of the PCB in millimeter.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Thickness")]
        public float Thickness { get; set; }

        /// <summary>
        /// The conveyor speed used for the PCB transfer in millimeter per second.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float ConveyorSpeed { get; set; }

        /// <summary>
        /// The clearance height for the top side of the PCB in millimeter.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float TopClearanceHeight { get; set; }

        /// <summary>
        /// The clearance height for the bottom side of the PCB in millimeter.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float BottomClearanceHeight { get; set; }

        /// <summary>
        /// The weight of the PCB in grams.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Weight")]
        public float Weight { get; set; }

        /// <summary>
        /// A routing instruction to downstream machines.Use a value of the list below.
        /// See also 2.3.7 Handling of Attribute
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Route")]
        public int Route { get; set; }

        /// <summary>
        /// A list of SubBoards 
        /// Note: Due to limited retain memory in PLCs this attribute might only be
        /// supported for a limited number of subboards.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("SubBoards")]
        [System.Xml.Serialization.XmlArrayItem("SubBoard")]
        public SubBoard[] SubBoards { get; set; }
    }
}
