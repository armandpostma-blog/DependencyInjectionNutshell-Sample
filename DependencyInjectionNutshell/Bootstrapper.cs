using DependencyInjectionNutshell.DatabaseAbstraction;
using DependencyInjectionNutshell.Repositories;
using DependencyInjectionNutshell.Services;
using DependencyInjectionNutshell.ViewModels;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace DependencyInjectionNutshell
{
    public static class Bootstrapper
    {
        public static UnityContainer Register()
        {
            UnityContainer container = new UnityContainer();

            string connectionString = "Server=127.0.0.1;Database=MyDataBase;Trusted_Connection=True;";
            container.RegisterType<IDatabaseConnection, SqlServerDatabaseConnection>(new ContainerControlledLifetimeManager(), new InjectionConstructor(connectionString));

            container.RegisterType<ICustomerRepository, CustomerRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerService, CustomerService>(new ContainerControlledLifetimeManager());

            container.RegisterType<IDialogService, DialogService>(new ContainerControlledLifetimeManager());

            container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();

            return container;
        }     
    }
}
