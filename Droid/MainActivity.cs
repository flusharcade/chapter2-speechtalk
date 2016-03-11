// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Droid
{
	using System;

	using Android.App;
	using Android.Content;
	using Android.Content.PM;
	using Android.Runtime;
	using Android.Views;
	using Android.Widget;
	using Android.OS;

	using SpeechTalk.Ioc;
	using SpeechTalk.Modules;
	using SpeechTalk.Droid.Modules;

	[Activity (Label = "SpeechTalk.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			this.initIoC ();

			LoadApplication (new App ());
		}

		private void initIoC()
		{
			IoC.CreateContainer ();
			IoC.RegisterModule (new DroidModule());
			IoC.RegisterModule (new PCLModule());
			IoC.StartContainer ();
		}
	}
}

