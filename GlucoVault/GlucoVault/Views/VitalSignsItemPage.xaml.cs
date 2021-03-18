using System;
using Xamarin.Forms;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.ChartEntry;
using System.Collections.Generic;

namespace Todo
{
    public partial class TodoItemPage : ContentPage
    {

        public TodoItemPage()
        {
            InitializeComponent();

        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (VitalSignsItem)BindingContext;
            VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;
            await database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (VitalSignsItem)BindingContext;
            VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;
            await database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
