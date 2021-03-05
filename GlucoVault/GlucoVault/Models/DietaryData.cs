using System;
using System.Collections.Generic;
using System.Text;

namespace GlucoVault.Models
{
	public class DietaryData
	{
		public static IList<Dietary> Dietaries { get; private set; }

		static DietaryData()
		{
			Dietaries = new List<Dietary>();

			Dietaries.Add(new Dietary
			{
				Name = "Normal",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Vegan",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Vegetarian",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Checken",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Kosher",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Dietaries.Add(new Dietary
			{
				Name = "Halaal",
				Breakfast = "Oats, Skim milk and Tea/Coffee (without sugar)",
				Lunch = "Chicken breast (Grilled/steamed, Lettuce, tomato and avocado",
				Dinner = "Brown rice, Carrot grated and Steamed broccoli",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

		}
	}
}
