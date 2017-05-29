using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSS.Automation.Dashboard
{
    
    [ServiceContract]
    public interface IDashboardLibrary
    {

        [OperationContract]
        void IncidentVolumeTrend_Updation(IncidentData incData);

        [OperationContract]
        void ChangesVolumeTrend_Updation(CQRFCData cqData);

        [OperationContract]
        void P1P2IncidentTrend_Updation(P1P2Data pData);

        [OperationContract]
        void P1TicketData(P1Data p1Data);

        [OperationContract]
        void P2TicketData(P2Data p2Data);

        [OperationContract]
        void AbendTrendData(AbndData aData);
     
    }

   

    [DataContract]
    public class IncidentData
    {

        [DataMember]
        public int CreatedTickets { get; set; }

        [DataMember]
        public int ResolvedTickets { get; set; }


    }


    [DataContract]
    public class CQRFCData
    {

    }


    [DataContract]
    public class P1P2Data
    {

    }


    [DataContract]
    public class P1Data
    {

    }

    [DataContract]
    public class P2Data
    {
    }

    [DataContract]
    public class AbndData
    {
    }
}
