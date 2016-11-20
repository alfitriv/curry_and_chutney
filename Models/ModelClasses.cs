using System;
using System.Collections.Generic;

namespace MYFIRSTAPP.Models
{
    public class Recipe
    {
        public int ID {get; set;}
        public string Category {get; set;}
    }

    public class RecipeDatabase : List<Recipe>
    {
        public RecipeDatabase()
        {
            Add (new Recipe() {ID=1, Category="Chutney"});
            Add (new Recipe() {ID=2, Category="Sambhar"});
            Add (new Recipe() {ID=3, Category="Curry"});
            Add (new Recipe() {ID=4, Category="Bread and Pizza"});
            Add (new Recipe() {ID=5, Category="Dessert"});
            Add (new Recipe() {ID=6, Category="Rice"});
            Add (new Recipe() {ID=7, Category="Dal"});
        }
    }
}



