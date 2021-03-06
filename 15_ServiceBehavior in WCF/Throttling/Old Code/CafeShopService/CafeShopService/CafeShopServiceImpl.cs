﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.CafeShopService.Contracts;
using System.Threading;
namespace Rameshkartik.WCFSamples.CafeShopService.Implementation
{
        
    #region InstanceMode->PerSession,ConcurrencyMode->Multiple
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
    //    ConcurrencyMode = ConcurrencyMode.Multiple)]
    #endregion    
    #region InstanceMode->PerSession,ConcurrencyMode->Retrant
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
    //    ConcurrencyMode = ConcurrencyMode.Reentrant)]
    #endregion    
    #region InstanceMode->PerSession,ConcurrencyMode->Single
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
    //    ConcurrencyMode = ConcurrencyMode.Single)]
    #endregion    

    #region InstanceMode->PerCall,ConcurrencyMode->Single
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
    //    ConcurrencyMode = ConcurrencyMode.Single)]
    #endregion
    #region InstanceMode->PerCall,ConcurrencyMode->Multiple
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
    //    ConcurrencyMode = ConcurrencyMode.Multiple)]
    #endregion

    #region InstanceMode->Single,ConcurrencyMode->Single
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
    //ConcurrencyMode = ConcurrencyMode.Single)]
    #endregion
    #region InstanceMode->Single,ConcurrencyMode->Multiple
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
    ConcurrencyMode = ConcurrencyMode.Multiple)]
    #endregion
    public class CafeShopServiceImpl : ICafeShopService
    {
        private int iSoldCofee = 0;
        private const int iCofeeRate = 10;
        private string sRegisterCofeeShop = string.Empty;
        private int iInstanceCount = 0;

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public int CofeesSold
        {
            get
            {
                return iSoldCofee;
            }
            set
            {
                iSoldCofee = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int CofeePrice
        {
            get
            {
                return iCofeeRate;
            }
        }

        
        #endregion

        #region Interface Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity"></param>
        public void SellCofee(int quantity)
        {
           iSoldCofee = iSoldCofee + quantity;
           iInstanceCount++;
           CurrentData cData = new CurrentData();
           cData.DateWhenExecuted = DateTime.Now;
           cData.RegisterMyCofeeShop = sRegisterCofeeShop;
           cData.ThreadID = Thread.CurrentThread.ManagedThreadId.ToString();
           cData.InstanceNumber = iInstanceCount;
           cData.CofeesSold = iSoldCofee;
           cData.TotalSaleonCofee = Convert.ToDecimal(iSoldCofee * iCofeeRate);
           callBack.OnCallBack(cData);
        }

        
        /// <summary>
        /// 
        /// </summary>
        public void RegistermyCofeeShop(string sCofeeShop)
        {
            sRegisterCofeeShop = sCofeeShop;
            Console.WriteLine("CafeShop " + sCofeeShop + " Registered");
            
        }

        /// <summary>
        /// 
        /// </summary>
        public ICafeShopServiceCallBack callBack
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ICafeShopServiceCallBack>();
            }
        }

        #endregion



        
    }

 
}
