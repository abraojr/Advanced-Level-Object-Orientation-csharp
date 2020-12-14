using Delegates_01.Services;
using System;

namespace Delegates_01
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op1 = new BinaryNumericOperation(CalculationService.Sum);
            BinaryNumericOperation op1 = CalculationService.Sum;

            //BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Max);
            BinaryNumericOperation op2 = CalculationService.Max;

            //double result = op1.Invoke(a,b);
            double result1 = op1(a, b);
            Console.WriteLine(result1); //OUTPUT: 22

            //double result = op2.Invoke(a,b);
            double result2 = op2(a, b);
            Console.WriteLine(result2); //OUTPUT: 12
        }
    }
}
