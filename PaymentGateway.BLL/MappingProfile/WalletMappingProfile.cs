using AutoMapper;
using PaymentGateway.Models.Dtos.Requests;
using PaymentGateway.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.BLL.MappingProfiles
{
    internal class WalletMappingProfile:Profile
    {
        public WalletMappingProfile()
        {
            CreateMap<Wallet, WalletRequest>();
            CreateMap<WalletRequest, Wallet>();

        }
    }
}
