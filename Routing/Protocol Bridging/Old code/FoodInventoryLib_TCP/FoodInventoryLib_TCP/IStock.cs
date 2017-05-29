﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryService.Library
{
    [ServiceContract]
    public interface IStock
    {
        [OperationContract]
        string GetData(int value);
    }
    
}
