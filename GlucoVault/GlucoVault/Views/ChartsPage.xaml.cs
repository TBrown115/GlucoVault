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

            Chart1.Chart = new PointChart { Entries = entries };
            Chart2.Chart = new BarChart { Entries = entries };

        }
    }
}