using Xamarin.Forms.Platform.GTK.Extensions;
using XamarinFormsUIs.ViewModels;
using XamarinFormsUIs.Views;

namespace XamarinFormsUIs.Windows
{
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
