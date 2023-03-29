using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Responses
{
    public class PaymentAccountResponse
    {
        public bool IsSuccess { get; set; }
        public string AccountId { get; set; }
        public string ErrorMessage { get; set; }
    }

}
