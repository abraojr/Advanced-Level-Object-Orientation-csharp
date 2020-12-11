using Interfaces_03_Solving_the_diamond_problem.Devices;
using System;

namespace Interfaces_03_Solving_the_diamond_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Multiple inheritance can generate the diamond problem: an ambiguity caused by the existence of the same method in more than one superclass.
             *However, a class (or struct) can implement more than one interface*/

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.PrintDoc("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.PrintDoc("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
