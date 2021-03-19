using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.ChartEntry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace GlucoVault.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartsPage : ContentPage
    {

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            VitalSignsItemDatabase database = await VitalSignsItemDatabase.Instance;

            var items = await database.GetItemsAsync();

            List<Entry> chartEntries = new List<Entry>();

            foreach (var item in items)
            {
                var entry = new Entry((float)item.GlucLevel)
                {
                    Color = SKColor.Parse("#FF1493"),
                    Label = "January",
                    ValueLabel = "299"
                };

                chartEntries.Add(entry);

            }

            Chart2.Chart = new LineChart { Entries = chartEntries };

        }


        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "January",
                ValueLabel = "200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#00BFFF"),
                Label = "January",
                ValueLabel = "400"
            },
            new Entry(100)
            {
                Color = SKColor.Parse("#00CED1"),
                Label = "January",
                ValueLabel = "100"
            }
        };


        public ChartsPage()
        {
            InitializeComponent();
            Chart2.Chart = new BarChart { Entries = entries };

        }
    }
}