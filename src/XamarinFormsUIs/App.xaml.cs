using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsUIs
{
    public partial class App : Application
    {
        public App(Page page, object bindingContext)
        {
            InitializeComponent();

            MainPage = page;
            MainPage.BindingContext = bindingContext;
        }
    }
}
