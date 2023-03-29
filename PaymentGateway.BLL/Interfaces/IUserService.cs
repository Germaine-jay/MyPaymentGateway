using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Dtos.Responses;
using PaymentGateway.Models.Entities;

namespace PaymentGateway.BLL.Interfaces
{
    public interface IUserService
    {
        Task<string> CreateUser(UserRegistrationRequest request);
        Task<AuthenticationResponse> UserLogin(LoginRequest request);
        Task<string> ChangePassword(string userId, ChangePasswordRequest request);
        Task<string> ResetPassword(ResetPasswordRequest request);     
        Task<AuthenticationResponse> ConfirmTwoFactorToken(TwoFactorLoginRequest request);
        Task<string> VerifyUser(VerifyAccountRequest request);
        Task<string> ChangeEmail(int userId, ChangeEmailRequest request);
        Task<string> UpdateRecoveryEmail(string userId, string email);
        Task<UserResponse> GetUser(string userId);

        //Task ToggleUserActivation(string userId);
        //Task<AuthenticationResponse> ImpersonateUser(ImpersonationLoginRequest request);
        //Task<ImpersonationLoginResponse> ImpersonationLogin(ImpersonationLoginRequest request);

        /*Task<User> AuthenticateAsync(string email, string password);
        Task<User> RegisterAsync(UserRegistrationRequest request);
        Task<bool> ChangePasswordAsync(User user, string currentPassword, string newPassword);
        Task<PagedResponse<StaffProfileResponse>> GetAllUsers(UserRequest request);
        Task<StaffProfileResponse> GetSingleUser(string id);
        Task UpdateUserProfile(string userId, UpdateStaffProfileRequest request);*/
    }

}
