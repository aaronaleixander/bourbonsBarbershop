using bourbonsBarbershop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bourbonsBarbershop.Data
{
    public static class CustomerDb
    {
        /// <summary>
        /// Add UserAccounts to database. Return user with ID populated.
        /// </summary>
        /// <param name="context">db context class</param>
        /// <param name="customer">Customer account being added</param>
        /// <returns>customer</returns>
        public async static Task<Customer> Add(BourbonsContext context, Customer customer)
        {
            context.Customer.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        /// <summary>
        /// Checks if credentials are found in the database.
        /// The matching customer is returned for valid credentials.
        /// Null is returned if there are no matches.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async static Task<Customer> IsLoginValid(LoginViewModel model, BourbonsContext context)
        {
            return await (from m in context.Customer
                          where (m.EmailAddress == model.Email && m.Password == model.Password)
                          select m).SingleOrDefaultAsync(); // finds object that matches.
        }
    }
}
