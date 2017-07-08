using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.State
{
    public class StatePrinting : PrinterState
    {
        protected int _pages;
        public StatePrinting(int pages)
        {
            _pages = pages;
        }

        public override void Cancel()
        {
            Console.WriteLine("   StatePrinting cancelled...");
        }
        
        public override void Execute(Printer printer)
        {
            for (int i=0; i< _pages; i++) { 
                Console.WriteLine($"   StatePrinting page {i+1}...");
            }

            //only when all pages are done we go to next state
            printer.PrinterState = new StatePrintEnded();
        }
    }
}
