using HomeInsurance.BusinessLayer.Inerfaces;
using HomeInsurance.BusinessLayer.Services.Repository;
using HomeInsurance.BusinessLayer.ViewModels;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeInsurance.BusinessLayer.Services
{
    public class CustomerServices:ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Policy> BuyPolicy(int QuoteId, PolicyModel policyModel)
        {
            return await _customerRepository.BuyPolicy(QuoteId, policyModel);
        }

        public async Task<Quote> RetrieveQuote(int userid)
        {
            return await _customerRepository.RetrieveQuote(userid);
        }

        public async Task<User> SignUp(User user)
        {
            return await _customerRepository.SignUp(user);
        }

        public async Task<Policy> ViewPolicy(string policyKey)
        {
            return await _customerRepository.ViewPolicy(policyKey);
        }
    }
}
