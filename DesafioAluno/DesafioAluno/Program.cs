using System;
using System.Globalization;

namespace DesafioAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do Aluno:");
            aluno.nome = Console.ReadLine();
            Console.Write("Digite as 3 notas do aluno:");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = aluno.n1 + aluno.n2 + aluno.n3;
            double media = 60.00;
            double falta = media - soma;
            if(soma >= media){
                Console.WriteLine("Nota Final = " + soma);
                Console.WriteLine("APROVADO");

            }
            else
            {
                Console.WriteLine("Nota Final = " + soma);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }


        }
    }
}
