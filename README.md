# Xamarin.Forms In Visual Studio Mac

*Learn to use Xamarin.Forms to build user interfaces for your Visual Studio Mac extensions.*

## Introduction

Ever since I commercialised MFractor in June 2017, I've been pulled to the idea of using XAML and Xamarin.Forms to build user interfaces for Visual Studio Mac extensions.

For MFractor, developing tools like the Image Wizard or localisation wizard cost days to weeks of engineering effort. This time-cost makes it prohibitively expensive to develop tools that are UI-centric.

Therefore, there are compelling reasons to use Xamarin.Forms to build Visual Studio Mac extensions:

 * XAML is much, much easier to work with than XWT, Visual Studio Macs UI framework. This dramatically lowers the barrier to entry for developing Visual Studio Mac extensions.
 * Developing in XAML/Xamarin.Forms is much faster than XWT as it has a data-binding engine, we can build UIs declaratively in XAML and it is a very well documented API.
 * With a Xamarin.Forms WPF backend available, user interfaces are reusable in both Visual Studio Mac **and** Visual Studio Windows.
 * By using XAML to build MFractors UIs, I can use MFractor to build itself; an awesome process of dogfooding to accelerate product development.

There are huge productivity gains here!

In the tutorial below, I'll be walking through how we can use Xamarin.Forms inside Visual Studio Mac to build rich user interfaces. To prove that this technique is not just a toy, we'll be building an image asset browser you can use to visually explore images inside a solution. When I built this

## Using Xamarin.Forms Inside Visual Studio Mac

Let's get started!

First things first, you **must** have version 1.4.2 of the Addin Maker installed into Visual Studio Mac. Based on my many, many failed attempts at getting this to work, AddinMaker v1.4.2 is the one that works.

Next, you'll need to create a new Visual Studio Mac extension that is an SDK style project and references the NuGet MonoDevelop.Addins v0.4.4. I've found that the Xamarin.Forms bootstrapping process does not work in Visual Studio Mac extensions that are not SDK style projects.

If you have an existing extension, you'll need to upgrade your main extensions project to an SDK style project and reference NuGet MonoDevelop.Addins v0.4.4. I've found the best way to do this is



 * Add Xamarin.Forms and Xamarin.Forms.Platform.GTK nugets to the project.

 Next, we need to add Xamarin.Forms into our project.

 Add the following nuget packages into your Visual Studio Mac extension:
  * Xamarin.Forms
  * Xamarin.Forms.Platform.GTK.

 * Initialise Xamarin.Forms, create a startup command to do so.



 * Create our Xamarin.Forms .

 * Show our UI using a command handler in the tools menu.



## Closing Thoughts

As demonstrated,

 * We need to make an official Visual Studio Mac Xamarin.Forms extension to prevent multiple calls to Forms.Init() and potential assembly version conflicts.
 *

https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Barack_Obama_Mic_Drop_2016.jpg/440px-Barack_Obama_Mic_Drop_2016.jpg
