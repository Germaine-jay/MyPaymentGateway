using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Responses
{
    public class AuthorizationResponse
    {
        public bool IsAuthorized { get; set; }
        public string AuthorizationCode { get; set; }
        public string TransactionId { get; set; }
        public string ErrorMessage { get; set; }
    }
}
