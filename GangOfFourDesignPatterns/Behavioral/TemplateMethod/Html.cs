using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Concrete class inherits the AbstractClass and override the abstract operations
    /// to customize individual steps of a template mehod.
    /// </summary>
    public class Html : Document
    {
        protected override void PrintHeader()
        {
            Console.WriteLine($"   Printing {nameof(Html)} header");
        }

        protected override void PrintBody()
        {
            Console.WriteLine($"   Printing {nameof(Html)} body");
        }

        protected override void PrintFooter()
        {
            Console.WriteLine($"   Printing {nameof(Html)} footer");
        }
        
    }
}
