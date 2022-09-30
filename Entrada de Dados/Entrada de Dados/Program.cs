using System;

namespace Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine(); COMANDO QUE LÊ ENTRADA FEITA PELO TECLADO
          

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' '); // Recorta itens com base no espaço em branco
            string p1 = vet[0]; // pega os itens recortados
            string p2 = vet[1]; 
            string p3 = vet[2];
              
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1 + " " + p2 + " " + p3);
      
        }
    }
}

