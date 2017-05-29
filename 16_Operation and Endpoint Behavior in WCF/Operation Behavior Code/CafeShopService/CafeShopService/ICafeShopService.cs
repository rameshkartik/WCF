using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.CafeShopService.Contracts
{
    [ServiceContract(Namespace = "http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService", CallbackContract = typeof(ICafeShopServiceCallBack),SessionMode=SessionMode.Required)]
    public interface ICafeShopService
    {
        [OperationContract(IsOneWay = true)]
        void SellCofee(int quantity);

        [OperationContract]
        void RegistermyCofeeShop(string sCofeeShop);

    }

    public interface ICafeShopServiceCallBack
    {
        [OperationContract(IsOneWay=true)]
        void OnCallBack(CurrentData latestData);
    }

    #region DataContract

    [DataContract]
    public class CurrentData
    {
        private string sRegisterCofeeShop = string.Empty;
        private string sCurrentThreadId;
        private DateTime dWhenExecuted;
        private int iCofeesSold;
        private decimal deTotalSaleOnCofee;
        private int iInstanceCount;

        [DataMember]
        public string RegisterMyCofeeShop
        {
            get
            {
                return sRegisterCofeeShop;
            }
            set
            {
                sRegisterCofeeShop = value;
            }
        }

        [DataMember]
        public string ThreadID
        {
            get
            {
                return sCurrentThreadId;
            }
            set
            {
                sCurrentThreadId = value;
            }
        }

        [DataMember]
        public DateTime DateWhenExecuted
        {
            get
            {
                return dWhenExecuted;
            }
            set
            {
                dWhenExecuted = value;
            }
        }

        [DataMember]
        public decimal TotalSaleonCofee
        {
            get
            {
                return deTotalSaleOnCofee;
            }
            set
            {
                deTotalSaleOnCofee = value;
            }
        }

        [DataMember]
        public int CofeesSold
        {
            get
            {
                return iCofeesSold;
            }
            set
            {
                iCofeesSold = value;
            }
        }

        [DataMember]
        public int InstanceNumber
        {
            get
            {
                return iInstanceCount;
            }
            set
            {
                iInstanceCount = value;
            }
        }

    }

    #endregion
    
}
