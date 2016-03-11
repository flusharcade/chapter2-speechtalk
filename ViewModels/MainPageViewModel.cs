// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelBase.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.ViewModels
{
	using System;
	using System.Windows.Input;

	using Xamarin.Forms;

	public class MainPageViewModel : ViewModelBase
	{
		#region Private Properties

		private readonly ITextToSpeech textToSpeech;

		private string descriptionMessage = "Enter text and press the 'Speak' button to start speaking";

		private string speakEntryPlaceholder = "Text to speak";

		private string speakText = string.Empty;

		private string speakTitle = "Speak";

		private ICommand speakCommand;

		#endregion

		#region Public Properties

		public string DescriptionMessage
		{
			get
			{
				return this.descriptionMessage;
			}

			set
			{
				if (value.Equals(this.descriptionMessage))
				{
					return;
				}

				this.descriptionMessage = value;
				this.OnPropertyChanged("DescriptionMessage");
			}
		}

		public string SpeakEntryPlaceholder
		{
			get
			{
				return this.speakEntryPlaceholder;
			}

			set
			{
				if (value.Equals(this.speakEntryPlaceholder))
				{
					return;
				}

				this.speakEntryPlaceholder = value;
				this.OnPropertyChanged("SpeakEntryPlaceholder");
			}
		}

		public string SpeakText
		{
			get
			{
				return this.speakText;
			}

			set
			{
				if (value.Equals(this.speakText))
				{
					return;
				}

				this.speakText = value;
				this.OnPropertyChanged("SpeakText");
			}
		}

		public string SpeakTitle
		{
			get
			{
				return this.speakTitle;
			}

			set
			{
				if (value.Equals(this.speakTitle))
				{
					return;
				}

				this.speakTitle = value;
				this.OnPropertyChanged("SpeakTitle");
			}
		}

		public ICommand SpeakCommand
		{
			get
			{
				return this.speakCommand;
			}

			set
			{
				if (value.Equals(this.speakCommand))
				{
					return;
				}

				this.speakCommand = value;
				this.OnPropertyChanged("SpeakCommand");
			}
		}

		#endregion

		#region Constructors

		public MainPageViewModel (ITextToSpeech textToSpeech)
		{
			this.textToSpeech = textToSpeech;

			this.speakCommand = new Command ((c) => this.textToSpeech.Speak (this.SpeakText));
		}

		#endregion
	}
}

