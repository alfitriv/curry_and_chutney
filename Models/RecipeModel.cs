using System;
using System.Collections.Generic;

namespace MYFIRSTAPP.Models
{
    public class Recipe
    {
        public string Name {get; set;}
        public string Category {get; set;}
        public string Ingredients {get; set;}
    }

    public class RecipeDatabase : List<Recipe>
    {
        public RecipeDatabase()
        {
            Add (new Recipe() {Name="Almond Chutney", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Almonds, Curd"});
            Add (new Recipe() {Name="Sunflower Seeds Chutney", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Moong Dal Chutney", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Kandipappu", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Beet Root Leaves Chutney", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Tomato Perugu Chutney", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Vankaya Pachadi", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Dosakaya Pachadi", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Keera Dosakaya", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Totakoora", Category="Sambhar", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Keera Dosakaya", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});
            Add (new Recipe() {Name="Keera Dosakaya", Category="Chutney", Ingredients="Red Chillies, Curry Leaves, Oil, Mustard Seeds, Sunflower seeds, Chana dal, Lemon juice"});

        }
    }
}



