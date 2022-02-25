using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR_11_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VerticalPage();
            
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
