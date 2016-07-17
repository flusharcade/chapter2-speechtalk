﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PCLModule.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Modules
{
	using Autofac;

	using SpeechTalk.ViewModels;
	using SpeechTalk.Ioc;
	using SpeechTalk.Pages;

	/// <summary>
	/// PCLM odule.
	/// </summary>
	public class PCLModule : IModule
	{
		#region Public Methods

		/// <summary>
		/// Register the specified builer.
		/// </summary>
		/// <param name="builer">Builer.</param>
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<MainPageViewModel> ().SingleInstance();
			builer.RegisterType<MainPage> ().SingleInstance();
		}

		#endregion
	}
}