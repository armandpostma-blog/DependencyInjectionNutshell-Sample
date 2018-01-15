using System;
using System.Windows.Input;
using DependencyInjectionNutshell.Helpers;
using DependencyInjectionNutshell.Model;
using DependencyInjectionNutshell.Services;

namespace DependencyInjectionNutshell.ViewModels
{
    public class MainWindowViewModel : ObservableObject, IMainWindowViewModel
    {
        private Customer[] _customers;
        private readonly ICustomerService _customerService;
        private readonly IDialogService _dialogService;

        public Customer[] Customers
        {
            get { return _customers; }
            set
            {
                SetProperty(ref _customers, value);
            }
        }

        public string Title
        {
            get { return ".NET Dependency Injection in a Nutshell"; }
        }

        public ICommand ShowDialogCommand { get; set; }

        public MainWindowViewModel(ICustomerService customerService, IDialogService dialogService)
        {
            if (customerService == null)
            {
                throw new ArgumentNullException(nameof(customerService));
            }

            if (dialogService == null)
            {
                throw new ArgumentNullException(nameof(dialogService));
            }

            _customerService = customerService;
            _dialogService = dialogService;

            LoadCustomers();

            ShowDialogCommand = new SimpleRelayCommand(ShowDialog);
        }

        private void ShowDialog(object obj)
        {
            _dialogService.ShowDialog("Hello World");
        }

        private void LoadCustomers()
        {
            Customers = _customerService.GetCustomers();
        }
    }
}
