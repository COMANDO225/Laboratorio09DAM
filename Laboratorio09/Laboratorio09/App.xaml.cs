using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio09
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }
        public App()
        {
            InitializeComponent();
            //DependencyService.Register<MockDataStore>();
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
