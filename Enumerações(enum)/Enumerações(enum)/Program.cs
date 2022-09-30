using System;
using Enumerações_enum_.Entities;
using Enumerações_enum_.Entities.Enums;
namespace Enumerações_enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString(); // converter enum em string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Enum convertido em string

            Console.WriteLine(os);
        }
    }
}
