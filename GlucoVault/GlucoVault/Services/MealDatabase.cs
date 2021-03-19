using GlucoVault.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace GlucoVault.Services
{
    public class MealDatabase
    {
        private SQLiteConnection _database;

        public MealDatabase()
        {
            var path = GetDbPath();
            _database = new SQLiteConnection(path);

            _database.CreateTable<DailyMealPlan>();
            _database.CreateTable<DietRequirement>();
            _database.CreateTable<DietaryOption>();
            _database.CreateTable<Ingredient>();
            _database.CreateTable<MealType>();
            _database.CreateTable<Recipe>();
            _database.CreateTable<RecipeIngredient>();

            SeedDatabase();
        }

        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "meals.db");
            return path;
        }

        public void SeedDatabase()
        {
            if (_database.Table<DailyMealPlan>().Count() == 0)
            {
                var dailymealplanner = new DailyMealPlan
                {
                    RecipeId = 1,
                };
                _database.Insert(dailymealplanner);

                var dietrequirement = new DietRequirement
                {
                    Description = "Normal"
                };

                var dietaryoption = new DietaryOption
                {
                    DietaryRequirements = 1,
                    BudgetOption = 250
                };

                var ingredient = new Ingredient
                {
                    Description = "Strawberry",
                    QuantityDescription = "1 cup",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "wwww"

                };

                var mealtype = new MealType
                {
                    Description = "Breakfast"

                };

                var recipe = new Recipe
                {
                    Description = "gg",
                    Prep = 1,
                    CookTime = 1,
                    Directions = "Wilt spinach down in a small skillet over low heat with 1/2 teaspoon of olive oil. Season to taste.Beat the eggs and add to the skillet with the spinach.Stir slowly over medium - low heat until they reach your desired doneness.Sprinkle in the feta cheese and stir to combine and soften the cheese.",
                    Volume = 6,
                    Price = 15,
                    Image = "www",
                    ServingSize = "2 services",
                    Calories = 25,
                    MealType = 1,
                    DietRequirementId = 1
                };

                var recipeingredient = new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 1
                };
                _database.Insert(dailymealplanner);
                _database.Insert(dietrequirement);
                _database.Insert(dietaryoption);
                _database.Insert(ingredient);
                _database.Insert(mealtype);
                _database.Insert(recipe);
                _database.Insert(recipeingredient);
            }
        }
        public List<DailyMealPlan> GetDailyMealPlans()
        {
            var dailymealplanners = _database.Table<DailyMealPlan>().ToList();

            return dailymealplanners;
        }
    } 
}
