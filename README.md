# Xamarin.Forms In Visual Studio Mac
A proof of concept Visual Studio Mac extension that demonstrates how to use Xamarin.Forms to build VS Mac UIs.

## Introduction

Ever since I commercialised MFractor in June 2017, I've been pulled to the idea of using XAML and Xamarin.Forms to build user interfaces for Visaul Studio Mac extensions.

There are several compelling reasons to use Xamarin.Forms inside Visual Studio Mac:

 * XAML is much, much easier to work with than XWT, Visual Studio Macs UI framework. Using XAML to build UIs dramatically lowers the barrier to entry for developing Visual Studio Mac extensions.
 * With a Xamarin.Forms WPF backend available, user interfaces become reusable in both Visual Studio Mac **and** Visual Studio Windows.
 * By using XAML to build MFractors UIs, I can use MFractor to build MFractor; itself an awesome process of dogfooding to accelerate product development.

For MFractor, developing tools like the Image Wizard costs days to weeks of engineering effort and this time-cost makes it prohibitively expensive to develop these kind of tools.

While this article is a tutorial on using Xamarin.Forms to build user interfaces in VS Mac, it's also a candid look at the several attempts/misfires it took to get this to work.

If you're after just the tutorial, jump straight to Using Xamarin.Forms Inside Visual Studio Mac. If you'd like the story, then read on...

## A Short History of Failures and Misfires

It wasn't straighforward

### August 2017 - Xamarin.Forms macOS Bootstrapper


### January 2018 - Xamarin.Forms GTK Bootstrapper



### March 2018 - Success!

 * MVP Summit
 * Spoke to Javier Suarez (MVP from Spain who built Xamarin.Forms.Platform.GTK) about using GTK for forms UIs
  *



## Using Xamarin.Forms Inside Visual Studio Mac

Let's jump into the fun stuff, the nuts and bolts

 * Install AddinMaker 1.4.2.
 * Create a Visual Studio for Mac extension, make sure it's an SDK style project.
 * Add Xamarin.Forms and Xamarin.Forms.Platform.GTK nugets to the project.
 * Initialise Xamarin.Forms, create a startup command to do so.
 * Create our Xamarin.Forms .
 * Show our UI using a command handler in the tools menu.



## Closing Thoughts

 * We need to make an official Visual Studio Mac Xamarin.Forms extension to prevent multiple calls to Forms.Init() and potential assembly version conflicts.
 *

https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Barack_Obama_Mic_Drop_2016.jpg/440px-Barack_Obama_Mic_Drop_2016.jpg
