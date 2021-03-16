using Xamarin.Forms;

namespace Todo
{
    public class VitalSignsListPageCS : ContentPage
    {
        ListView listView;

        public VitalSignsListPageCS()
        {
            Title = "Todo";

            var toolbarItem = new ToolbarItem
            {
                Text = "+",
                IconImageSource = Device.RuntimePlatform == Device.iOS ? null : "https://img.icons8.com/cute-clipart/64/000000/delete-sign.png"
            };
            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new VitalSignsItemPageCS
                {
                    BindingContext = new VitalSignsItem()
                });
            };
            ToolbarItems.Add(toolbarItem);

            listView = new ListView
            {
                Margin = new Thickness(20),
                ItemTemplate = new DataTemplate(() =>
                {
                    var label = new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    };
                    label.SetBinding(Label.TextProperty, "Name");



                    var tick = new Image
                    {
                        Source = ImageSource.FromFile("https://img.icons8.com/cute-clipart/64/000000/delete-sign.png"),
                        HorizontalOptions = LayoutOptions.End
                    };
                    tick.SetBinding(VisualElement.IsVisibleProperty, "Done");

                    var stackLayout = new StackLayout
                    {
                        Margin = new Thickness(20, 0, 0, 0),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children = { label, tick }
                    };

                    return new ViewCell { View = stackLayout };
                })
            };
            listView.ItemSelected += async (sender, e) =>
            {

                if (e.SelectedItem != null)
                {
                    await Navigation.PushAsync(new VitalSignsItemPageCS
                    {
                        BindingContext = e.SelectedItem as VitalSignsItem
                    });
                }
            };

            Content = listView;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }
    }
}
