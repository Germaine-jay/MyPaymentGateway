using PaymentGateway.Models.Dtos.Responses;
using PaymentGateway.Models.Entities;
using System.Security.Claims;

namespace PaymentGateway.BLL.Interfaces
{
    public interface IJwtAuthenticator
    {
        Task<JwtToken> GenerateJwtToken(ApplicationUser user, string expires = null, List<Claim> additionalClaims = null);
    }
}
