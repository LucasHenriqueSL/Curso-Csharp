using System;
using System.Globalization;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Parse("2000-05-21 14:43:58");
            DateTime d2 = DateTime.Parse("15/08/2022 13:43:52");

            Console.WriteLine(d1);
            Console.WriteLine(d2);


            DateTime d3 = DateTime.ParseExact("2000-05-21","yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d3);
            DateTime d4 = DateTime.ParseExact("15/08/2022 13:05:04", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d4);















            /*
            DateTime d1 = new DateTime(2022, 11, 25);
            DateTime d2 = new DateTime(2022,11,25,10,10,10);// ano - mes - dia - hora - minuto - segundo
            DateTime d3 = new DateTime(2022, 11, 25, 10, 10, 10, 600);// ano - mes - dia - hora - minuto - segundo - milissegundos
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);*/
        }
    }
}
