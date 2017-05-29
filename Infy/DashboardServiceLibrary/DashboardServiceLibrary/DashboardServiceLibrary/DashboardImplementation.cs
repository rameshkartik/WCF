using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSS.Automation.Dashboard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DashBoardImplementation : IDashboardLibrary
    {
     
        public void IncidentVolumeTrend_Updation(IncidentData incData)
        {
            Console.WriteLine("Data Recvd");
        }

        public void ChangesVolumeTrend_Updation(CQRFCData cqData)
        {
            throw new NotImplementedException();
        }

        public void P1P2IncidentTrend_Updation(P1P2Data pData)
        {
            throw new NotImplementedException();
        }

        public void P1TicketData(P1Data p1Data)
        {
            throw new NotImplementedException();
        }

        public void P2TicketData(P2Data p2Data)
        {
            throw new NotImplementedException();
        }

        public void AbendTrendData(AbndData aData)
        {
            throw new NotImplementedException();
        }
    }
}
