﻿using System;
using Lab12.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskView();
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
