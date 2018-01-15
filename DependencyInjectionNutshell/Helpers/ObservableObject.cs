using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DependencyInjectionNutshell.Helpers
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SetProperty<T>(ref T member, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(member, newValue))
            {
                return;
            }

            member = newValue;
            OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
