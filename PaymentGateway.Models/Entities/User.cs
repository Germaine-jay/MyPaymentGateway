using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using PaymentGateway.Models.Enums;

namespace PaymentGateway.Models.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Gender? GenderId { get; set; }
        public IList<Wallet> Wallet { get; set; }

        [NotMapped]
        public bool Active { get; set; }


        /*[ForeignKey(nameof(UserId))]
        public virtual ApplicationUser ApplicationUser { get; set; }*/
    }
}