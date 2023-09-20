using CS.TPEventsBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.TPEventsBus.Events
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
