using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.BLL.Interfaces
{
    public interface IPaymentGateway
    {
        Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest paymentRequest);
        Task<AuthorizationResponse> AuthorizeTransactionAsync(AuthorizationRequest authorizationRequest);
        Task<PaymentAccountResponse> CreateAccountAsync(PaymentAccountRequest paymentAccountRequest);
        Task<PaymentAccountResponse> UpdateAccountAsync(PaymentAccountRequest paymentAccountRequest);
        Task<PaymentAccountResponse> DeleteAccountAsync(string accountId);
    }

}
