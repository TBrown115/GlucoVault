using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlucoVault.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloodPressurePage : ContentPage
    {
        public BloodPressurePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new VitalSignsItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as VitalSignsItem
                });
            }
        }
    }
}