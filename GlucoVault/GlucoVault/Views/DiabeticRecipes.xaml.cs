using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlucoVault.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiabeticRecipes : ContentPage
    {
        public DiabeticRecipes()
        {
            InitializeComponent();
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
        }
    }
}