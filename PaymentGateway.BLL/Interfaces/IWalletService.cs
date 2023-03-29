using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Entities;

namespace PaymentGateway.BLL.Interfaces
{
    internal interface IWalletService
    {
        Task<(bool successful, string msg)> CreateWalletAsync(int userId, WalletRequest request);
        Task<(bool successful, string msg)> DeleteWalletAsync(int userId, int walletId);

    }
}
