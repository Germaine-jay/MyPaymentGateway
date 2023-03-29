using PaymentGateway.Models.Enums;
using PaymentGateway.Models.Extensions;
using System.ComponentModel.DataAnnotations;

namespace PaymentGateway.Models.Entities
{
    public class Wallet : BaseEntity
    {
        [Key]
        public string WalletId { get; set; } = AccountNumberGenerator.GenerateRandomNumber();
        public long Balance { get; set; }
        public Currency Currency { get; set; } = Currency.Naira;

        public int UserId { get; set; }
        public User User { get; set; }
    }
}