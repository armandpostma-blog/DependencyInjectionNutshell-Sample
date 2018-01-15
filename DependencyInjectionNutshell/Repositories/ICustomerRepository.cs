using DependencyInjectionNutshell.Model;

namespace DependencyInjectionNutshell.Repositories
{
    public interface ICustomerRepository
    {
        Customer[] GetCustomers();
    }
}
