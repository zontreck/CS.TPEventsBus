﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.TPEventsBus.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class EventBusBroadcastableAttribute : Attribute
    {
    }
}
