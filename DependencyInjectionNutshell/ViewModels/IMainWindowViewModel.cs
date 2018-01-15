using System.Windows.Input;
using DependencyInjectionNutshell.Model;

namespace DependencyInjectionNutshell.ViewModels
{
    public interface IMainWindowViewModel
    {
        string Title { get; }
        Customer[] Customers { get; set; }      
        ICommand ShowDialogCommand { get; set; }
    }
}
