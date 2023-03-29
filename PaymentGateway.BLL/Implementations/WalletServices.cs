using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PaymentGateway.BLL.Interfaces;
using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Repository;

namespace PaymentGateway.BLL.Implementations
{
    public class WalletServices : IWalletService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<User> _userRepo;
        private readonly IRepository<Wallet> _walletRepo;

        public WalletServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userRepo = _unitOfWork.GetRepository<User>();
        }
        public async Task<(bool successful, string msg)> CreateWalletAsync(int userId, WalletRequest request)
        {
            var user = await _userRepo.GetSingleByAsync(u => u.Id == userId);
            if (user == null)
            {
                return (false, $"User with ID:{user} wasn't found");
            }
            var wallet = user.Wallet;
            var userupdate = _mapper.Map(request, wallet);
            var rowChanges = await _unitOfWork.SaveChangesAsync();

            return rowChanges > 0 ? (true, $"Wallet was successfully created!") : (false, "Failed To save changes!");
        }

        public async Task<(bool successful, string msg)> DeleteWalletAsync(int userId, string walletId)
        {
            User user = await _userRepo.GetSingleByAsync(u => u.Id == userId, include: u => u.Include(x => x.Wallet), tracking: true);
            if (user == null)
            {
                return (false, $"User with user:{user.FirstName} wasn't found");
            }
            var wallet = user.Wallet.SingleOrDefault(t => t.WalletId == walletId);
            if (wallet != null)
            {
                var delwallet = _mapper.Map<WalletRequest>(wallet);

                await _walletRepo.DeleteAsync(delwallet);
                return (true, "Deleted Successful!");
            }
            throw new NotImplementedException();
        }
    }
}
