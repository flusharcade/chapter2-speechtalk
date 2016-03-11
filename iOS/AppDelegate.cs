// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDelegate.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using SpeechTalk.Modules;

namespace SpeechTalk.iOS
{
	using Foundation;
	using UIKit;

	using SpeechTalk.Ioc;
	using SpeechTalk.iOS.Modules;

	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			initIoC ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}

		private void initIoC()
		{
			IoC.CreateContainer ();
			IoC.RegisterModule (new IOSModule());
			IoC.RegisterModule (new PCLModule());
			IoC.StartContainer ();
		}
	}
}

