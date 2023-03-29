using PaymentGateway.Models.Enums;
using PaymentGateway.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Requests
{
    public class WalletRequest
    {
        public string WalletId { get; set; } = AccountNumberGenerator.GenerateRandomNumber();
        public long Balance { get; set; }
        public Currency Currency { get; set; } = Currency.Naira;
        public int UserId { get; set; }
    }
}
