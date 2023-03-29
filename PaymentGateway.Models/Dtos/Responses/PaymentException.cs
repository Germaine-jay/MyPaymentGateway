using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Models.Dtos.Responses
{
    public class PaymentException : Exception
    {
        public PaymentException() : base() { }

        public PaymentException(string message) : base(message) { }

        public PaymentException(string message, Exception innerException) : base(message, innerException) { }
    }

}
