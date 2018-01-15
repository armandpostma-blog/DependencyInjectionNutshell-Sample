using System;
using DependencyInjectionNutshell.DatabaseAbstraction;
using DependencyInjectionNutshell.Model;

namespace DependencyInjectionNutshell.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDatabaseConnection _databaseConnection;

        public CustomerRepository(IDatabaseConnection databaseConnection)
        {
            if (databaseConnection == null)
            {
                throw new ArgumentNullException(nameof(databaseConnection));
            }

            _databaseConnection = databaseConnection;
        }

        public Customer[] GetCustomers()
        {
            return new Customer[]
            {
                new Customer(1, "First Customer"),
                new Customer(2, "Second Customer"),
                new Customer(3, "Third Customer"),
                new Customer(4, "Fourth Customer"),
                new Customer(5, "Fifth Customer")
            };
        }
    }
}
