using System;

namespace AtividadeREF
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Calculator.Triple(ref a); // o ref tá referenciando o x da outra classe
            Console.WriteLine(a);


        }
    }
}
