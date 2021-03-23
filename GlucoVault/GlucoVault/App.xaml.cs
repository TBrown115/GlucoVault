using GlucoVault.Services;
using GlucoVault.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GlucoVault
{
    public partial class App : Application
    {
        public static MealDatabase Database { get; set; }
        public App()
        {
            InitializeComponent();

            Database = new MealDatabase();

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
