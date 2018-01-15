using System;
using System.Windows.Input;

namespace DependencyInjectionNutshell.Helpers
{
    public class SimpleRelayCommand : ICommand
    {
        private readonly Action<object> _executeAction;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SimpleRelayCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;        
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }       
    }
}
