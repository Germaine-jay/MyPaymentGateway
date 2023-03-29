using PaymentGateway.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Requests
{
    public class PaymentAccountRequest
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public Currency Currency { get; set; }
    }

}
