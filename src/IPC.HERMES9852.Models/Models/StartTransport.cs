
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "StartTransport")]
    public class StartTransport
    {
        /// <summary>
        /// The ID of the board for which the transport shall be started. 
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// Optional parameter indicating the selected conveyor speed for the handover in millimeter per second.
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
    }
}
