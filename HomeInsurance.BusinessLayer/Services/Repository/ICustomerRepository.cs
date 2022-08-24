using HomeInsurance.BusinessLayer.ViewModels;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeInsurance.BusinessLayer.Services.Repository
{
    public interface ICustomerRepository
    {
        Task<User> SignUp(User user);
        Task<Policy> ViewPolicy(string policyKey);
        Task<Policy> BuyPolicy(int QuoteId, PolicyModel policyModel);
        Task<Quote> RetrieveQuote(int userid);
    }
}
