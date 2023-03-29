using PaymentGateway.Models.Entities;
using PaymentGateway.Models.Enums;

namespace PaymentGateway.BLL.Interfaces
{
    public class PaymentMethod
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public PaymentMethodType Type { get; set; }
        public PaymentAccount Account { get; set; }
        public string Token { get; set; }
    }
}