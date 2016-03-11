// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextToSpeechDroid.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.Droid
{
	using System.Collections.Generic;

	using Android.Speech.Tts;

	using Xamarin.Forms;

	/// <summary>
	/// Text to speech droid.
	/// </summary>
	public class TextToSpeechDroid :  Java.Lang.Object, ITextToSpeech, Android.Speech.Tts.TextToSpeech.IOnInitListener
	{
		Android.Speech.Tts.TextToSpeech speaker;

		string toSpeak;

		public void Speak (string msg)
		{
			var ctx = Forms.Context; // useful for many Android SDK features
			toSpeak = msg;

			if (speaker == null) 
			{
				speaker = new Android.Speech.Tts.TextToSpeech (ctx, this);
			} 
			else 
			{
				var p = new Dictionary<string,string> ();
				speaker.Speak (toSpeak, QueueMode.Flush, p);
			}
		}

		#region TextToSpeech.IOnInitListener implementation

		public void OnInit (OperationResult status)
		{
			if (status.Equals (OperationResult.Success)) 
			{
				var p = new Dictionary<string,string> ();
				speaker.Speak (toSpeak, QueueMode.Flush, p);
			}
		}

		#endregion
	}
}

