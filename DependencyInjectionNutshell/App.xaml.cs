using System.Windows;
using Unity;

namespace DependencyInjectionNutshell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private UnityContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Register
            _container = Bootstrapper.Register();

            // Resolve
            MainWindow mainWindow = _container.Resolve<MainWindow>();

            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            // Release
            _container.Dispose();
        }
    }
}
