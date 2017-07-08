using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Strategy interface/abstract that is used by the Context object to call 
    /// the algorithm defined by a ConcreteStrategy.
    /// </summary>
    public abstract class PayrollStrategy
    {
        
        //algorithm to be run by concrete strategy class
        public abstract void CalculateSalary();
    }
}
