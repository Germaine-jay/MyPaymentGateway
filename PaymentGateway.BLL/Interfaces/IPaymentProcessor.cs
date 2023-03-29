using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Dtos.Responses;

namespace PaymentGateway.BLL.Interfaces
{
    public interface IPaymentProcessor
    {
        Task<PaymentResponse> SendPaymentRequestAsync(PaymentRequest paymentRequest);
        Task<PaymentConfirmation> ReceivePaymentConfirmationAsync(PaymentResponse paymentResponse);
        Task<PaymentException> HandlePaymentExceptionAsync(PaymentResponse paymentResponse);
    }

}
