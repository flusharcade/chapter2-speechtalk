// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PCLModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Modules
{
	using System;

	using Autofac;

	using SpeechTalk.ViewModels;
	using SpeechTalk.Ioc;
	using SpeechTalk.Pages;

	public class PCLModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<MainPageViewModel> ().SingleInstance();
			builer.RegisterType<MainPage> ().SingleInstance();
		}
	}
}

