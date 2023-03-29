using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Requests
{
    public class AuthorizationRequest
    {
        [Required(ErrorMessage = "Invalid card number"), MaxLength(15)]
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "Invalid CVV"), MaxLength(3)]
        public string CVV { get; set; }
        public decimal Amount { get; set; }
    }
}
