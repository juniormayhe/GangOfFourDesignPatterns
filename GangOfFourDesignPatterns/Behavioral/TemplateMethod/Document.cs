using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Abstract class that contains template method and abstract operations for each of the steps that may be implemented by subclasses.
    /// </summary>
    public abstract class Document
    {
        public bool Printed { get; set; }

        protected abstract void PrintHeader();
        protected abstract void PrintBody();
        protected abstract void PrintFooter();

        /// <summary>
        /// template method
        /// </summary>
        public void Print() {
            PrintHeader();
            PrintBody();
            PrintFooter();
            Printed = true;
        }
    }
}
