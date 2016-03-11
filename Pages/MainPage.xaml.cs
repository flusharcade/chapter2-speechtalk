// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelBase.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Pages
{
	using System;
	using System.Collections.Generic;

	using Xamarin.Forms;

	using SpeechTalk.ViewModels;
	using SpeechTalk.Ioc;

	public partial class MainPage : ContentPage
	{
		private MainPageViewModel viewModel;

		public MainPage ()
		{
			this.InitializeComponent ();
		}

		public MainPage (MainPageViewModel model)
		{
			this.BindingContext = model;
			this.InitializeComponent ();
		}
	}
}

