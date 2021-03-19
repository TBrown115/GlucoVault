using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace GlucoVault.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloodGlucosePage : ContentPage
    {
        public BloodGlucosePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;

            var items = await database.GetItemsAsync();

            List<Entry> chartEntries = new List<Entry>();

            foreach (var item in items)
            {
                var entry = new Entry((float)item.GlucLevel);
                chartEntries.Add(entry);
            }

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