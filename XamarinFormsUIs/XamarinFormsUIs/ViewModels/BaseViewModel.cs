using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsUIs.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetProperty<T>(T value, ref T storage, [CallerMemberName] string propertyName = "")
        {
            storage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
