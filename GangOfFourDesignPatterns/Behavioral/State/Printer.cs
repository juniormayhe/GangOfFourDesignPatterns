namespace GangOfFourDesignPatterns.Behavioral.State
{
    /// <summary>
    /// Context class holds a concrete state object that provides the 
    /// behavior according to its current state. This is used by the clients.
    /// </summary>
    public class Printer
    {
        public PrinterState PrinterState { get; set; }

        public Printer(PrinterState printerState)
        {
            PrinterState = printerState;
        }

        public void Print()
        {
            PrinterState.Execute(this);
        }
    }
}