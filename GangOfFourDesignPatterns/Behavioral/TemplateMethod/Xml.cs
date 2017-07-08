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
    public class Xml : Document
    {
        protected override void PrintHeader()
        {
            Console.WriteLine($"   printing {nameof(Xml)} header");
        }

        protected override void PrintBody()
        {
            Console.WriteLine($"   printing {nameof(Xml)} body");
        }

        protected override void PrintFooter()
        {
            Console.WriteLine($"   printing {nameof(Xml)} footer");
        }
        
    }
}
