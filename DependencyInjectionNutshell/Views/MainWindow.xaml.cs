using System;
using System.Windows;
using DependencyInjectionNutshell.ViewModels;

namespace DependencyInjectionNutshell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainWindowViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException(nameof(viewModel));
            }

            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
