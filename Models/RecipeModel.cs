using System;
using System.Collections.Generic;

namespace MYFIRSTAPP.Models
{
    public class Recipe
    {
        public string Name {get; set;}
        public string Category {get; set;}
    }

    public class RecipeDatabase : List<Recipe>
    {
        public RecipeDatabase()
        {
            Add (new Recipe() {Name="Almond Chutney", Category="Chutney"});
            Add (new Recipe() {Name="Sunflower Seeds Chutney", Category="Chutney"});
            Add (new Recipe() {Name="Moong Dal Chutney", Category="Chutney"});
            Add (new Recipe() {Name="Kandipappu", Category="Chutney"});
            Add (new Recipe() {Name="Beet Root Leaves Chutney", Category="Chutney"});
            Add (new Recipe() {Name="Tomato Perugu Chutney", Category="Chutney"});
            Add (new Recipe() {Name="Vankaya Pachadi", Category="Chutney"});
            Add (new Recipe() {Name="Dosakaya Pachadi", Category="Chutney"});
            Add (new Recipe() {Name="Keera Dosakaya", Category="Chutney"});
            Add (new Recipe() {Name="Totakoora", Category="Sambhar"});
            Add (new Recipe() {Name="Keera Dosakaya", Category="Chutney"});
            Add (new Recipe() {Name="Keera Dosakaya", Category="Chutney"});

        }
    }
}



