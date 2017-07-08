using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.State
{
    class _TestState
    {
        public void Run(int i)
        {
            Console.WriteLine($"\n{i}) State\nThis pattern allows to split many behaviors in each concrete state class.\n");
            var printer = new Printer(new StatePrintStarted(5));
            printer.Print();
            printer.Print();
            printer.Print();
            Debug.Assert(printer.PrinterState is StatePrintEnded, "Must have ended printing");
            



        }
    }
}
