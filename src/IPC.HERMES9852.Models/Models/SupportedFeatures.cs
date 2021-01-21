using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    /// <summary>
    /// Section 1 is for XML serialisation, Section 2 is for MultiPlug Save/Load
    /// </summary>
    [XmlRoot(ElementName = "SupportedFeatures")]
    public class SupportedFeatures
    {
        //
        // Section 1
        //

        [XmlElement(ElementName = "FeatureBoardForecast")]
        public FeatureBoardForecast FeatureBoardForecast { get; set; }
        [XmlElement(ElementName = "FeatureCheckAliveResponse")]
        public FeatureCheckAliveResponse FeatureCheckAliveResponse { get; set; }
        [XmlElement(ElementName = "FeatureSendBoardInfo")]
        public FeatureSendBoardInfo FeatureSendBoardInfo { get; set; }

        //
        // Section 2
        //

        [DataMember]
        [XmlIgnore]
        public bool BoardForecast { get { return (FeatureBoardForecast != null); } set { FeatureBoardForecast = (value) ? new FeatureBoardForecast() : null ; } }
        [DataMember]
        [XmlIgnore]
        public bool CheckAliveResponse { get { return (FeatureCheckAliveResponse != null); } set { FeatureCheckAliveResponse = (value) ? new FeatureCheckAliveResponse() : null; } }
        [DataMember]
        [XmlIgnore]
        public bool SendBoardInfo { get { return (FeatureSendBoardInfo != null); } set { FeatureSendBoardInfo = (value) ? new FeatureSendBoardInfo() : null; } }
    }

    [XmlRoot(ElementName = "FeatureBoardForecast")]
    public class FeatureBoardForecast
    {
    }

    [XmlRoot(ElementName = "FeatureCheckAliveResponse")]
    public class FeatureCheckAliveResponse
    {
    }

    [XmlRoot(ElementName = "FeatureSendBoardInfo")]
    public class FeatureSendBoardInfo
    {
    }
}
