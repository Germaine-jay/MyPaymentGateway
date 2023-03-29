using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Enums
{
    public enum PaymentStatus
    {
        Pending = 1,
        Authorized,
        Captured,
        Refunded,
        Voided,
        Failed
    }
}
