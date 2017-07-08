using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Context class that contains a property to hold the reference 
    /// of a Strategy object. 
    /// This property will be set / injected at run-time according 
    /// to the algorithm that is required.
    /// </summary>
    public class HRSystem
    {
        private PayrollStrategy _payrollStrategy;
        public bool Done { get; set; }

        public HRSystem(PayrollStrategy payrollStrategy)
        {
            _payrollStrategy = payrollStrategy;
        }

        //a template method to run any concrete algorithm
        public void PerformSalaryCalculation() {
            _payrollStrategy.CalculateSalary();
            
            Done = true;
        }
    }
}
