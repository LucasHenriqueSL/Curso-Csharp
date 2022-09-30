using System;

namespace Calculaor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Calculator.Sum( 2, 3 );
            int n2 = Calculator.Sum(2, 3 , 4);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
