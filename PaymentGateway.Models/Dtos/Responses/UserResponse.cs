using PaymentGateway.Models.Enums;

namespace PaymentGateway.Models.Dtos.Responses
{
    public class UserResponse
    {

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public Gender GenderId { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName => $"{LastName} {FirstName} {MiddleName}";

    }
}
