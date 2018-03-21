using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinFormsUIs.Views
{
    public partial class ExtensionInfoView : ContentPage
    {
        public ExtensionInfoView()
        {
            InitializeComponent();

            var path = DirectoryForAssembly(Assembly.GetExecutingAssembly());

            image.Source = Path.Combine(path, "Assets", "doggo.jpg");
        }

        public static string DirectoryForAssembly(Assembly assembly)
        {
            string codeBase = assembly.CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
    }
}
