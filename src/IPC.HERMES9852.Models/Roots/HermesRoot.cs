using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class HermesRoot : ICheckAliveData, IServiceDescriptionData, IMachineReadyData, INotificationData, IBoardAvailableData, IStartTransportData, IQueryBoardInfoData, IStopTransportData
    {
        [XmlElement(ElementName = "CheckAlive")]
        public CheckAlive CheckAlive { get; set; }
        [XmlElement(ElementName = "ServiceDescription")]
        public ServiceDescription ServiceDescription { get; set; }
        [XmlElement(ElementName = "BoardAvailable")]
        public Board BoardAvailable { get; set; }
        [XmlElement(ElementName = "RevokeBoardAvailable")]
        public RevokeBoardAvailable RevokeBoardAvailable { get; set; }
        [XmlElement(ElementName = "TransportFinished")]
        public TransportFinished TransportFinished { get; set; }
        [XmlElement(ElementName = "Notification")]
        public Notification Notification { get; set; }
        [XmlElement(ElementName = "BoardForecast")]
        public BoardForecast BoardForecast { get; set; }
        [XmlElement(ElementName = "SendBoardInfo")]
        public Board SendBoardInfo { get; set; }
        [XmlElement(ElementName = "StartTransport")]
        public StartTransport StartTransport { get; set; }
        [XmlElement(ElementName = "MachineReady")]
        public MachineReady MachineReady { get; set; }
        [XmlElement(ElementName = "RevokeMachineReady")]
        public RevokeMachineReady RevokeMachineReady { get; set; }
        [XmlElement(ElementName = "StopTransport")]
        public StopTransport StopTransport { get; set; }
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }
        [XmlElement(ElementName = "QueryBoardInfo")]
        public QueryBoardInfo QueryBoardInfo { get; set; }
        [XmlElement(ElementName = "SetConfiguration")]
        public SetConfiguration SetConfiguration { get; set; }
        [XmlElement(ElementName = "GetConfiguration")]
        public GetConfiguration GetConfiguration { get; set; }
        [XmlElement(ElementName = "CurrentConfiguration")]
        public CurrentConfiguration CurrentConfiguration { get; set; }
        [XmlElement(ElementName = "SendWorkOrderInfo")]
        public SendWorkOrderInfo SendWorkOrderInfo { get; set; }


    }

}

