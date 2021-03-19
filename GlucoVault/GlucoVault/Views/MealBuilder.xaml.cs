using GlucoVault.Models;
using GlucoVault.ModelViews;
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
    public partial class MealBuilder : ContentPage
    {
        public MealBuilder()
        {
            InitializeComponent();


            BindingContext = new MealBuilderViewModel();
        }
    }
}