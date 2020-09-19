using System;
using TwoColumnListView.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwoColumnListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FruitListView();
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
