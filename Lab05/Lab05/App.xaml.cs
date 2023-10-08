﻿using System;
using Lab05;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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