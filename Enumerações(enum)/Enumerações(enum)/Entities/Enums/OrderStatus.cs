using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerações_enum_.Entities.Enums
{
    enum OrderStatus : int   // derivado do tipo inteiro
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
