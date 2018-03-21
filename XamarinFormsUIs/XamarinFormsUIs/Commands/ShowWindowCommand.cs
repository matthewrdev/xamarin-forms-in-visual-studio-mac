using System;
using System.Threading;
using System.Threading.Tasks;
using MonoDevelop.Components.Commands;
using Xamarin.Forms.Platform.GTK;

namespace XamarinFormsUIs.Commands
{
    public class ShowWindowCommand : CommandHandler
    {
		protected override void Update(CommandInfo info)
		{
            info.Enabled = true;
            info.Visible = true;
		}

        protected override void Run()
        {
            var window = new FormsWindow();
            var page = new Views.ExtensionInfoView();
            window.LoadApplication(new App(page, new ViewModels.ExtensionInfoViewModel()));
            window.SetApplicationTitle("Extension Info");
            window.Show();
            window.SetSizeRequest(300, 400);

            var bin = RendererFactory.CreateRenderer(page) as Gtk.Bin;
            Console.Write(bin);
        }
	}
}
