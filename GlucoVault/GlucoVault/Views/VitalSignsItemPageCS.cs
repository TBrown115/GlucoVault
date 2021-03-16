using Xamarin.Forms;

namespace Todo
{
    public class VitalSignsItemPageCS : ContentPage
    {
        public VitalSignsItemPageCS()
        {
            Title = "Todo Item";

            var nameEntry = new Entry();
            nameEntry.SetBinding(Entry.TextProperty, "Name");
            
            var bloodLevelEntry = new Entry();
            bloodLevelEntry.SetBinding(Entry.TextProperty, "BloodLevel");

            var GlucLevelEntry = new Entry();
            GlucLevelEntry.SetBinding(Entry.TextProperty, "GlucLevel");

            var createdOnEntry = new Entry();
            createdOnEntry.SetBinding(Entry.TextProperty, "CreatedOn");

            var doneSwitch = new Switch();
            doneSwitch.SetBinding(Switch.IsToggledProperty, "Done");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var todoItem = (VitalSignsItem)BindingContext;
                VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;
                await database.SaveItemAsync(todoItem);
                await Navigation.PopAsync();
            };

            var deleteButton = new Button { Text = "Delete" };
            deleteButton.Clicked += async (sender, e) =>
            {
                var todoItem = (VitalSignsItem)BindingContext;
                VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;
                await database.DeleteItemAsync(todoItem);
                await Navigation.PopAsync();
            };

            var cancelButton = new Button { Text = "Cancel" };
            cancelButton.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    
                    new Label { Text = "Name" },
                    nameEntry,

                    new Label { Text = "BloodLevel" },
                    bloodLevelEntry,

                    new Label { Text = "CreatedOn" },
                    createdOnEntry,

                    new Label { Text = "GlucLevel" },
                    GlucLevelEntry,

                    new Label { Text = "Done" },
                    doneSwitch,
                    saveButton,
                    deleteButton,
                    cancelButton
                }
            };
        }
    }
}
