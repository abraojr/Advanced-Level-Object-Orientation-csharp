using System;

namespace Interfaces_03_Solving_the_diamond_problem.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void PrintDoc(string document)
        {
            Console.WriteLine("ComboDevice print " + document); ;
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document); ;
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
