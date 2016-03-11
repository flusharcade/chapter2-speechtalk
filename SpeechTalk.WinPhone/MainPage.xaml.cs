// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SpeechTalk.WinPhone
{
    using SpeechTalk.Ioc;
    using SpeechTalk.Modules;
    using SpeechTalk.WinPhone.Modules;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;

    using Windows.ApplicationModel.Activation;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Navigation;

    using Xamarin.Forms;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.initIoC();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            LoadApplication(new SpeechTalk.App());
        }

        private void initIoC()
        {
            IoC.CreateContainer();
            IoC.RegisterModule(new WinPhoneModule());
            IoC.RegisterModule(new PCLModule());
            IoC.StartContainer();
        }
    }
}
