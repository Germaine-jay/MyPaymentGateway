using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Dtos.Responses;
using PaymentGateway.Models.Entities;

namespace PaymentGateway.BLL.Interfaces
{
    public interface ITransactionService
    {
        Task<Transaction> GetTransactionAsync(int transactionId);
        Task<IEnumerable<Transaction>> GetTransactionHistoryAsync(int userId);
        Task<RefundResponse> ProcessRefundAsync(RefundRequest refundRequest);

    }
}
