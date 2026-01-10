namespace IPC.HERMES9852.Models
{
    /// <summary>
    /// Introduced in 1.6
    /// </summary>
    [System.Xml.Serialization.XmlRoot(ElementName = "Attributes")]
    public class CapabilitiesAttributes
    {
        /// <summary>
        /// Type of support for ProductTypeId
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProductTypeId")]
        public int ProductTypeId { get; set; }

        /// <summary>
        /// Type of support for TopBarcode.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public int TopBarcode { get; set; }

        /// <summary>
        /// Type of support for BottomBarcode.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomBarcode")]
        public int BottomBarcode { get; set; }

        /// <summary>
        /// Type of support for Length
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Length")]
        public int Length { get; set; }

        /// <summary>
        /// Type of support for Width.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")]
        public int Width { get; set; }

        /// <summary>
        /// Type of support for Thickness.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Thickness")]
        public int Thickness { get; set; }

        /// <summary>
        /// Type of support for ConveyorSpeed.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ConveyorSpeed")]
        public int ConveyorSpeed { get; set; }

        /// <summary>
        /// Type of support for TopClearanceHeight.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopClearanceHeight")]
        public int TopClearanceHeight { get; set; }

        /// <summary>
        /// Type of support for BottomClearanceHeight
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public int BottomClearanceHeight { get; set; }

        /// <summary>
        /// Type of support for Weight.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Type of support for WorkOrderId.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WorkOrderId")]
        public int WorkOrderId { get; set; }

        /// <summary>
        /// Type of support for BatchId.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BatchId")]
        public int BatchId { get; set; }

        /// <summary>
        /// Type of support for Route.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Route")]
        public int Route { get; set; }

        /// <summary>
        /// Type of support for Action.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Action")]
        public int Action { get; set; }

        /// <summary>
        /// Type of support for SubBoards.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SubBoards")]
        public int SubBoards { get; set; }
    }
}
