using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Strategy
{
    class _TestStrategy
    {
        public void Run(int i)
        {
            Console.WriteLine($"\n{i}) Strategy\nThis pattern allows a client to choose an algorithm from a family of algorithms at run-time and gives it a simple way to access it.\n");
            var system = new HRSystem(new TraineePayrollStrategy());
            system.PerformSalaryCalculation();

            Debug.Assert(system.Done, "Done must be true for TraineePayrollStrategy");

            system = new HRSystem(new EmployeePayrollStrategy());
            system.PerformSalaryCalculation();

            Debug.Assert(system.Done, "Done must be true for EmployeePayrollStrategy");

            
        }
    }
}
