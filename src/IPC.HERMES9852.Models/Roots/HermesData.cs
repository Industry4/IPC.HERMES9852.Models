
namespace IPC.HERMES9852.Models
{
    //========== The Hermes Standard chapter 2.6 ==========
    public enum EState
    {
        eNOT_CONNECTED,
        eSOCKET_CONNECTED,
        eSERVICE_DESCRIPTION_DOWNSTREAM,
        eNOT_AVAILABLE_NOT_READY,
        eBOARD_AVAILABLE,
        eMACHINE_READY,
        eAVAILABLE_AND_READY,
        eTRANSPORTING,
        eTRANSPORT_STOPPED,
        eTRANSPORT_FINISHED,
        eDISCONNECTED
    };
}
