using System;
using System.IO;
using System.Globalization;
using link.Entitties;
using System.Collections.Generic;
using System.Linq;
namespace link
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path");
            string path = Console.ReadLine();

            List<Produto> list = new List<Produto>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                 string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Produto(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
//D:\Lucas