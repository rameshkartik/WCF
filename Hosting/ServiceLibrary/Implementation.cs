﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServiceLibrary;
namespace ServiceLibrary
{
    
    public class Service : ILibrary
    {
        public string GetStringData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetIntData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
