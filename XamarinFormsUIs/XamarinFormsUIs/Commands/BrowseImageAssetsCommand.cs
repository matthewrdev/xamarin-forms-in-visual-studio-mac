using System;
using System.Threading;
using System.Threading.Tasks;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms.Platform.GTK.Extensions;
using XamarinFormsUIs.ViewModels;
using XamarinFormsUIs.Views;
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

    public class ImageAssetsWindow : Gtk.Window
    {
        public ImageAssetsWindow()
            : base(Gtk.WindowType.Toplevel)
        {
            var page = new ImageAssetBrowserView();

            page.BindingContext = new ImageAssetBrowserViewModel(MonoDevelop.Ide.TypeSystem.TypeSystemService.Workspace.CurrentSolution);

            this.Add(page.CreateContainer());
            SetDefaultSize((int)page.WidthRequest, (int)page.HeightRequest);
            SetSizeRequest((int)page.WidthRequest, (int)page.HeightRequest);
        }
    }
}
