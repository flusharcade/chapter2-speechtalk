﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DroidModule.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Droid.Modules
{
	using Autofac;

	using SpeechTalk.Ioc;
	using SpeechTalk.Droid;

	/// <summary>
	/// Droid module.
	/// </summary>
	public class DroidModule : IModule
	{
		#region Public Methods

		/// <summary>
		/// Register the specified builer.
		/// </summary>
		/// <param name="builer">Builer.</param>
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<TextToSpeechDroid> ().As<ITextToSpeech> ().SingleInstance ();
		}

		#endregion
	}
}