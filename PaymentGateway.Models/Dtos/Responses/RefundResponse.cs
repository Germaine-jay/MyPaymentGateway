using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Responses
{
    public class RefundResponse
    {
        public bool IsSuccessful { get; set; }
        public decimal RefundAmount { get; set; }
        public string ErrorMessage { get; set; }
    }
}
