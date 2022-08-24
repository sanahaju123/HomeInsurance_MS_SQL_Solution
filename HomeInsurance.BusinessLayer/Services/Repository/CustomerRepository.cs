using HomeInsurance.BusinessLayer.ViewModels;
using HomeInsurance.DataLayer;
using HomeInsurance.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeInsurance.BusinessLayer.Services.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly HomeInsuranceDbContext _dbContext;

        public CustomerRepository(HomeInsuranceDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Policy> BuyPolicy(int QuoteId,PolicyModel policyModel)
        {
            try
            {
                Policy policy = new Policy();
                policy.PolicyEffectiveDate = policyModel.PolicyEffectiveDate;
                policy.QuoteId = QuoteId;
                policy.PolicyEndDate = policyModel.PolicyEffectiveDate.AddYears(1);
                policy.PolicyKey = QuoteId.ToString() + "_1";
                policy.PolicyStatus = policyModel.PolicyEffectiveDate <= DateTime.Now ? "ACTIVE" : "PENDING";
                policy.PolicyTerm = 1;
                var result = await _dbContext.Policies.AddAsync(policy);
                await _dbContext.SaveChangesAsync();
                return policy;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Quote> RetrieveQuote(int userid)
        {
            try
            {
                return await _dbContext.Quotes.FindAsync(userid);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<User> SignUp(User user)
        {
            try
            {
                var result = await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Policy> ViewPolicy(string policyKey)
        {
            try
            {
                return await _dbContext.Policies.FindAsync(policyKey);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
