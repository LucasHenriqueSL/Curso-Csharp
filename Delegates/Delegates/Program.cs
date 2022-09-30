using System;
using Delegates.Services;
namespace Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;


            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.Invoke(a, b);
            
        }
    }
}
