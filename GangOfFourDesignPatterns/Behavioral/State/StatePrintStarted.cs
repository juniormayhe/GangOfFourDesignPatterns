using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.State
{
    public class StatePrintStarted : PrinterState
    {
        protected int _pages;
        public StatePrintStarted(int pages)
        {
            _pages = pages;
        }
        public override void Cancel()
        {
            Console.WriteLine("   StatePrintStarted cancelled...");
        }
        
        public override void Execute(Printer printer)
        {
            Console.WriteLine("   StatePrintStarted started...");
            printer.PrinterState = new StatePrinting(_pages);
        }
    }
}
