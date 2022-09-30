using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeComposição.Entities
{
    class Orderitem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Orderitem()
        {
        }

        public Orderitem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }



        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
