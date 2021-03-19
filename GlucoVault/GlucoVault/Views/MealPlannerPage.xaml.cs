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
    public partial class MealPlannerPage : ContentPage
    {
		public IList<Dietary> Dietaries { get; private set; }
		public MealPlannerPage()
        {
            InitializeComponent();
			//BindingContext = new DietariesPageViewModel();

			Dietaries = new List<Dietary>();

			Dietaries.Add(new Dietary
			{
				Name = "Normal",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				Calories = 255,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			/*Dietaries.Add(new Dietary
			{
				Name = "Vegan",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				Calories = 255,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Vegetarian",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Checken",
				Calories = 255,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Kosher",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				Calories = 255,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Halaal",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				Calories = 255,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});*/
			BindingContext = this;
		}
        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dietary selectedItem = e.CurrentSelection[0] as Dietary;
        }
    }
}