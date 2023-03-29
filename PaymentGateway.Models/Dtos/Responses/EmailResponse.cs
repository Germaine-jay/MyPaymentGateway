using PaymentGateway.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Responses
{
    public class UserMailResponse
    {
        public ApplicationUser User { get; set; }
        public string FirstName { get; set; }
    }
}
