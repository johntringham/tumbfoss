﻿using DashFoss.Services;
using DashFoss.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DashFoss
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<TumblrDashboardPostsDataStore>();
            MainPage = new AppShell();
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
