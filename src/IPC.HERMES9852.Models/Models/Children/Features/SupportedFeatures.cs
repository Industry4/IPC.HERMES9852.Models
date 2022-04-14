using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "SupportedFeatures")]
    public class SupportedFeatures
    {
        [DataMember]
        [XmlElement(ElementName = "FeatureCheckAliveResponse")]
        public FeatureCheckAliveResponse FeatureCheckAliveResponse { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureBoardForecast")]
        public FeatureBoardForecast FeatureBoardForecast { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureQueryBoardInfo")]
        public FeatureQueryBoardInfo FeatureQueryBoardInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureSendBoardInfo")]
        public FeatureSendBoardInfo FeatureSendBoardInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureCommand")]
        public FeatureCommand FeatureCommand { get; set; }

        //
        // Section 2
        //

        //[DataMember]
        //[XmlIgnore]
        //public bool BoardForecast { get { return (FeatureBoardForecast != null); } set { FeatureBoardForecast = (value) ? new FeatureBoardForecast() : null ; } }
        //[DataMember]
        //[XmlIgnore]
        //public bool CheckAliveResponse { get { return (FeatureCheckAliveResponse != null); } set { FeatureCheckAliveResponse = (value) ? new FeatureCheckAliveResponse() : null; } }
        //[DataMember]
        //[XmlIgnore]
        //public bool SendBoardInfo { get { return (FeatureSendBoardInfo != null); } set { FeatureSendBoardInfo = (value) ? new FeatureSendBoardInfo() : null; } }
    }
}
