using System;
using System.Collections.Generic;
using System.Text;
using AtividadeComposição.Entities;
using AtividadeComposição.Entities.Enums;

namespace AtividadeComposição.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
