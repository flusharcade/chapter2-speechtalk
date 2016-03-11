// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DroidModule.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Droid.Modules
{
	using Autofac;

	using SpeechTalk.Ioc;
	using SpeechTalk.Droid;

	public class DroidModule : IModule
	{
		public void Register(ContainerBuilder builer)
		{
			builer.RegisterType<TextToSpeechDroid> ().As<ITextToSpeech> ().SingleInstance ();
		}
	}
}

