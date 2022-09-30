using System;
using System.Globalization;
using AtividadeExeption.Entities;

namespace AtividadeExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new Reservation(number, checkIn, checkOut);
        }
    }
}
