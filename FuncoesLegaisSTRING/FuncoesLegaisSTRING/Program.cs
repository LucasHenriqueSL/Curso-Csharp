using System;

namespace FuncoesLegaisSTRING
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = texto.ToUpper();
            string s2 = texto.ToLower();
            string s3 = texto.Trim(); // apagar os espaços iniciais e finais
            int n1 = texto.IndexOf("bc");
            int n2 = texto.LastIndexOf("bc");


            string s4 = texto.Substring(3);
            string s5 = texto.Substring(3, 5); // 5 caracteres a partir da posição 3
            string s6 = texto.Replace('a', 'x');
            string s7 = texto.Replace("abc", "xyz");

            bool b1 = String.IsNullOrEmpty(texto); // testar se é null ou vazio
            bool b2 = String.IsNullOrWhiteSpace(texto);



            Console.WriteLine("Texto : -" + texto + "-");
            Console.WriteLine("ToUpper : -" + s1 + "-");
            Console.WriteLine("ToLower : -" + s2 + "-");
            Console.WriteLine("Trim : -" + s3 + "-");
            Console.WriteLine("IndexOF('bc') : -" + n1 + "-");
            Console.WriteLine("LastIndexOF('bc') : -" + n2 + "-");
            Console.WriteLine("SubString (3) : -" + s4 + "-");
            Console.WriteLine("SubString (3,5) : -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x') : -" + s6 + "-");
            Console.WriteLine("Replace(abc, xyz) : -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty : " + b1);
            Console.WriteLine("IsNullOrWhiteSpace : " + b2);

        }
    } 
}
