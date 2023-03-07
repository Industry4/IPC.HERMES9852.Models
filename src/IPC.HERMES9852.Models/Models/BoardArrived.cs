
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "BoardArrived")]
    public class BoardArrived
    {
        /// <summary>
        /// ID / name of this machine for identifying it in a Hermes enabled production line.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        /// <summary>
        /// The lane on the upstream side. Lanes are enumerated looking downstream from right to left beginning with 1.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UpstreamLaneId")]
        public int UpstreamLaneId { get; set; }

        /// <summary>
        /// The ID of the transportation interface on the upstream side.      
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UpstreamInterfaceId")]
        public string UpstreamInterfaceId { get; set; }

        /// <summary>
        /// Barcode of a magazine, required to identify the magazine from which the Board was transferred.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MagazineId")]
        public string MagazineId { get; set; }

        /// <summary>
        /// Indicates the slot in the magazine, enumerated from bottom to top, beginning with 1.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? SlotId { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLSlotIdSpecified { get { return SlotId.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SlotId")]
        public int XMLSlotId
        {
            get { return (SlotId.HasValue) ? SlotId.Value : 0; }
            set { SlotId = value; }
        }

        /// <summary>
        /// 1 Transferred: Board arrived from upstream machine via Hermes or SMEMA.
        /// 2 Loaded: Board was loaded from a magazine or a stack of Boards.
        /// 3 Inserted: Board was manually inserted into the machine
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardTransfer")]
        public int BoardTransfer { get; set; }

        /// <summary>
        /// Indicating the ID of the available board
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// MachineId of the machine which created the BoardId (the first machine
        /// in a consecutive row of machines implementing this protocol). The
        /// MachineId is part of the Hermes configuration
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        /// <summary>
        /// 0 Board of unknown quality available
        /// 1 Good board available
        /// 2 Failed board available
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
        /// 0 Side up is unknown
        /// 1 Board top side is up
        /// 2 Board bottom side is up
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FlippedBoard")]
        public int FlippedBoard { get; set; }

        /// <summary>
        /// The barcode of the top side of the PCB.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        /// <summary>
        /// The clearance height for the bottom side of the PCB in millimeter.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }

        /// <summary>
        /// The length of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Length { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLLengthSpecified { get { return Length.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Length")]
        public float XMLLength
        {
            get { return (Length.HasValue) ? Length.Value : 0; }
            set { Length = value; }
        }

        /// <summary>
        /// The width of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Width { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLWidthSpecified { get { return Width.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")]
        public float XMLWidth
        {
            get { return (Width.HasValue) ? Width.Value : 0; }
            set { Width = value; }
        }

        /// <summary>
        /// The thickness of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Thickness { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLThicknessSpecified { get { return Thickness.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Thickness")]
        public float XMLThickness
        {
            get { return (Thickness.HasValue) ? Thickness.Value : 0; }
            set { Thickness = value; }
        }

        /// <summary>
        /// The conveyor speed preferred by the upstream machine in millimeter per second.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? ConveyorSpeed { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLConveyorSpeedSpecified { get { return ConveyorSpeed.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float XMLConveyorSpeed
        {
            get { return (ConveyorSpeed.HasValue) ? ConveyorSpeed.Value : 0; }
            set { ConveyorSpeed = value; }
        }

        /// <summary>
        /// The clearance height for the top side of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? TopClearanceHeight { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLTopClearanceHeightSpecified { get { return TopClearanceHeight.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float XMLTopClearanceHeight
        {
            get { return (TopClearanceHeight.HasValue) ? TopClearanceHeight.Value : 0; }
            set { TopClearanceHeight = value; }
        }

        /// <summary>
        /// The clearance height for the bottom side of the PCB in millimeter
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? BottomClearanceHeight { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLBottomClearanceHeightSpecified { get { return BottomClearanceHeight.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float XMLBottomClearanceHeight
        {
            get { return (BottomClearanceHeight.HasValue) ? BottomClearanceHeight.Value : 0; }
            set { BottomClearanceHeight = value; }
        }

        /// <summary>
        /// The weight of the PCB in grams
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Weight { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLWeightSpecified { get { return Weight.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Weight")]
        public float XMLWeight
        {
            get { return (Weight.HasValue) ? Weight.Value : 0; }
            set { Weight = value; }
        }

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
        /// A routing instruction to downstream machines.
        /// 0 Route undefined
        /// 1..99 Transfer the board at route[no.] /defined by line configuration
        /// 900 Return the board
        /// (≤ 998 Reserved for future definition)
        /// 999 Manual removal of the board
        /// ≥1000 For individual definition within a production line
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? Route { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLRouteSpecified { get { return Route.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Route")]
        public int XMLRoute
        {
            get { return (Route.HasValue) ? Route.Value : 0; }
            set { Route = value; }
        }

        /// <summary>
        /// An action instruction to downstream machine.
        /// 0 Action undefined
        /// 1 Process the board(e.g., Flipping, Marking, …)
        /// 2 Pass through the board without processing
        /// (≤ 999 Reserved for future definition)
        /// ≥1000 For individual definition within a production line
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? Action { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLActionSpecified { get { return Action.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Action")]
        public int XMLAction
        {
            get { return (Action.HasValue) ? Action.Value : 0; }
            set { Action = value; }
        }

        /// <summary>
        /// A list of SubBoards
        /// Note: Due to limited retain memory in PLCs this attribute might only
        /// be supported for a limited number of subboards
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlArray("SubBoards")]
        [System.Xml.Serialization.XmlArrayItem("SubBoard")]
        public SubBoard[] SubBoards { get; set; }
    }
}
