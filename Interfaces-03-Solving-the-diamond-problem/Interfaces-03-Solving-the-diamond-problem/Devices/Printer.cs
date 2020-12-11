using System;

namespace Interfaces_03_Solving_the_diamond_problem.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        public void PrintDoc(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
