using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Requests
{
    public class PaymentRequest
    {
        public string Email { get; set; }
        public int Amount { get; set; }
        public string Reference { get; set; }
    }
}
