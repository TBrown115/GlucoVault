using GlucoVault.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dailymeal.db");
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
                _database.Insert(dietrequirement);

                var dietaryoption = new DietaryOption
                {
                    DietaryRequirements = 1,
                    BudgetOption = 250
                };
                _database.Insert(dietaryoption);

                var ingredient = new Ingredient
                {
                    Description = "Strawberry, Banana, Orange Juice",
                    QuantityDescription = "1 cup",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "vault.png"

                };
                _database.Insert(ingredient);

                var mealtype = new MealType
                {
                    Description = "Breakfast"

                };
                

                var recipe = new Recipe
                {
                    Description = "Breakfast fruit smoothie",
                    Prep = 7,
                    CookTime = 0,
                    Directions = "Just put all ingredients in the blender and blend until smooth.  Optionally, blend with ice.  Then drink and enjoy!",
                    Volume = 16,
                    Price = 15,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/7/7e/Strawberry_BNC.jpg",
                    ServingSize = "2 services",
                    Calories = 300,
                    MealType = 1,
                    DietRequirementId = 1
                };
                _database.Insert(recipe);
                _database.Insert(recipe);

                var recipeingredient = new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 1
                };
                
                _database.Insert(recipeingredient);
                _database.UpdateWithChildren(recipe);
      
            }
            if (_database.Table<Models.DailyMealPlan>().Count() == 0)
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
                _database.Insert(dietrequirement);

                var dietaryoption = new DietaryOption
                {
                    DietaryRequirements = 1,
                    BudgetOption = 250
                };
                _database.Insert(dietaryoption);

                var ingredient = new Ingredient
                {
                    Description = "Olive oil, Feta cheese,Spinach(Raw),Egg",
                    QuantityDescription = "1 cup",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg"

                };
                _database.Insert(ingredient);

                var mealtype = new MealType
                {
                    Description = "Breakfast"

                };
                _database.Insert(mealtype);

                var recipe = new Recipe
                {
                    Description = "Scrambled Eggs with Spinach and Feta",
                    Prep = 5,
                    CookTime = 10,
                    Directions = "Wilt spinach down in a small skillet over low heat with 1/2 teaspoon of olive oil. Season to taste.Beat the eggs and add to the skillet with the spinach.Stir slowly over medium - low heat until they reach your desired doneness.Sprinkle in the feta cheese and stir to combine and soften the cheese.",
                    Volume = 6,
                    Price = 25,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/7/7e/Strawberry_BNC.jpg",
                    ServingSize = "1 services",
                    Calories = 280,
                    MealType = 1,
                    DietRequirementId = 1
                };
                _database.Insert(recipe);
                _database.UpdateWithChildren(recipe);

                var recipeingredient = new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 9,
                };
                _database.Insert(recipeingredient);
                
            }
        }
        public List<Recipe> GetDailyMealPlans()
        {
            var recipe = _database.Table<Recipe>().ToList();

            return recipe;
        }

      /*  public Task<List<DailyMealPlan>> GetItemsNotDoneAsync()
        {
            return _database.Query<DailyMealPlan>("SELECT * FROM [DailyMealPlan] WHERE [Done] = 0");
        }*/
    }
}
