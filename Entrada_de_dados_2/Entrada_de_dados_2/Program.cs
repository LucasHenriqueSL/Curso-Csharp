using System;
using System.Globalization;

namespace Entrada_de_dados_2
{
    class Program
    {
        static void Main(string[] args) 
        {
        /*    Console.WriteLine("Digite sua idade:");
            int n1 = int.Parse(Console.ReadLine()); //Convertendo string para int 
            //Console.ReadLine só recebe STRING
            Console.WriteLine("Digite seu sexo:");
            char n2 = char.Parse(Console.ReadLine()); // Converse string para Char

            Console.WriteLine();
            double valor = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture); // Converte string pra double // O culture info libera pra pessoa colocar . em vez de ,
        */
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]); 
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
