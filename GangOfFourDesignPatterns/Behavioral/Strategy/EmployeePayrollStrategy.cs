using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Concrete strategy implements a custom algorithm
    /// </summary>
    public class EmployeePayrollStrategy : PayrollStrategy
    {
        public override void CalculateSalary()
        {
            Console.WriteLine($"   payroll calculated for {nameof(EmployeePayrollStrategy)}");
        }
    }
}
