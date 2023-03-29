using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.BLL.Interfaces
{
    public interface IPaymentMethodService
    {
        Task<PaymentMethod> AddPaymentMethodAsync(PaymentMethod paymentMethod);
        Task DeletePaymentMethodAsync(int paymentMethodId);
        Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod);
    }

}
