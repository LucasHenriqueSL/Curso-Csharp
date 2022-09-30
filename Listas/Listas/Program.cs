using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // lista criada vazia

            list.Add("Maria"); // Adiciona no final da lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Joey");
            list.Insert(2, "Marco"); // Igual o add mas vc escolhe a posição em q ele vai ser adicionado

            

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------");


            Console.WriteLine(list.Count); // Contador

            Console.WriteLine("--------------------------");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            Console.WriteLine("--------------------------");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("--------------------------");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            Console.WriteLine("--------------------------");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("--------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("--------------------------");

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------");


            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("--------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------");

            list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
