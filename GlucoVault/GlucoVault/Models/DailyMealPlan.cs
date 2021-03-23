using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlucoVault.Models
{
    public class DailyMealPlan
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(Recipe))]
        public int RecipeId { get; set; }


        public string NameSort => NameSort[0].ToString();
    }

    public class DietRequirement
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }

        public string NameSort => NameSort[0].ToString();
    }

    public class DietaryOption
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int DietaryRequirements { get; set; }
        public int BudgetOption { get; set; }

        public string NameSort => NameSort[0].ToString();
    }

    public class Ingredient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public string QuantityDescription { get; set; }
        public int Volume { get; set; }
        public string VolumeUnit { get; set; }
        public string Image { get; set; }

        public string NameSort => NameSort[0].ToString();
    }

    public class MealType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }

        public string NameSort => NameSort[0].ToString();
    }

    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Prep { get; set; }
        public int CookTime { get; set; }
        public string Directions { get; set; }
        public int Volume { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string ServingSize { get; set; }
        public double Calories { get; set; }
        public int MealType { get; set; }

        [ForeignKey(typeof(DietaryOption))]
        public int DietRequirementId { get; set; }

        public string NameSort => NameSort[0].ToString();
    }

    public class RecipeIngredient
    {
        [ForeignKey(typeof(Recipe))]
        public int RecipeId { get; set; }

        [ForeignKey(typeof(Ingredient))]
        public int IngredientId { get; set; }

        public string NameSort => NameSort[0].ToString();
    }
}
