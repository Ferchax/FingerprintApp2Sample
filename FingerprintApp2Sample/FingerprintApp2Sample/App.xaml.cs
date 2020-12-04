﻿using FingerprintApp2Sample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FingerprintApp2Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FingerprintPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
