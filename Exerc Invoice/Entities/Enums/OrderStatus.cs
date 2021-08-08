using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Invoice.Entities.Enums
{
    enum OrderStatus : int
    {
        Pending_Payment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
