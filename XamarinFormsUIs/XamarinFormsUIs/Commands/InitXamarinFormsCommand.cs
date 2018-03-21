using System;
using MonoDevelop.Components.Commands;
using Xamarin.Forms;

namespace XamarinFormsUIs.Commands
{
    public class InitXamarinFormsCommand : CommandHandler
    {
		protected override void Run()
		{
            Forms.Init();
            Console.WriteLine("Xamarin.Forms has been initialised");
		}
	}
}
