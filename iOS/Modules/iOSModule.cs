// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOSModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.iOS.Modules
{
	using SpeechTalk.Ioc;

	using Autofac;

	public class IOSModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<TextToSpeech> ().As<ITextToSpeech> ().SingleInstance ();
		}
	}
}

