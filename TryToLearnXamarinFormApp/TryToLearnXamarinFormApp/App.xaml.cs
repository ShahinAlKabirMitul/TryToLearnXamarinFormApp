using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TryToLearnXamarinFormApp.Layout;
using TryToLearnXamarinFormApp.Layout.Grid;
using TryToLearnXamarinFormApp.ListViewDemo;
using TryToLearnXamarinFormApp.Nagivations;
using Xamarin.Forms;

namespace TryToLearnXamarinFormApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Welcome())
            {
                BarBackgroundColor = Color.Gray,
                BarTextColor = Color.White
            };
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
