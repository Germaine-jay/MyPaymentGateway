using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Requests
{
    public class CreateUserRequest
    {
        [Required(ErrorMessage = "LastName cannot be empty"), RegularExpression(@"^[\w ]*[a-zA-Z]+(([', -][a-zA-Z])?[a-zA-Z]*)\s*$",
             ErrorMessage = "Invalid Firstname !"), MaxLength(20), MinLength(2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name cannot be empty"), RegularExpression(@"^[\w ]*[a-zA-Z]+(([', -][a-zA-Z])?[a-zA-Z]*)\s*$",
             ErrorMessage = "Invalid Lastname !"), MaxLength(20), MinLength(2)]
        public string FirstName { get; set; }

        [RegularExpression(@"^[\w ]*[a-zA-Z]+(([', -][a-zA-Z])?[a-zA-Z]*)\s*$", ErrorMessage = "Invalid Middle name !")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required"), EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; }

    }

    public class UpdateUserRequest
    {
        [Required(ErrorMessage = "LastName cannot be empty"), RegularExpression(@"^[\w ]*[a-zA-Z]+(([', -][a-zA-Z])?[a-zA-Z]*)\s*$",
             ErrorMessage = "Invalid Firstname !"), MaxLength(20), MinLength(2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name cannot be empty"), RegularExpression(@"^[\w ]*[a-zA-Z]+(([', -][a-zA-Z])?[a-zA-Z]*)\s*$",
             ErrorMessage = "Invalid Lastname !"), MaxLength(20), MinLength(2)]
        public string FirstName { get; set; }

        [RegularExpression(@"^[\w ]*[a-zA-Z]+(([', -][a-zA-Z])?[a-zA-Z]*)\s*$", ErrorMessage = "Invalid Middle name !")]
        public string? MiddleName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }


        [Required]
        public int UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }

    public class DeleteUserRequest
    {
        public int Id { get; set; }
        public string LastName { get; set; }     
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public IEnumerable<WalletRequest> Wallet { get; set; }
        public bool Active { get; set; }


    }

    public class UserWithWalletRequest
    {
        public int UserId { get; set ; }
        public IEnumerable<WalletRequest> Wallet { get; set; }
    }

}
