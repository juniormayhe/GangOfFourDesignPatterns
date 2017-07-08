using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.TemplateMethod
{
    class _TestTemplateMethod
    {
        public void Run(int i)
        {
            Console.WriteLine($"\n{i}) Template Method\nThis pattern is used to define the basic steps of an algorithm and allow the implementation of the individual steps to be changed. This pattern looks similar to the strategy design pattern. The main difference is the ability to change the parts of an algorithm rather than replacing an entire algorithm.\n");
            var xml = new Xml();
            xml.Print();
            Debug.Assert(xml.Printed, "Printed must be true for Xml");

            var html = new Html();
            html.Print();
            Debug.Assert(html.Printed, "Printed must be true for Html");

        }
    }
}
