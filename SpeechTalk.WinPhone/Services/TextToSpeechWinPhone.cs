// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextToSpeechWinPhone.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.WinPhone.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Windows.Media.SpeechSynthesis;
    using Windows.UI.Xaml.Controls;

    public class TextToSpeechWinPhone : ITextToSpeech
    {
        public TextToSpeechWinPhone() 
        { 
        }

        public async void Speak(string text)
        {
            MediaElement mediaElement = new MediaElement();

            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text);

            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
