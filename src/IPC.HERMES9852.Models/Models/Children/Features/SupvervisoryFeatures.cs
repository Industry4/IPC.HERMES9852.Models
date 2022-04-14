
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "SupportedFeatures")]
    public class SupvervisoryFeatures
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureConfiguration")]
        public FeatureConfiguration FeatureConfiguration { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureCheckAliveResponse")]
        public FeatureCheckAliveResponse FeatureCheckAliveResponse { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureBoardTracking")]
        public FeatureBoardTracking FeatureBoardTracking { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureQueryWorkOrderInfo")]
        public FeatureQueryWorkOrderInfo FeatureQueryWorkOrderInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureSendWorkOrderInfo")]
        public FeatureSendWorkOrderInfo FeatureSendWorkOrderInfo { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "FeatureReplyWorkOrderInfo")]
        public FeatureReplyWorkOrderInfo FeatureReplyWorkOrderInfo { get; set; }
    }
}
