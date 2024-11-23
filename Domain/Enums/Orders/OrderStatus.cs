using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums.Orders
{
    public enum OrderStatus
    {
        PENDING = 1,
        IN_PROGRESS = 2,
        COMPLETED = 3,
        CANCELLED = 4
    }
}
