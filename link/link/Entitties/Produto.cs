using System;
using System.Collections.Generic;
using System.Text;

namespace link.Entitties
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
