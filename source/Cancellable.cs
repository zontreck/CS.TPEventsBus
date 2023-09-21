using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.CS.EventsBus
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CancellableAttribute : Attribute
    {
    }
}
