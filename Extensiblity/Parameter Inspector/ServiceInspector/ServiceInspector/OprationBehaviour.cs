﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rameshkartik.WCFSamples.Inspector;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Configuration;

namespace Rameshkartik.WCFSamples.Behaviour
{
    public class OprationBehaviour : IOperationBehavior
    {


        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
            
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            ParamInspector inspectr = new ParamInspector();
            dispatchOperation.ParameterInspectors.Add(inspectr);
        }

        public void Validate(OperationDescription operationDescription)
        {
            
        }
    }

    public class BehaviorExt : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(OprationBehaviour); }
        }

        protected override object CreateBehavior()
        {
            return new OprationBehaviour();
        }
    }
}
