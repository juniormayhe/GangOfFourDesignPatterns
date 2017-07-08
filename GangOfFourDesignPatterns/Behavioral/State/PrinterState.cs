using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.State
{
    /// <summary>
    /// This is an abstract/interface that is used by the Context object 
    /// to access the changeable functionality.
    /// </summary>
    public abstract class PrinterState
    {
        
        public abstract void Execute(Printer printer);
        public abstract void Cancel();
    }
}
