using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {


            double[,] mat = new double[2,3]; // arranjo bi dimensional // LINHA-COLUNA

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
        }
    }
}
