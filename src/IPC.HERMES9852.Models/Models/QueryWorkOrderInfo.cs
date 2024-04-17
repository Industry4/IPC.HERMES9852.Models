
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "QueryWorkOrderInfo")]
    public class QueryWorkOrderInfo
    {
        /// <summary>
        /// Indicates the ID of QueryWorkOrder message.The ID must be unambiguous and e.g., can be a timestamp or a GUID.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "QueryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// ID / name of this machine for identifying it in a Hermes enabled production line
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        /// <summary>
        /// Barcode of a magazine, required to identify the magazine
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
        public string XMLSlotId
        {
            get { return (SlotId.HasValue) ? SlotId.ToString() : null; }
            set { SlotId = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }

        /// <summary>
        /// The barcode of the PCB.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Identifies the work order for production of the PCB.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        /// <summary>
        /// Identifies the Batch for production of the PCB within a splitted work order.  
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }
    }
}
