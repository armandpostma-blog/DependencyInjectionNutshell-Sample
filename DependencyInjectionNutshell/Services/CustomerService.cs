using System;
using DependencyInjectionNutshell.Model;
using DependencyInjectionNutshell.Repositories;

namespace DependencyInjectionNutshell.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            if (customerRepository == null)
            {
                throw new ArgumentNullException(nameof(customerRepository));
            }

            _customerRepository = customerRepository;
        }

        public Customer[] GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
    }
}
