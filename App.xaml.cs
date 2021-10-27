using BiometricAuthen.Services;
using BiometricAuthen.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("fabrands.otf", Alias = "fabrands")]
[assembly: ExportFont("faregular.otf", Alias = "faregular")]
[assembly: ExportFont("fasolid.otf", Alias = "fasolid")]

namespace BiometricAuthen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
