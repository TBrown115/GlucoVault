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
                    Id = 1,
                    RecipeId = 1,
                };
                 _database.Insert(dailymealplanner);

                var dietrequirement = new DietRequirement
                {
                    Id = 1,
                    Description = "Normal"
                };
                _database.Insert(dietrequirement);

                var dietaryoption = new DietaryOption
                {
                    Id = 1,
                    DietaryRequirements = 1,
                    BudgetOption = 250
                };
                _database.Insert(dietaryoption);

                var ingredient = new Ingredient
                {
                    Id = 1,
                    Description = "Strawberry, Banana, Orange Juice",
                    QuantityDescription = "1 cup",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "vault.png"

                };
                ingredient = new Ingredient
                {
                    Id = 1,
                    Description = "Strawberry",
                    QuantityDescription = "1 cup",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "vault.png"

                };
                ingredient = new Ingredient
                {
                    Id = 2,
                    Description = "Banana",
                    QuantityDescription = "1 medium",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "vault.png"

                };
                ingredient = new Ingredient
                {
                    Id = 3,
                    Description = "Orange Juice",
                    QuantityDescription = "1 cup",
                    Volume = 152,
                    VolumeUnit = "g",
                    Image = "vault.png"

                };
                _database.Insert(ingredient);

                var mealtype = new MealType
                {
                    Id = 1,
                    Description = "Breakfast"

                };
                

                var recipe = new Recipe
                {
                    Id = 1,
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

                var recipeingredient = new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 1
                };
                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 2
                };
                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 3
                };

                _database.Insert(recipeingredient);
                _database.UpdateWithChildren(recipe);

                //Apple
                dailymealplanner = new DailyMealPlan
                {
                    Id = 2,
                    RecipeId = 2,
                };
                _database.Insert(dailymealplanner);

                dietrequirement = new DietRequirement
                {
                    Id = 1,
                    Description = "Normal"
                };
                _database.Insert(dietrequirement);

                new DietaryOption
                {
                    Id = 1,
                    DietaryRequirements = 1,
                    BudgetOption = 250
                };
                _database.Insert(dietaryoption);

                ingredient = new Ingredient
                {
                    Id = 4,
                    Description = "Apple",
                    QuantityDescription = "1 Apple",
                    Volume = 129,
                    VolumeUnit = "g",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/1/15/Red_Apple.jpg"

                };
                
                _database.Insert(ingredient);

                mealtype = new MealType
                {
                    Id = 1,
                    Description = "Breakfast"

                };
                _database.Insert(mealtype);

                recipe = new Recipe
                {
                    Description = "Pick a Apple",
                    Prep = 0,
                    CookTime = 0,
                    Directions = "Wilt spinach down in a small skillet over low heat with 1/2 teaspoon of olive oil. Season to taste.Beat the eggs and add to the skillet with the spinach.Stir slowly over medium - low heat until they reach your desired doneness.Sprinkle in the feta cheese and stir to combine and soften the cheese.",
                    Volume = 7,
                    Price = 10,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg",
                    ServingSize = "1 Apple",
                    Calories = 94,
                    MealType = 1,
                    DietRequirementId = 1
                };
                _database.Insert(recipe);
                _database.UpdateWithChildren(recipe);

                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 3,
                    IngredientId = 9,
                };
                
                _database.Insert(recipeingredient);

                dailymealplanner = new DailyMealPlan
                {
                    Id = 2,
                    RecipeId = 2,
                };
                _database.Insert(dailymealplanner);

                dietrequirement = new DietRequirement
                {
                    Id = 1,
                    Description = "Normal"
                };
                _database.Insert(dietrequirement);

                new DietaryOption
                {
                    Id = 1,
                    DietaryRequirements = 1,
                    BudgetOption = 250
                };
                _database.Insert(dietaryoption);

                ingredient = new Ingredient
                {
                    Id = 4,
                    Description = "Olive oil",
                    QuantityDescription = "1 cup",
                    Volume = 2,
                    VolumeUnit = "g",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg"

                };
                ingredient = new Ingredient
                {
                    Id = 5,
                    Description = "Feta cheese",
                    QuantityDescription = "0.13 cup crumbled",
                    Volume = 18,
                    VolumeUnit = "g",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg"

                };
                ingredient = new Ingredient
                {
                    Id = 6,
                    Description = "Spinach(Raw)",
                    QuantityDescription = "1 cup",
                    Volume = 30,
                    VolumeUnit = "g",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg"

                };
                ingredient = new Ingredient
                {
                    Id = 7,
                    Description = "Egg",
                    QuantityDescription = "2 large",
                    Volume = 100,
                    VolumeUnit = "g",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg"

                };
                _database.Insert(ingredient);

                mealtype = new MealType
                {
                    Id = 1,
                    Description = "Breakfast"

                };
                _database.Insert(mealtype);

                recipe = new Recipe
                {
                    Description = "Scrambled Eggs with Spinach and Feta",
                    Prep = 5,
                    CookTime = 10,
                    Directions = "Wilt spinach down in a small skillet over low heat with 1/2 teaspoon of olive oil. Season to taste.Beat the eggs and add to the skillet with the spinach.Stir slowly over medium - low heat until they reach your desired doneness.Sprinkle in the feta cheese and stir to combine and soften the cheese.",
                    Volume = 6,
                    Price = 25,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Scrambled_Eggs_at_Cracker_Barrel.jpg",
                    ServingSize = "1 services",
                    Calories = 280,
                    MealType = 1,
                    DietRequirementId = 1
                };
                _database.Insert(recipe);
                _database.UpdateWithChildren(recipe);

                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 9,
                };
                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 10,
                };
                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 11,
                };
                recipeingredient = new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 12,
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
