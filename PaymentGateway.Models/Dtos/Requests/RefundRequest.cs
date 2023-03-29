using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Requests
{
    public class RefundRequest
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
    }
}
