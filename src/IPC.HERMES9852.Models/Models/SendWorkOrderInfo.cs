﻿
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
        /// This attribute will not be sent if the board information hasnot been found.
        /// 0 Board of unknown quality available
        /// 1 Good board available
        /// 2 Failed board available
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? FailedBoard { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLFailedBoardSpecified { get { return FailedBoard.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FailedBoard")]
        public string XMLFailedBoard
        {
            get { return (FailedBoard.HasValue) ? FailedBoard.ToString() : null; }
            set { FailedBoard = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }

        /// <summary>
        /// Identifies a collection of PCBs sharing common properties.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }

        /// <summary>
        /// This attribute will not be sent if the board information has not been found.
        /// 0 Side up is unknown
        /// 1 Board top side is up
        /// 2 Board bottom side is up
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? FlippedBoard { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLFlippedBoardSpecified { get { return FlippedBoard.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FlippedBoard")]
        public string XMLFlippedBoard
        {
            get { return (FlippedBoard.HasValue) ? FlippedBoard.ToString() : null; }
            set { FlippedBoard = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }

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
        /// The length of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Length { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLLengthSpecified { get { return Length.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Length")]
        public string XMLLength
        {
            get { return (Length.HasValue) ? Length.ToString() : null; }
            set { Length = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
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
        public string XMLWidth
        {
            get { return (Width.HasValue) ? Width.ToString() : null; }
            set { Width = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
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
        public string XMLThickness
        {
            get { return (Thickness.HasValue) ? Thickness.ToString() : null; }
            set { Thickness = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
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
        public string XMLConveyorSpeed
        {
            get { return (ConveyorSpeed.HasValue) ? ConveyorSpeed.ToString() : null; }
            set { ConveyorSpeed = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
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
        public string XMLTopClearanceHeight
        {
            get { return (TopClearanceHeight.HasValue) ? TopClearanceHeight.ToString() : null; }
            set { TopClearanceHeight = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
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
        public string XMLBottomClearanceHeight
        {
            get { return (BottomClearanceHeight.HasValue) ? BottomClearanceHeight.ToString() : null; }
            set { BottomClearanceHeight = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
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
        public string XMLWeight
        {
            get { return (Weight.HasValue) ? Weight.ToString() : null; }
            set { Weight = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
        }

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
        public string XMLRoute
        {
            get { return (Route.HasValue) ? Route.ToString() : null; }
            set { Route = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }

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
