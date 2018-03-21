using System;
using XamarinFormsUIs.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsUIs.ViewModels
{
    public class ExtensionInfoViewModel : BaseViewModel
    {
        public ICommand ShowMeTheDoggoCommand
        {
            get
            {
                return new Command(() =>
                {
                    throw new NotImplementedException();
                });
            }
        }

        private string _extensionAuthor = "Matthew Robbins";
        public string ExtensionAuthor
        {
            get
            {
                return _extensionAuthor;
            }
            set
            {
                SetProperty(value, ref _extensionAuthor);
            }
        }

        private string _extensionVersion = "1.0.0";
        public string ExtensionVersion
        {
            get
            {
                return _extensionVersion;
            }
            set
            {
                SetProperty(value, ref _extensionVersion);
            }
        }

        private string _extensionName = "Hello Doggos!";
        public string ExtensionName
        {
            get
            {
                return _extensionName;
            }
            set
            {
                SetProperty(value, ref _extensionName);
            }
        }
    }
}