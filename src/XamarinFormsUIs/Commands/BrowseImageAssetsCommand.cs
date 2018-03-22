using MonoDevelop.Components.Commands;
using XamarinFormsUIs.Windows;

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
