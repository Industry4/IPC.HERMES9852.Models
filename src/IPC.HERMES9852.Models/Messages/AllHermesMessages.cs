namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class AllHermesMessages
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "CheckAlive")]
        public CheckAlive CheckAlive { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "ServiceDescription")]
        public ServiceDescription ServiceDescription { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "Notification")]
        public Notification Notification { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "BoardAvailable")]
        public BoardAvailable BoardAvailable { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "RevokeBoardAvailable")]
        public RevokeBoardAvailable RevokeBoardAvailable { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MachineReady")]
        public MachineReady MachineReady { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "RevokeMachineReady")]
        public RevokeMachineReady RevokeMachineReady { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "StartTransport")]
        public StartTransport StartTransport { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "StopTransport")]
        public StopTransport StopTransport { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "TransportFinished")]
        public TransportFinished TransportFinished { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "BoardForecast")]
        public BoardForecast BoardForecast { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "QueryBoardInfo")]
        public QueryBoardInfo QueryBoardInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "SendBoardInfo")]
        public SendBoardInfo SendBoardInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "SetConfiguration")]
        public SetConfiguration SetConfiguration { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "GetConfiguration")]
        public GetConfiguration GetConfiguration { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "CurrentConfiguration")]
        public CurrentConfiguration CurrentConfiguration { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "SupervisoryServiceDescription")]
        public SupervisoryServiceDescription SupervisoryServiceDescription { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "BoardArrived")]
        public BoardArrived BoardArrived { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "BoardDeparted")]
        public BoardDeparted BoardDeparted { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "QueryWorkOrderInfo")]
        public QueryWorkOrderInfo QueryWorkOrderInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "SendWorkOrderInfo")]
        public SendWorkOrderInfo SendWorkOrderInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "ReplyWorkOrderInfo")]
        public ReplyWorkOrderInfo ReplyWorkOrderInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "Command")]
        public ACommand Command { get; set; }
    }
}

