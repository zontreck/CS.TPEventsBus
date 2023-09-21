using TP.CS.EventsBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.CS.EventsBus.Events
{
    /// <summary>
    /// Broadcasts to all classes when the EventStatistics is updated
    /// </summary>
    public class StatisticsUpdateEvent : Event
    {
        public StatisticsUpdateEvent() { 
        }
    }
}
