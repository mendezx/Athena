﻿using System;
using Mobile_FrontEnd.Pages;
using MobileFrontEnd.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_FrontEnd
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            // MainPage = new PostVideo();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
