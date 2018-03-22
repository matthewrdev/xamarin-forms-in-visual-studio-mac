using System;
using System.Threading;
using System.Threading.Tasks;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using Xamarin.Forms.Platform.GTK;
using XamarinFormsUIs.Windows;
using Xwt;
using Xwt.GtkBackend;

namespace XamarinFormsUIs.Commands
{
    public class BrowseImageAssetsCommand : CommandHandler
    {
		protected override void Update(CommandInfo info)
		{
            info.Enabled = true;
            info.Visible = true;
		}

        protected override void Run()
        {
            new ImageAssetsWindow().Show();
        }
	}
}
