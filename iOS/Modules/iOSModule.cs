using System;

using TinyIoC;

namespace SpeechTalk.iOS
{
	public class iOSModule : IModule
	{
		private readonly TinyIoCContainer container;

		public iOSModule ()
		{
			this.container = TinyIoCContainer.Current;
		}

		public void Register()
		{
			
		}
	}
}

