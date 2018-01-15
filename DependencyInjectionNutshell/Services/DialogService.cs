using System.Windows;

namespace DependencyInjectionNutshell.Services
{
    public class DialogService : IDialogService
    {
        public void ShowDialog(string text)
        {
            MessageBox.Show(text, "Dialog Service", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
