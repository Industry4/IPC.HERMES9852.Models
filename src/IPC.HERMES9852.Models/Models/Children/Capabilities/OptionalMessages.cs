namespace IPC.HERMES9852.Models
{
    /// <summary>
    /// Introduced in 1.6
    /// </summary>
    [System.Xml.Serialization.XmlRoot(ElementName = "OptionalMessages")]
    public class OptionalMessages
    {
        /// <summary>
        /// Indication of CheckAliveResponse message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureCheckAliveResponse")]
        public MessageCheckAliveResponse MessageCheckAliveResponse { get; set; }

        /// <summary>
        /// Indication of BoardForecast message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageBoardForecast")]
        public MessageBoardForecast MessageBoardForecast { get; set; }

        /// <summary>
        /// Indication of QueryBoardInfo message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageQueryBoardInfo")]
        public MessageQueryBoardInfo MessageQueryBoardInfo { get; set; }

        /// <summary>
        /// Indication of SendBoardInfo message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageSendBoardInfo")]
        public MessageSendBoardInfo MessageSendBoardInfo { get; set; }

        /// <summary>
        /// Indication of BoardArrived message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageBoardArrived")]
        public MessageBoardArrived MessageBoardArrived { get; set; }

        /// <summary>
        /// Indication of BoardDeparted message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageBoardDeparted")]
        public MessageBoardDeparted MessageBoardDeparted { get; set; }

        /// <summary>
        /// Indication of QueryWorkOrderInfo message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageQueryWorkOrderInfo")]
        public MessageQueryWorkOrderInfo MessageQueryWorkOrderInfo { get; set; }

        /// <summary>
        /// Indication of ReplyWorkOrderInfo message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageReplyWorkOrderInfo")]
        public MessageReplyWorkOrderInfo MessageReplyWorkOrderInfo { get; set; }

        /// <summary>
        /// Indication of Command message implementation.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "MessageCommand")]
        public MessageCommand MessageCommand { get; set; }
    }
}
