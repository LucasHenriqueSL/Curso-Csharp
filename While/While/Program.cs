using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());


            while (num > 1000)
            {
                Console.WriteLine(num);
                num++;
            }
 
        }
    }
}
