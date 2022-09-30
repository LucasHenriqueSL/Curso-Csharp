using System;
using System.Globalization;

namespace Expressão_condicional_Ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            // (condição) ? valor_se_verdadeiro : valor_se_falso
            //EXEMPLO
            // (2 > 4) ? 50 : 80 ----------> 80




            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);





        }
    }
}
