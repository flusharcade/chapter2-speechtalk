﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk
{
	using System;

	using Xamarin.Forms;

	using SpeechTalk.Pages;
	using SpeechTalk.Ioc;
	using SpeechTalk.Modules;

	public class App : Application
	{
		public App ()
		{
			var mainPage = IoC.Resolve<MainPage> ();
			this.MainPage = new NavigationPage(mainPage);
		}

		protected override void OnStart ()
		{
			
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

