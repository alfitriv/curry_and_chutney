using System;
using System.Collections.Generic;

namespace MYFIRSTAPP.Models
{
    public class Recipe
    {
        public int RecNo {get; set;}
        public string RecName {get; set;}
    }

    public class RecipeDatabase : List<Recipe>
    {
        public RecipeDatabase()
        {
            Add (new Recipe() {RecNo=1, RecName="Chutney"});
            Add (new Recipe() {RecNo=2, RecName="Sambhar"});
            Add (new Recipe() {RecNo=3, RecName="Curry"});
            Add (new Recipe() {RecNo=4, RecName="Bread and Pizza"});
            Add (new Recipe() {RecNo=5, RecName="Dessert"});
            Add (new Recipe() {RecNo=6, RecName="Rice"});
            Add (new Recipe() {RecNo=7, RecName="Dal"});
        }
    }
}



