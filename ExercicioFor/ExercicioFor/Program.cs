using System;

namespace ExercicioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor");

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
