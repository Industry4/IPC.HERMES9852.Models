namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "BoardForecast")]
    public class BoardForecast
    {
        /// <summary>
        /// Indicating the ID of forecast message. The ID must be unambiguous and
        /// e.g., can be a timetamp or a GUID.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ForecastId")]
        public string ForecastId { get; set; }

        /// <summary>
        /// Number of seconds until a board may be available at downstream machine.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? TimeUntilAvailable { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLTimeUntilAvailableSpecified { get { return TimeUntilAvailable.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TimeUntilAvailable")]
        public string XMLTimeUntilAvailable
        {
            get { return (TimeUntilAvailable.HasValue) ? TimeUntilAvailable.ToString() : null; }
            set { TimeUntilAvailable = !string.IsNullOrEmpty(value) ? float.Parse(value) : default(float?); }
        }

        /// <summary>
        /// Indicating the ID of the board that will be handed over as next.e.g., 
        /// in case of product change this attribute will not be sent.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// MachineId of the machine which created the BoardId.    
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        /// <summary>
        /// 0 Ready to accept any board
        /// 1 Ready to accept good boards
        /// 2 Ready to accept failed boards
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
        /// The barcode of the top side of the next PCB.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        /// <summary>
        /// The barcode of the bottom side of the next PCB.
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
    }
}
