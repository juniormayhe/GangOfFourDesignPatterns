using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.State
{
    public class StatePrintEnded : PrinterState
    {
        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Execute(Printer printer)
        {
            Console.WriteLine("   StatePrintEnded!");
        }
        
        
    }
}
